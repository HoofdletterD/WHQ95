using WHQCore.Models;

namespace WHQCreator.HeroManagement
{
    public static class HeroLoader
    {
        public static IHero LoadFromSavesFolder()
        {
            var saveFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");
            if (!Directory.Exists(saveFolder))
            {
                Console.WriteLine("No saves folder found. No characters to load.");
                return null;
            }

            var saveFiles = Directory.GetFiles(saveFolder, "*.json")
                .Select(Path.GetFileNameWithoutExtension)
                .ToList();

            if (saveFiles.Count == 0)
            {
                Console.WriteLine("No saved heroes found.");
                return null;
            }

            Console.WriteLine("\nSaved Heroes:");
            for (int i = 0; i < saveFiles.Count; i++)
                Console.WriteLine($"{i + 1}. {saveFiles[i]}");

            Console.Write($"Choose a hero to load (1-{saveFiles.Count}): ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var choice) || choice < 1 || choice > saveFiles.Count)
            {
                Console.WriteLine("Invalid selection.");
                return null;
            }

            var selectedName = saveFiles[choice - 1];
            return HeroSaveManager.LoadHero(selectedName);
        }
    }
}