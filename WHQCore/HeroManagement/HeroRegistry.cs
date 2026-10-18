using System;
using System.Collections.Generic;
using WHQCore.Heroes;
using WHQCore.Heroes.Barbarian;
using WHQCore.Heroes.DwarfWarrior;
using WHQCore.Heroes.ElfWarrior;
using WHQCore.Heroes.Wizard;
using WHQCore.Models;

namespace WHQCore.HeroManagement;

public static class HeroRegistry
{
    // List of available heroes with their display names, race, playstyle and factory methods
    public static readonly List<HeroEntry> Heroes =
    [
        new(
            "Barbarian",
            "Human",
            "Offensive, brutal, powerful hero with less self-control.",
            name => new Barbarian(name).Character,
            name => new Barbarian(name)
        ),
        new(
            "Dwarf Warrior",
            "Dwarf",
            "Tough and resilient melee fighter, defensive and dependable.",
            name => new DwarfWarrior(name).Character,
            name => new DwarfWarrior(name)
        ),
        new(
            "Elf Warrior",
            "Elf",
            "Agile ranged fighter, precise and evasive.",
            name => new ElfWarrior(name).Character,
            name => new ElfWarrior(name)
        ),
        new(
            "Wizard",
            "Human",
            "Flexible spellcaster, fragile but versatile in combat.",
            name => new Wizard(name).Character,
            name => new Wizard(name)
        )
    ];
}

public class HeroEntry
{
    public HeroEntry(
        string displayName,
        string race,
        string playstyle,
        Func<string, Hero> create,
        Func<string, HeroBase> createBase)
    {
        DisplayName = displayName;
        Race = race;
        Playstyle = playstyle;
        Create = create;
        CreateBase = createBase;
    }

    public string DisplayName { get; }
    public string Race { get; }
    public string Playstyle { get; }
    public Func<string, Hero> Create { get; }
    public Func<string, HeroBase> CreateBase { get; }
}
