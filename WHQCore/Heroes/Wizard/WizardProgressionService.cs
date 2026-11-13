using WHQCore.Helpers;
using WHQCore.Heroes.Wizard.Spells;
using WHQCore.Logic;
using WHQCore.Models;

namespace WHQCore.Heroes.Wizard;

public class WizardProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return null;
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        return SpellLibrary.GetSpellByValue(roll);
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return WizardLevelProgressionTable.Progression.TryGetValue(level, out progression);
    }

    public override void ApplyProgression(Hero character)
    {
        if (!TryGetProgression(character.BattleLevel, out var progression))
            return;

        StatProgressionApplier.Apply(character, progression);

        if (progression.GainsWoundRoll)
            ApplyWoundRoll(character);
    }

    public List<Spell> GetAvailableSpellsForLevel(
        Hero character,
        List<int> rolledDice)
    {
        var possibleCastingNumbers = DiceRoller
            .GetPossibleCastingNumbers(rolledDice)
            .OrderBy(n => n)
            .ToList();

        var availableSpells = new List<Spell>();

        foreach (var cn in possibleCastingNumbers)
        {
            availableSpells.AddRange(
                SpellLibrary.GetSpellsByCastingNumber(
                        cn.ToString())
                    .Where(s =>
                        !character.Spells.Any(
                            cs => cs.SpellName == s.SpellName))
            );
        }

        return availableSpells
            .DistinctBy(s => s.SpellName)
            .ToList();
    }

    public List<int> RollSpellDice(
        Hero character)
    {
        var dice = new List<int>();

        for (var i = 0; i < character.BattleLevel; i++)
        {
            dice.Add(DiceRoller.RollD6());
        }

        return dice;
    }

    public void LearnSpell(
        Hero character,
        Spell spell)
    {
        if (character.Spells.Any(
                s => s.SpellName == spell.SpellName))
        {
            return;
        }

        character.Spells.Add(spell);
    }
}