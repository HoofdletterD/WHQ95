using System;
using System.Linq;
using WHQCore.Helpers;
using WHQCore.HeroManagement;
using WHQCore.Libraries;
using WHQCore.Libraries.MagicItems;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Services
{
    public static class DungeonPhaseService
    {
        public static void DungeonPhase(IHero heroBase)
        {
            var hero = heroBase.Character;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"--- Dungeon Phase for {hero.Name} ---");
                Console.WriteLine("1. Adjust Gold (simulate monster loot)");
                Console.WriteLine("2. Adjust Wounds (damage/healing)");
                Console.WriteLine("3. Roll Dungeon Treasure (Rulebook D6 table)");
                Console.WriteLine("4. Roll on Objective Room D66 Table");
                Console.WriteLine("5. Search for / Add a Treasure Card manually");
                Console.WriteLine("6. Manage Inventory");
                Console.WriteLine("7. Show Hero Stats");
                Console.WriteLine("8. Return to Hero Options");
                Console.Write("\nEnter your choice: ");
                var input = Console.ReadLine()?.Trim();

                switch (input)
                {
                    case "1":
                        AdjustGold(heroBase);
                        HeroSaveManager.SaveHero(heroBase);
                        break;

                    case "2":
                        AdjustWounds(heroBase);
                        break;

                    case "3":
                        Console.WriteLine("\nResolving Dungeon Treasure...");
                        DungeonRewardService.AwardDungeonTreasure(heroBase);
                        HeroSaveManager.SaveHero(heroBase);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("\nRolling on the Objective Room D66 table...");
                        DungeonRewardService.AwardFromD66Table(heroBase, TreasureType.ObjectiveRoomTreasure);
                        HeroSaveManager.SaveHero(heroBase);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "5":
                        AddTreasureManually(heroBase);
                        break;

                    case "6":
                        HeroInventoryService.ManageInventoryMenu(heroBase);
                        HeroSaveManager.SaveHero(heroBase);
                        break;

                    case "7":
                        Console.Clear();
                        HeroDisplayer.DisplayHeroAllInformation(heroBase);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "8":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }

        }

        private static void AdjustGold(IHero heroBase)
        {
            var hero = heroBase.Character;

            Console.Write("Enter gold adjustment (positive to add, negative to subtract): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var goldChange))
            {
                hero.Gold += goldChange;
                Console.WriteLine($"\nGold updated. {hero.Name} now has {hero.Gold} gold.");
            }
            else
            {
                Console.WriteLine("\nInvalid number entered.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void AdjustWounds(IHero heroBase)
        {
            var hero = heroBase.Character;

            Console.WriteLine($"\n{hero.Name} currently has {hero.CurrentWounds}/{hero.StartingWounds} wounds.");
            Console.Write("Enter wound adjustment (positive to heal, negative to damage): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var woundChange))
            {
                hero.CurrentWounds += woundChange;

                // Clamp between 0 and max wounds
                if (hero.CurrentWounds > hero.StartingWounds)
                    hero.CurrentWounds = hero.StartingWounds;
                if (hero.CurrentWounds < 0)
                    hero.CurrentWounds = 0;

                Console.WriteLine($"\nWounds updated. {hero.Name} now has {hero.CurrentWounds}/{hero.StartingWounds} wounds.");
            }
            else
            {
                Console.WriteLine("\nInvalid number entered.");
            }

            HeroSaveManager.SaveHero(heroBase);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void AddTreasureManually(IHero heroBase)
        {
            var hero = heroBase.Character;

            Console.WriteLine("\nSearch for a treasure to add:");
            Console.Write("Enter item name (or part of it): ");
            var searchTerm = Console.ReadLine()?.Trim();

            var allItems = TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicItemLibrary))
                            .Concat(TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicWeaponsAndArmorLibrary)))
                            .Concat(TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(ObjectiveRoomTreasureLibrary)))
                            .Where(i => i.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                            .ToList();

            if (allItems.Count == 0)
            {
                Console.WriteLine("No items found matching your search.");
            }
            else
            {
                for (int i = 0; i < allItems.Count; i++)
                    Console.WriteLine($"{i + 1}. {allItems[i].Name}");

                Console.Write("\nSelect an item to view details (number): ");
                var selInput = Console.ReadLine();
                if (int.TryParse(selInput, out int selIndex) && selIndex >= 1 && selIndex <= allItems.Count)
                {
                    var selectedItem = allItems[selIndex - 1];

                    // Show full details
                    Console.WriteLine("\n--- Item Details ---");
                    Console.WriteLine($"Name: {selectedItem.Name}");
                    Console.WriteLine($"{selectedItem.Flavor}");
                    Console.WriteLine($"Rules: {selectedItem.Rules}");
                    Console.WriteLine($"Applicable Warriors: {string.Join(", ", selectedItem.Warriors)}");
                    Console.WriteLine($"Cost (Sell): {selectedItem.CostSell}");
                    if (selectedItem.StatModifiers.Any())
                        Console.WriteLine($"Stat Modifiers: {string.Join(", ", selectedItem.StatModifiers.Select(kv => $"{kv.Key} +{kv.Value}"))}");
                    Console.WriteLine("--------------------");

                    Console.Write("\nDo you want to add this item to your hero? (y/n): ");
                    var confirm = Console.ReadLine()?.Trim().ToLower();
                    if (confirm == "y")
                    {
                        hero.MagicItems.Add(selectedItem);
                        Console.WriteLine($"{selectedItem.Name} added to {hero.Name}.");
                        HeroSaveManager.SaveHero(heroBase);
                    }
                    else
                    {
                        Console.WriteLine("Item not added.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
