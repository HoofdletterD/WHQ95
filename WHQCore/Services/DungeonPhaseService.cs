using System;
using WHQCore.Helpers;
using WHQCore.HeroManagement;
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
                Console.WriteLine("2. Roll Dungeon Treasure (Rulebook D6 table)");
                Console.WriteLine("3. Roll on Objective Room D66 Table");
                Console.WriteLine("4. Show Hero Stats");
                Console.WriteLine("5. Return to Hero Options");

                Console.Write("\nEnter your choice: ");
                var input = Console.ReadLine()?.Trim();

                switch (input)
                {
                    case "1":
                        AdjustGold(heroBase);
                        HeroSaveManager.SaveHero(heroBase);
                        break;

                    case "2":
                        Console.WriteLine("\nResolving Dungeon Treasure...");
                        DungeonRewardService.AwardDungeonTreasure(heroBase);
                        HeroSaveManager.SaveHero(heroBase);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("\nRolling on the Objective Room D66 table...");
                        DungeonRewardService.AwardFromD66Table(heroBase, TreasureType.ObjectiveRoomTreasure);
                        HeroSaveManager.SaveHero(heroBase);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        HeroDisplayer.DisplayHeroAllInformation(heroBase);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "5":
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
    }
}
