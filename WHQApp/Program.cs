using WHQApp.Helpers;
using WHQApp.HeroManagement;
using WHQApp.Models;

namespace WHQApp;

internal class Program
{
    private static void Main()
    {

        try
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        }
        catch (IOException)
        {
            Console.WriteLine("Warning: Could not resize console window. Proceeding with default size...");
        }
        catch (PlatformNotSupportedException)
        {
            Console.WriteLine("Warning: Resizing console not supported on this platform.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Warning: Console size requested is out of range.");
        }

        while (true)
        {

            Console.Clear();
            Console.WriteLine("Welcome to Warhammer Quest Hero Creator!");
            Console.WriteLine("Choose your hero type:");
            for (var i = 0; i < HeroRegistry.Heroes.Count; i++)
                Console.WriteLine($"{i + 1}. {HeroRegistry.Heroes[i].DisplayName}");

            Console.WriteLine("X = Exit");
            Console.Write("Enter your choice (number): ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

            if (input.Trim().Equals("X", StringComparison.OrdinalIgnoreCase))
                break;

            if (!int.TryParse(input, out var choice) || choice < 1 || choice > HeroRegistry.Heroes.Count)
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

            // Create the hero instance using the selected factory method
            var heroBase = HeroRegistry.Heroes[choice - 1].CreateBase(name);
            var hero = heroBase.Character;

            // After hero creation
            Console.Clear();  // clear before initial display
            HeroDisplayer.Display(heroBase);

            // Ask to level up
            if (hero.BattleLevel >= 10)
            {
                Console.WriteLine("Maximum Battle Level reached.");
                Console.WriteLine("Press X to return to the main menu...");

                while (true)
                {
                    var xKey = Console.ReadKey(true);
                    if (xKey.Key == ConsoleKey.X)
                        break;
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

                        Console.WriteLine("Press any key to see updated stats...");
                        Console.ReadKey();

                        Console.Clear();
                        HeroDisplayer.Display(heroBase);

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



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to create another hero or Esc to exit.");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
                break;
        }
    }
}