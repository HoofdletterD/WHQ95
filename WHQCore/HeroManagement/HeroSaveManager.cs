using System.Text.Json;
using WHQCore.Models;

namespace WHQCore.HeroManagement;

public static class HeroSaveManager
{
    private static readonly string SaveFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Saves");

    public static void SaveHero(IHero hero)
    {
        if (!Directory.Exists(SaveFolder))
            Directory.CreateDirectory(SaveFolder);

        var data = HeroSaveMapper.ToSaveData(hero);
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });

        var filePath = Path.Combine(SaveFolder, $"{hero.Character.Name}.json");
        File.WriteAllText(filePath, json);

        Console.WriteLine($"Hero saved to {filePath}");
    }

    public static IHero LoadHero(string heroName)
    {
        var filePath = Path.Combine(SaveFolder, $"{heroName}.json");
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Save file not found.");
            return null;
        }

        var json = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<HeroSaveData>(json);

        return HeroSaveMapper.FromSaveData(data);
    }
}