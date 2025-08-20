using WHQCore.Helpers;
using WHQCore.Libraries.MagicItems.RolePlayBookTables;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Services
{
    public static class DungeonRewardService
    {
        private static readonly Random _rng = new();

        /// <summary>
        /// Rulebook D6 flow when a Treasure card would be drawn in the dungeon:
        /// 1 = Gold (mini-game)
        /// 2-3 = Take a Treasure card (placeholder here)
        /// 4-5 = Weapons & Armour sub-table (D66)
        /// 6 = Magic Items sub-table (D66)
        /// </summary>
        public static void AwardDungeonTreasure(IHero hero)
        {
            Console.WriteLine("\n--- Dungeon Treasure Roll (D6) ---");
            var d6 = DiceRoller.RollD6();
            Console.WriteLine($"You rolled: {d6}");

            switch (d6)
            {
                case 1:
                    Console.WriteLine("Result 1 — Gold!");
                    AwardGoldMiniGame(hero);
                    break;

                case 2:
                case 3:
                    Console.WriteLine("Result 2–3 — Take a Treasure card as normal.");
                    AwardTreasureCardPlaceholder(hero);
                    break;

                case 4:
                case 5:
                    Console.WriteLine("Result 4–5 — Roll on the Weapons & Armour sub-table (D66).");
                    AwardFromD66Table(hero, TreasureType.DungeonTreasureMagicWeaponsAndArmor);
                    break;

                case 6:
                    Console.WriteLine("Result 6 — Roll on the Magic Items sub-table (D66).");
                    AwardFromD66Table(hero, TreasureType.DungeonTreasureMagicItems);
                    break;
            }
        }

        /// <summary>
        /// Draws a random treasure item from a specific library for the given TreasureType.
        /// (Kept for direct-roll utilities and any other callers you may already have.)
        /// </summary>
        public static void AwardRandomTreasure(IHero hero, TreasureType treasureType)
        {
            Type libraryType = treasureType switch
            {
                TreasureType.DungeonTreasureMagicItems => typeof(MagicItemLibrary),
                TreasureType.DungeonTreasureMagicWeaponsAndArmor => typeof(MagicWeaponsAndArmorLibrary),
                TreasureType.ObjectiveRoomTreasure => typeof(ObjectiveRoomTreasureLibrary),
                _ => throw new ArgumentOutOfRangeException()
            };

            var items = TreasureLibraryHelper.GetAllItemsFromLibrary(libraryType)
                                             .Where(i => i.TreasureType.Contains(treasureType))
                                             .ToList();

            if (items.Count == 0)
            {
                Console.WriteLine($"No items found for treasure type: {treasureType}");
                return;
            }

            var item = items[_rng.Next(items.Count)];
            hero.Character.MagicItems.Add(item);
            Console.WriteLine($"You found a treasure: {item.Name}");
            ShowItemDetails(item);  // <-- Show details immediately
        }

        /// <summary>
        /// Rolls D66 and selects from the requested D66 table/library.
        /// Falls back to random from matching items if that exact D66 entry is not present.
        /// </summary>
        public static void AwardFromD66Table(IHero hero, TreasureType tableType)
        {
            var rawRoll = DiceRoller.RollD66();
            var d66 = rawRoll.ToString();

            MagicItemData? item = tableType switch
            {
                TreasureType.DungeonTreasureMagicWeaponsAndArmor =>
                    TreasureLibraryHelper.GetByD66(typeof(MagicWeaponsAndArmorLibrary), d66),

                TreasureType.DungeonTreasureMagicItems =>
                    TreasureLibraryHelper.GetByD66(typeof(MagicItemLibrary), d66),

                TreasureType.ObjectiveRoomTreasure =>
                    TreasureLibraryHelper.GetByD66(typeof(ObjectiveRoomTreasureLibrary), d66),

                _ => null
            };

            if (item == null)
            {
                Console.WriteLine($"No exact D66 entry '{d66}' found in {tableType}. Choosing a random matching item...");
                Type fallbackLib = tableType switch
                {
                    TreasureType.DungeonTreasureMagicWeaponsAndArmor => typeof(MagicWeaponsAndArmorLibrary),
                    TreasureType.DungeonTreasureMagicItems => typeof(MagicItemLibrary),
                    TreasureType.ObjectiveRoomTreasure => typeof(ObjectiveRoomTreasureLibrary),
                    _ => null!
                };

                if (fallbackLib != null)
                {
                    var candidates = TreasureLibraryHelper
                        .GetAllItemsFromLibrary(fallbackLib)
                        .Where(i => i.TreasureType.Contains(tableType))
                        .ToList();

                    if (candidates.Count > 0)
                        item = candidates[_rng.Next(candidates.Count)];
                }
            }

            if (item != null)
            {
                hero.Character.MagicItems.Add(item);
                Console.WriteLine($"You found: {item.Name} (D66: {d66})");
                ShowItemDetails(item);  // <-- Show details immediately
            }
            else
            {
                Console.WriteLine($"No items available for table: {tableType} (D66: {d66})");
            }
        }

        // Placeholder so you compile cleanly until you implement your Treasure Card deck.
        private static void AwardTreasureCardPlaceholder(IHero hero)
        {
            Console.WriteLine("Treasure Card deck is not implemented yet. (No card awarded.)");
            // Hook here later, e.g.: TreasureCardService.Draw(hero);
        }


        /// <summary>
        /// Awards gold based on the Dungeon Treasure Gold mini-game.
        /// </summary>
        /// <param name="hero">The hero receiving gold.</param>
        public static void AwardGoldMiniGame(IHero hero)
        {
            Console.WriteLine($"{hero.Character.Name}, how many dice would you like to roll? (Enter a number > 0)");

            int diceCount;
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out diceCount) && diceCount > 0)
                    break;

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            var rolls = new List<int>();
            bool rolledOne = false;

            for (int i = 0; i < diceCount; i++)
            {
                int roll = _rng.Next(1, 7);
                rolls.Add(roll);
                if (roll == 1)
                    rolledOne = true;
            }

            Console.WriteLine($"You rolled: {string.Join(", ", rolls)}");

            if (rolledOne)
            {
                Console.WriteLine($"{hero.Character.Name} rolled a 1! No gold found.");
                return;
            }

            int total = rolls.Sum() * 10;
            hero.Character.Gold += total;

            Console.WriteLine($"{hero.Character.Name} finds {total} gold! (Total gold: {hero.Character.Gold})");
        }

        private static void ShowItemDetails(MagicItemData item)
        {
            Console.WriteLine("\n--- Item Details ---");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"{item.Flavor}");
            Console.WriteLine($"Rules: {item.Rules}");
            Console.WriteLine($"Applicable Warriors: {string.Join(", ", item.Warriors)}");
            Console.WriteLine($"Cost (Sell): {item.CostSell}");
            if (item.StatModifiers.Any())
                Console.WriteLine($"Stat Modifiers: {string.Join(", ", item.StatModifiers.Select(kv => $"{kv.Key} +{kv.Value}"))}");
            Console.WriteLine("--------------------");
        }
    }
}