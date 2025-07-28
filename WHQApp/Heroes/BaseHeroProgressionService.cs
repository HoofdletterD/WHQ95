using WHQApp.Helpers;
using WHQApp.Logic;
using WHQApp.Models;

namespace WHQApp.Heroes;

public abstract class BaseHeroProgressionService : IHeroProgression
{
    public virtual void LevelUp(Hero character)
    {
        if (character.BattleLevel >= 10)
        {
            Console.WriteLine("Maximum level reached.");
            return;
        }

        var nextLevel = character.BattleLevel + 1;

        if (!Hero.GoldCostPerLevel.TryGetValue(nextLevel, out var cost))
        {
            Console.WriteLine("No gold cost found for next level.");
            return;
        }

        if (character.Gold < cost)
        {
            Console.WriteLine($"Not enough gold to level up (need {cost}).");
            return;
        }

        character.Gold -= cost;
        character.BattleLevel++;

        ApplyProgression(character);
    }

    protected abstract Skill GetSkillByRoll(string roll);

    protected virtual void ApplyRandomSkill(Hero character)
    {
        Skill newSkill = null;
        var existingValues = new HashSet<string>(character.Skills.Select(s => s.Value));
        var attempts = 0;

        do
        {
            if (attempts++ > 10)
                break;

            var roll = DiceRoller.Roll2D6();
            newSkill = GetSkillByRoll(roll.ToString());
        } while (newSkill != null && existingValues.Contains(newSkill.Value));

        if (newSkill != null && !existingValues.Contains(newSkill.Value))
        {
            character.Skills.Add(newSkill);
            Console.WriteLine($"New skill gained: {newSkill.Name}");
        }
    }

    public virtual void ApplyProgression(Hero character)
    {
        if (!TryGetProgression(character.BattleLevel, out var progression))
            return;

        StatProgressionApplier.Apply(character, progression);

        if (progression.GainsWoundRoll)
            ApplyWoundRoll(character);

        if (progression.GainsRandomSkill)
            ApplyRandomSkill(character);
    }

    protected abstract bool TryGetProgression(int level, out ILevelProgression progression);

    protected virtual void ApplyWoundRoll(Hero character)
    {
        var roll = DiceRoller.RollDie(6);
        var rerolled = false;

        if (roll == 1)
        {
            roll = DiceRoller.RollDie(6);
            rerolled = true;
        }

        character.StartingWounds += roll;
        character.AddSkillNote($"(rolled {roll}{(rerolled ? " 1 rerolled" : "")})");
    }
}