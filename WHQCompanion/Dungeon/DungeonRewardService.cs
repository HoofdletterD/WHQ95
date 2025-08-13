using System;
using System.Linq;
using WHQCore.Helpers;
using WHQCore.Logic;
using WHQCore.MagicItems;
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
}
