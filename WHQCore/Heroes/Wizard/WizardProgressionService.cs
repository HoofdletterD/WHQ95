using WHQCore.Helpers;
using WHQCore.Libraries.Spells;
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

        // Custom for Wizard: use proper spell selection
        if (progression.GainsRandomSpell)
            HandleSpellSelectionOnLevelUp(character);
    }

    private void HandleSpellSelectionOnLevelUp(Hero character)
    {
        var newLevel = character.BattleLevel;
        Console.WriteLine($"\nYour Wizard has reached Battle-level {newLevel}! Time to learn new spells.");

        // 1. Roll dice equal to new level
        List<int> remainingDice = new();
        for (var i = 0; i < newLevel; i++)
            remainingDice.Add(DiceRoller.RollD6());

        Console.WriteLine("You rolled the following dice:");
        Console.WriteLine(" - " + string.Join(", ", remainingDice));

        character.Spells ??= new List<Spell>();
        var spellsChosen = 0;

        while (spellsChosen < 3 && remainingDice.Count > 0)
        {
            // 2. Determine all possible casting numbers from current dice
            var possibleCastingNumbers = DiceRoller
                .GetPossibleCastingNumbers(remainingDice)
                .OrderBy(n => n)
                .ToList();

            if (possibleCastingNumbers.Count == 0)
            {
                Console.WriteLine("No more casting numbers can be formed from remaining dice.");
                break;
            }

            // 3. Get all available spells for these casting numbers
            var availableSpells = new List<Spell>();
            foreach (var cn in possibleCastingNumbers)
            {
                availableSpells.AddRange(
                    SpellLibrary.GetSpellsByCastingNumber(cn.ToString())
                    .Where(s => !character.Spells.Any(cs => cs.SpellName == s.SpellName))
                );
            }

            if (availableSpells.Count == 0)
            {
                Console.WriteLine("No more spells available for the casting numbers you can form.");
                break;
            }

            // 4. Show available spells
            Console.WriteLine("\nAvailable Spells:");
            for (var i = 0; i < availableSpells.Count; i++)
            {
                var s = availableSpells[i];
                Console.WriteLine($"{i + 1}. {s.SpellName} (CN {s.CastingNumber}) [{string.Join(", ", s.SpellTypes)}]");
            }

            Console.WriteLine($"Choose a spell to view (1-{availableSpells.Count}) or press Enter to stop:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                break;

            if (!int.TryParse(input, out var choice) || choice < 1 || choice > availableSpells.Count)
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            var chosenSpell = availableSpells[choice - 1];

            // Show details
            Console.WriteLine($"\n--- {chosenSpell.SpellName} ---");
            Console.WriteLine($"Casting Number: {chosenSpell.CastingNumber}");
            Console.WriteLine($"Type: {string.Join(", ", chosenSpell.SpellTypes)}");
            Console.WriteLine($"Rules: {chosenSpell.Rules}");
            Console.WriteLine();

            Console.Write("Add this spell? (y = add, any other key = cancel): ");
            var confirm = Console.ReadLine();
            if (!string.Equals(confirm, "y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Not added. Returning to spell list.");
                continue;
            }

            // 5. Deduct dice that match the spell's CN
            var targetCN = int.Parse(chosenSpell.CastingNumber);
            if (!DiceRoller.RemoveDiceForCastingNumber(remainingDice, targetCN))
            {
                Console.WriteLine($"Error: Could not remove dice for CN {targetCN}, this should not happen!");
                break;
            }

            character.Spells.Add(chosenSpell);
            spellsChosen++;

            Console.WriteLine($"Added: {chosenSpell.SpellName} (CN {chosenSpell.CastingNumber})");
            Console.WriteLine($"Remaining dice: {string.Join(", ", remainingDice)}");
        }

        Console.WriteLine("\nSpell selection complete.");
    }
}