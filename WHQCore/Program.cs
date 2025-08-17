using WHQCore.Helpers;
using WHQCore.HeroManagement;
using WHQCore.Models;
using WHQCore.Services;

namespace WHQCore;

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

            var input = Console.ReadLine()?.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (input == "X")
                break;

            IHero heroBase = null;

            if (input == "N")
            {
                heroBase = HeroCreationService.CreateHeroInteractive();
            }
            else if (input == "L")
            {
                heroBase = LoadExistingHero();
            }
            else
            {
                Console.WriteLine("Invalid menu choice. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

            if (heroBase == null)
                continue;

            HeroSaveManager.SaveHero(heroBase);

            HeroMainLoop(heroBase);
        }
    }

    private static IHero LoadExistingHero()
    {
        var heroBase = HeroLoader.LoadFromSavesFolder();
        if (heroBase == null)
        {
            Console.WriteLine("Failed to load hero or none available.");
            Console.ReadKey();
            return null;
        }

        Console.WriteLine($"Hero '{heroBase.Character.Name}' loaded successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        return heroBase;
    }

    private static void HeroMainLoop(IHero heroBase)
    {
        var hero = heroBase.Character;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\n--- Hero Options for {hero.Name} ---");
            Console.WriteLine("1. Go to Dungeon (adjust gold / find treasures)");
            Console.WriteLine("2. Go to Town (buy/sell, level up, special locations)");
            Console.WriteLine("3. Show Hero Stats");
            Console.WriteLine("4. Return to Main Menu");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DungeonPhase(heroBase); // placeholder for dungeon logic
                    break;

                case "2":
                    TownPhaseService.RunTownPhase(heroBase);
                    break;

                case "3":
                    Console.Clear();
                    HeroDisplayer.DisplayHeroAllInformation(heroBase);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "4":
                    return; // Back to main menu

                default:
                    Console.WriteLine("Invalid choice. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private static void DungeonPhase(IHero heroBase)
    {
        DungeonPhaseService.DungeonPhase(heroBase);
    }
}
