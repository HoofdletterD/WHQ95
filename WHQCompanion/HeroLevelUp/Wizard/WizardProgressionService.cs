using WHQCore.Helpers;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Spells;

namespace WHQCompanion.HeroLevelUp.Wizard;

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

        // Custom for Wizard: use proper spell selection
        if (progression.GainsRandomSpell)
            HandleSpellSelectionOnLevelUp(character);
    }

    private void HandleSpellSelectionOnLevelUp(Hero character)
    {
        var newLevel = character.BattleLevel;

        Console.WriteLine($"\nYour Wizard has reached Battle-level {newLevel}! Time to learn new spells.");

        // 1. Roll dice equal to new level
        List<int> rolls = new();
        for (var i = 0; i < newLevel; i++)
        {
            var roll = DiceRoller.RollD6();
            rolls.Add(roll);
        }

        Console.WriteLine("You rolled the following dice:");
        Console.WriteLine(" - " + string.Join(", ", rolls));

        // 2. Generate all valid casting number combinations
        var allCombos = DiceRoller.SpellDiceCombiner.GenerateAllCastingCombinations(rolls);

        // 3. Collect all unique casting numbers from those combinations
        var allCastingNumbers = allCombos
            .SelectMany(combo => combo)
            .Distinct()
            .ToList();

        // 4. Find all spells with those casting numbers, excluding known spells
        var knownSpellNames = new HashSet<string>(character.Spells.Select(s => s.SpellName));

        var availableSpells = allCastingNumbers
            .SelectMany(cn => SpellLibrary.GetSpellsByCastingNumber(cn.ToString()))
            .Where(spell => !knownSpellNames.Contains(spell.SpellName))
            .DistinctBy(spell => spell.SpellName)
            .OrderBy(spell => int.Parse(spell.CastingNumber))
            .ThenBy(spell => spell.SpellName)
            .ToList();

        if (availableSpells.Count == 0)
        {
            Console.WriteLine("No new spells are available from the current casting number combinations.");
            return;
        }

        // 5. Show all available spells
        Console.WriteLine("\nAvailable Spells:");
        for (var i = 0; i < availableSpells.Count; i++)
        {
            var s = availableSpells[i];
            Console.WriteLine($"{i + 1}. {s.SpellName} (CN {s.CastingNumber}) [{string.Join(", ", s.SpellTypes)}]");
        }

        // 6. Let user pick up to 3
        Console.WriteLine("\nChoose up to 3 spells to learn (enter numbers separated by commas):");
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        var selectedIndexes = input.Split(',')
            .Select(s => s.Trim())
            .Where(s => int.TryParse(s, out _))
            .Select(int.Parse)
            .Where(i => i >= 1 && i <= availableSpells.Count)
            .Distinct()
            .Take(3)
            .ToList();

        foreach (var index in selectedIndexes)
        {
            var spell = availableSpells[index - 1];
            character.Spells.Add(spell);
            Console.WriteLine($"Added spell: {spell.SpellName} (CN {spell.CastingNumber})");
        }

        Console.WriteLine();
    }
}