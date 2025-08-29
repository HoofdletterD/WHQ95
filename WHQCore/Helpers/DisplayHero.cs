using WHQCore.Models;

namespace WHQCore.Helpers;

public static class HeroDisplayer
{
    public static void DisplayHeroCharacterInformation(IHero hero)
    {
        var character = hero.Character;

        Console.WriteLine("Your Hero:");
        Console.WriteLine($"Name: {character.Name}");
        Console.WriteLine($"Type: {character.HeroType}");
        Console.WriteLine($"Battle Level: {character.BattleLevel}");
        Console.WriteLine($"Title: {character.Title}");
        Console.WriteLine($"Gold: {character.Gold}");
        Console.WriteLine();
        if (!string.IsNullOrWhiteSpace(character.Bio))
            Console.WriteLine($"Bio: {character.Bio}");
        Console.WriteLine();
        if (character.Traits.Count > 0)
            Console.WriteLine($"Traits: {string.Join(", ", character.Traits)}");
        Console.WriteLine();
    }

    public static void DisplayHeroStatistics(IHero hero)
    {
        var character = hero.Character;

        if (character.StartingWoundsRoll is { } roll)
        {
            Console.WriteLine($"Starting Wounds: {character.StartingWounds} (rolled {roll.FirstRoll}" +
                              (roll.Reroll.HasValue ? $" → rerolled to {roll.Reroll}" : "") + ")");
        }
        else
        {
            Console.WriteLine($"Starting Wounds: {character.StartingWounds}");
        }

        Console.WriteLine($"Current Wounds: {character.CurrentWounds}");

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
    }

    public static void DisplayHeroSkills(IHero hero)
    {
        var character = hero.Character;
        if (character.Skills is not { Count: > 0 }) return;
        Console.WriteLine("Skills:");
        foreach (var skill in character.Skills)
        {
            Console.WriteLine(skill.DisplayFullSkill());
            Console.WriteLine();
        }
    }

    public static void DisplayHeroSpells(IHero hero)
    {
        var character = hero.Character;

        if (character.Spells is not { Count: > 0 }) return;

        Console.WriteLine("Spells:");
        foreach (var spell in character.Spells)
        {
            Console.WriteLine($"- {spell.SpellName} (Casting: {spell.CastingNumber})");
            Console.WriteLine($"  Type: {string.Join(", ", spell.SpellTypes)}");
            Console.WriteLine($"  Rules: {spell.Rules}");
            Console.WriteLine($"  Target: {spell.SpellTarget}");
            Console.WriteLine($"  Duration: {spell.Duration}");
            Console.WriteLine();
        }
    }

    public static void DisplayHeroEquipment(IHero hero)
    {
        var character = hero.Character;
        PrintListIfNotEmpty("Equipment", character.Equipment);
    }

    public static void DisplayHeroMagicItems(IHero hero)
    {
        var character = hero.Character;
        PrintListIfNotEmpty("Magic Items", character.MagicItems);
    }
    
    public static void DisplayHeroSpecialRules(IHero hero)
    {
        var character = hero.Character;
        PrintListIfNotEmpty("Special Rules", character.SpecialRules);
    }

    public static void DisplayHeroAllInformation(IHero hero)
    {
        DisplayHeroCharacterInformation(hero);
        DisplayHeroStatistics(hero);
        DisplayHeroSkills(hero);
        DisplayHeroSpells(hero);
        DisplayHeroEquipment(hero);
        DisplayHeroMagicItems(hero);
        DisplayHeroSpecialRules(hero);
    }

    private static void PrintListIfNotEmpty(string title, IEnumerable<object>? items)
    {
        if (items == null) return;

        var list = items.Select(i => i?.ToString()).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
        if (list.Count == 0) return;

        Console.WriteLine(title + ":");
        foreach (var item in list)
            Console.WriteLine($"- {item}");
        Console.WriteLine();
    }
}