using WHQCore.Helpers;
using WHQCore.Heroes;
using WHQCore.HeroManagement;
using WHQCore.Models.Enums;

namespace WHQCore.Services;

public static class HeroCreationService
{
    public static HeroBase CreateHeroInteractive()
    {
        Console.WriteLine("Choose hero creation mode:");
        Console.WriteLine("1. Classic Mode (choose from full list)");
        Console.WriteLine("2. Immersive Mode (choose race, then class)");
        var modeChoice = Console.ReadLine();

        return modeChoice switch
        {
            "2" => CreateHeroImmersive(),
            _ => CreateHeroClassic()
        };
    }

    private static HeroBase CreateHeroClassic()
    {
        Console.WriteLine("Choose your hero:");

        for (int i = 0; i < HeroRegistry.Heroes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {HeroRegistry.Heroes[i].DisplayName}");
        }

        if (!int.TryParse(Console.ReadLine(), out int heroChoice) ||
            heroChoice < 1 || heroChoice > HeroRegistry.Heroes.Count)
        {
            Console.WriteLine("Invalid choice, please try again.");
            return CreateHeroClassic();
        }

        var chosenHeroEntry = HeroRegistry.Heroes[heroChoice - 1];
        return CreateHeroFromEntry(chosenHeroEntry);
    }

    private static HeroBase CreateHeroImmersive()
    {
        // Step 1: Choose race
        var races = HeroRegistry.Heroes.Select(h => h.Race).Distinct().ToList();
        Console.WriteLine("Choose your race:");

        for (int i = 0; i < races.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {races[i]}");
        }

        if (!int.TryParse(Console.ReadLine(), out int raceChoice) ||
            raceChoice < 1 || raceChoice > races.Count)
        {
            Console.WriteLine("Invalid choice, please try again.");
            return CreateHeroImmersive();
        }

        var chosenRace = races[raceChoice - 1];

        // Step 2: Choose class filtered by race
        var raceHeroes = HeroRegistry.Heroes.Where(h => h.Race == chosenRace).ToList();
        Console.WriteLine($"Choose your {chosenRace} class:");

        for (int i = 0; i < raceHeroes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {raceHeroes[i].DisplayName}: {raceHeroes[i].Playstyle}");
        }

        if (!int.TryParse(Console.ReadLine(), out int classChoice) ||
            classChoice < 1 || classChoice > raceHeroes.Count)
        {
            Console.WriteLine("Invalid choice, please try again.");
            return CreateHeroImmersive();
        }

        var chosenHeroEntry = raceHeroes[classChoice - 1];
        return CreateHeroFromEntry(chosenHeroEntry);
    }

    private static HeroBase CreateHeroFromEntry(HeroEntry chosenHeroEntry)
    {
        Console.WriteLine("Enter your hero's name:");
        var heroName = Console.ReadLine() ?? "Unnamed Hero";

        try
        {
            var hero = chosenHeroEntry.CreateBase(heroName);

            if (hero == null)
            {
                Console.WriteLine($"⚠️ The hero '{chosenHeroEntry.DisplayName}' is not yet available. Please pick another.");
                return CreateHeroInteractive();
            }

            // Optional bio
            Console.WriteLine("Enter a bio for your hero (or leave empty):");
            var bio = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(bio))
                hero.Character.Bio = bio;

            // --- Trait selection by category ---
            var selectedTraits = new List<HeroTrait>();

            foreach (var category in new[] { TraitCategory.Positive, TraitCategory.Neutral, TraitCategory.Negative })
            {
                var traits = HeroTraitHelper.GetTraitsByCategory(category).ToList();

                Console.WriteLine($"Choose one {category} trait:");
                for (int i = 0; i < traits.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {traits[i]}");
                }

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > traits.Count)
                {
                    Console.WriteLine("Invalid choice, try again.");
                }

                selectedTraits.Add(traits[choice - 1]);
            }

            hero.Character.Traits = selectedTraits;

            return hero;
        }
        catch (NotImplementedException)
        {
            Console.WriteLine($"⚠️ The hero '{chosenHeroEntry.DisplayName}' is not yet implemented. Please pick another.");
            return CreateHeroInteractive();
        }
    }


}
