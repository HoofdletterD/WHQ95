using WHQCore.Helpers;
using WHQCore.Libraries;
using WHQCore.Libraries.MagicItems;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Services
{
    public static class DungeonRewardService
    {
        public static void AwardRandomTreasure(IHero hero, TreasureType treasureType)
        {
            var items = treasureType switch
            {
                TreasureType.DungeonTreasureMagicItems =>
                    TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicItemLibrary))
                        .Where(i => i.TreasureType.Contains(TreasureType.DungeonTreasureMagicItems)),

                TreasureType.DungeonTreasureMagicWeaponsAndArmor =>
                    TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicWeaponsAndArmorLibrary))
                        .Where(i => i.TreasureType.Contains(TreasureType.DungeonTreasureMagicWeaponsAndArmor)),

                TreasureType.ObjectiveRoomTreasure =>
                    TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(ObjectiveRoomTreasureLibrary))
                        .Where(i => i.TreasureType.Contains(TreasureType.ObjectiveRoomTreasure)),

                _ => Enumerable.Empty<MagicItemData>()
            };

            var item = items.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
            if (item != null)
            {
                hero.Character.MagicItems.Add(item);
                Console.WriteLine($"You found a treasure: {item.Name}");
            }
            else
            {
                Console.WriteLine($"No items found for treasure type: {treasureType}");
            }
        }

        public static void AwardFromD66Table(IHero hero, TreasureType tableType)
        {
            var result = DiceRoller.RollD66();

            var item = tableType switch
            {
                TreasureType.DungeonTreasureMagicWeaponsAndArmor =>
                    TreasureLibraryHelper.GetByD66(typeof(MagicWeaponsAndArmorLibrary), result),

                TreasureType.DungeonTreasureMagicItems =>
                    TreasureLibraryHelper.GetByD66(typeof(MagicItemLibrary), result),

                TreasureType.ObjectiveRoomTreasure =>
                    TreasureLibraryHelper.GetByD66(typeof(ObjectiveRoomTreasureLibrary), result),

                _ => null
            };

            if (item != null)
            {
                hero.Character.MagicItems.Add(item);
                Console.WriteLine($"You found: {item.Name} (D66: {result})");
            }
            else
            {
                Console.WriteLine($"No item found in {tableType} table for D66 roll {result}");
            }
        }
    }

    public static class GoldRewardService
    {
        /// <summary>
        /// Runs the gold mini-game: 
        /// Roll as many D6 as you like, total ×10 = gold.
        /// But if any die is 1, hero gains nothing.
        /// </summary>
        public static void AwardGoldMiniGame(IHero hero)
        {
            Console.WriteLine("\n--- Gold Reward Mini-Game ---");
            Console.WriteLine("You may roll as many D6 as you like.");
            Console.WriteLine("⚠ If ANY die rolls a 1, you find nothing!");

            int total = 0;
            bool rolledOne = false;

            while (true)
            {
                Console.Write("Roll another D6? (Y/N): ");
                var input = Console.ReadLine()?.Trim().ToUpper();

                if (input != "Y") break;

                int roll = DiceRoller.RollD6();
                Console.WriteLine($"You rolled: {roll}");

                if (roll == 1)
                {
                    rolledOne = true;
                    break;
                }

                total += roll;
            }

            if (rolledOne)
            {
                Console.WriteLine("Bad luck! A roll of 1 means you found nothing.");
            }
            else if (total > 0)
            {
                int goldFound = total * 10;
                hero.Character.Gold += goldFound;
                Console.WriteLine($"You found {goldFound} gold! Total gold: {hero.Character.Gold}");
            }
            else
            {
                Console.WriteLine("You decided not to roll any dice.");
            }
        }
    }
}
