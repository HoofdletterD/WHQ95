using WHQCore.Models;

namespace WHQCore.Helpers;

public static class HeroDisplayer
{
    public static void Display(IHero hero)
    {
        var character = hero.Character;

        Console.WriteLine("Your Hero:");
        Console.WriteLine($"Name: {character.Name}");
        Console.WriteLine($"Type: {character.HeroType}");
        Console.WriteLine($"Battle Level: {character.BattleLevel}");
        Console.WriteLine($"Title: {character.Title}");
        Console.WriteLine($"Gold: {character.Gold}");
        Console.WriteLine();

        if (character.StartingWoundsRoll is { } roll)
        {
            Console.WriteLine($"Starting Wounds: {character.StartingWounds} (rolled {roll.FirstRoll}" +
                              (roll.Reroll.HasValue ? $" → rerolled to {roll.Reroll}" : "") + ")");
        }
        else
        {
            Console.WriteLine($"Starting Wounds: {character.StartingWounds}");
        }

        Console.WriteLine($"Movement: {character.Movement}");
        Console.WriteLine($"Weapon Skill: {character.WeaponSkill}");
        Console.WriteLine($"Ballistic Skill: {character.BallisticSkill}");
        Console.WriteLine($"Strength: {character.Strength}" +
                          (character.TotalStrength > character.Strength ? $" ({character.TotalStrength})" : ""));
        Console.WriteLine($"Damage Dice: {character.DamageDice}");
        Console.WriteLine($"Toughness: {character.Toughness}" +
                          (character.TotalToughness > character.Toughness ? $" ({character.TotalToughness})" : ""));
        Console.WriteLine($"Initiative: {character.Initiative}");
        Console.WriteLine($"Attacks: {character.Attacks}" +
                          (character.TotalAttacks > character.Attacks ? $" ({character.TotalAttacks})" : ""));
        Console.WriteLine($"Luck: {character.Luck}");
        Console.WriteLine($"Willpower: {character.Willpower}");
        Console.WriteLine($"Escape Pinning: {character.EscapePinning}");
        Console.WriteLine();

        PrintListIfNotEmpty("Equipment", character.Equipment);
        PrintListIfNotEmpty("Special Rules", character.SpecialRules);
        PrintListIfNotEmpty("Magic Items", character.MagicItems);


        if (character.Skills is not { Count: > 0 }) return;
        Console.WriteLine("Skills:");
        foreach (var skill in character.Skills)
        {
            Console.WriteLine(skill.DisplayFullSkill());
            Console.WriteLine();
        }
    }

    private static void PrintListIfNotEmpty(string title, IEnumerable<object>? items)
    {
        if (items == null) return;

        var list = items.Select(i => i?.ToString()).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
        if (!list.Any()) return;

        Console.WriteLine(title + ":");
        foreach (var item in list)
            Console.WriteLine($"- {item}");
        Console.WriteLine();
    }

}
