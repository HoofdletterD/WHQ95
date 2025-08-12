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

        // 1) Roll dice equal to new level (these determine the points pool)
        var rolledDice = new List<int>();
        for (var i = 0; i < newLevel; i++)
            rolledDice.Add(DiceRoller.RollD6());

        var remainingPoints = rolledDice.Sum();
        Console.WriteLine("You rolled the following dice:");
        Console.WriteLine(" - " + string.Join(", ", rolledDice));
        Console.WriteLine($"Total casting number points to spend: {remainingPoints}");

        var spellsChosen = 0;
        character.Spells ??= []; // ensure list exists
        var knownSpellNames = new HashSet<string>(character.Spells.Select(s => s.SpellName));

        while (spellsChosen < 3 && remainingPoints > 0)
        {
            //Console.WriteLine($"\nRemaining casting number points: {remainingPoints} (dice: {string.Join(", ", rolledDice)})");

            // Build grouped available spells: all spells with CN <= remainingPoints, excluding known spells
            var availableByCN = new SortedDictionary<int, List<Spell>>();
            var seenSpellNames = new HashSet<string>();

            for (int cn = 1; cn <= remainingPoints; cn++)
            {
                var spellsForCn = SpellLibrary.GetSpellsByCastingNumber(cn.ToString());
                if (spellsForCn == null || !spellsForCn.Any()) continue;

                foreach (var s in spellsForCn)
                {
                    if (s == null) continue;
                    if (knownSpellNames.Contains(s.SpellName)) continue;
                    if (!seenSpellNames.Add(s.SpellName)) continue; // avoid duplicates across CN loop (defensive)

                    if (!availableByCN.TryGetValue(cn, out var list))
                    {
                        list = new List<Spell>();
                        availableByCN[cn] = list;
                    }

                    list.Add(s);
                }
            }

            if (availableByCN.Count == 0)
            {
                Console.WriteLine("No available spells you can afford with current points (or all available ones are already known).");
                break;
            }

            // Present grouped list and build a flat index
            var indexToEntry = new Dictionary<int, (Spell spell, int cn)>();
            var displayIndex = 1;
            Console.WriteLine("\nAvailable Spells:");
            foreach (var kvp in availableByCN)
            {
                Console.WriteLine($"Casting Number {kvp.Key}:");
                foreach (var s in kvp.Value)
                {
                    Console.WriteLine($" {displayIndex}. {s.SpellName} (CN {s.CastingNumber}) [{string.Join(", ", s.SpellTypes)}]");
                    indexToEntry[displayIndex] = (s, kvp.Key);
                    displayIndex++;
                }

                Console.WriteLine();
            }

            Console.Write($"Choose a spell to view (1-{displayIndex - 1}), or press Enter to stop: ");
            var pickInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(pickInput))
                break;

            if (!int.TryParse(pickInput, out var pick) || !indexToEntry.ContainsKey(pick))
            {
                Console.WriteLine("Invalid selection. Try again.");
                continue;
            }

            var (selectedSpell, selectedCN) = indexToEntry[pick];

            // Show full details (preview)
            Console.WriteLine($"\n--- {selectedSpell.SpellName} ---");
            Console.WriteLine($"Casting Number: {selectedSpell.CastingNumber}");
            Console.WriteLine($"Type: {string.Join(", ", selectedSpell.SpellTypes)}");
            if (selectedSpell.Lore != null && selectedSpell.Lore.Any())
                Console.WriteLine($"Lore: {string.Join(", ", selectedSpell.Lore)}");
            if (!string.IsNullOrWhiteSpace(selectedSpell.Flavor))
                Console.WriteLine($"Flavor: {selectedSpell.Flavor}");
            Console.WriteLine($"Rules: {selectedSpell.Rules}");
            Console.WriteLine($"Target: {selectedSpell.SpellTarget}");
            Console.WriteLine($"Duration: {selectedSpell.Duration}");
            Console.WriteLine();

            Console.Write("Add this spell? (y = add, any other key = back to list): ");
            var confirm = Console.ReadLine();
            if (!string.Equals(confirm, "y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Not added. Returning to spell list.");
                continue;
            }

            // Add spell to character
            character.Spells.Add(selectedSpell);
            knownSpellNames.Add(selectedSpell.SpellName);
            spellsChosen++;

            // Deduct points
            if (!int.TryParse(selectedSpell.CastingNumber, out var cnCost))
            {
                Console.WriteLine($"Error parsing casting number for {selectedSpell.SpellName}. Aborting selection.");
                break;
            }

            remainingPoints -= cnCost;
            if (remainingPoints < 0) remainingPoints = 0;

            // Try to remove dice that sum to the cost (keeps dice list roughly accurate for display)
            var removed = DiceRoller.RemoveDiceForCastingNumber(rolledDice, cnCost);
            if (!removed)
            {
                // Fallback: remove largest dice until rolledDice.Sum() <= remainingPoints
                while (rolledDice.Count > 0 && rolledDice.Sum() > remainingPoints)
                {
                    var largest = rolledDice.Max();
                    rolledDice.Remove(largest);
                }
            }

            Console.WriteLine($"Added: {selectedSpell.SpellName} (CN {selectedSpell.CastingNumber}).");
            Console.WriteLine($"Remaining casting number points: {remainingPoints} (dice: {string.Join(", ", rolledDice)})");
        }

        Console.WriteLine("\nSpell selection complete.");
    }


}