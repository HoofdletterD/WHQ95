using WHQCore.Helpers;
using WHQCore.Models;
using WHQCreator.HeroManagement;

namespace WHQCreator;

internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Warhammer Quest Hero Creator!");
            Console.WriteLine("N = Create a new hero");
            Console.WriteLine("L = Load an existing hero");
            Console.WriteLine("X = Exit");
            Console.Write("Enter your choice: ");

            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (input.Trim().Equals("X", StringComparison.OrdinalIgnoreCase))
                break;

            IHero heroBase = null;

            if (input.Trim().Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                // New hero creation
                Console.WriteLine("Choose your hero type:");
                for (var i = 0; i < HeroRegistry.Heroes.Count; i++)
                    Console.WriteLine($"{i + 1}. {HeroRegistry.Heroes[i].DisplayName}");

                Console.Write("Enter your choice (number): ");
                var typeInput = Console.ReadLine();

                if (!int.TryParse(typeInput, out var choice) || choice < 1 || choice > HeroRegistry.Heroes.Count)
                {
                    Console.WriteLine("Invalid selection. Press any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("\nEnter your hero's name: ");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Hero name cannot be empty. Press any key to try again...");
                    Console.ReadKey();
                    continue;
                }

                heroBase = HeroRegistry.Heroes[choice - 1].CreateBase(name);
                Console.WriteLine($"New hero '{name}' created!");
            }
            else if (input.Trim().Equals("L", StringComparison.OrdinalIgnoreCase))
            {
                // Load existing hero
                heroBase = HeroLoader.LoadFromSavesFolder();
                if (heroBase == null)
                {
                    Console.WriteLine("Failed to load hero or none available.");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine($"Hero '{heroBase.Character.Name}' loaded successfully!");
            }
            else
            {
                Console.WriteLine("Invalid menu choice.");
                continue;
            }

            // Gameplay loop
            var hero = heroBase.Character;
            Console.Clear();
            HeroDisplayer.DisplayHeroAllInformation(heroBase);
            HeroSaveManager.SaveHero(heroBase);

            if (hero.BattleLevel >= 10)
            {
                Console.WriteLine("Maximum Battle Level reached.");
                Console.WriteLine("Press X to return to the main menu...");
                while (true)
                {
                    var xKey = Console.ReadKey(true);
                    if (xKey.Key == ConsoleKey.X) break;
                }
            }
            else
            {
                Console.Write("Would you like to level up your hero? (Y/N): ");
                var levelInput = Console.ReadLine();
                if (levelInput?.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase) == true)
                {
                    while (true)
                    {
                        heroBase.LevelUp();
                        HeroSaveManager.SaveHero(heroBase);

                        Console.WriteLine("Press any key to see updated stats...");
                        Console.ReadKey();

                        Console.Clear();
                        HeroDisplayer.DisplayHeroAllInformation(heroBase);

                        if (hero.BattleLevel >= 10)
                        {
                            Console.WriteLine("Your hero has reached the maximum level!");
                            break;
                        }

                        if (!Hero.GoldCostPerLevel.TryGetValue(hero.BattleLevel + 1, out var nextCost) || hero.Gold < nextCost)
                        {
                            Console.WriteLine("Not enough gold to level up again.");
                            break;
                        }

                        Console.Write("Would you like to level up again? (Y/N): ");
                        var again = Console.ReadLine();
                        if (!again?.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase) == true)
                            break;
                    }
                }
            }

            HeroSaveManager.SaveHero(heroBase);
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
    }

}
