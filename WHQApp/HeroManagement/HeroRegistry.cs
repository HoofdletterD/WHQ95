using WHQCore.Models;
using WHQCreator.Heroes;
using WHQCreator.Heroes.Barbarian;
using WHQCreator.Heroes.DwarfSoldier;
using WHQCreator.Heroes.GladeGuard;
using WHQCreator.Heroes.Wizard;

namespace WHQCreator.HeroManagement;

public static class HeroRegistry
{
    // List of available heroes with their display names and factory methods
    public static readonly List<HeroEntry> Heroes =
    [
        new(
            "Barbarian",
            name => new Barbarian(name).Character,
            name => new Barbarian(name)
        ),
        new(
            "Dwarf Soldier",
            name => new DwarfSoldier(name).Character,
            name => new DwarfSoldier(name)
        ),
        new(
            "Glade Guard",
            name => new GladeGuard(name).Character,
            name => new GladeGuard(name)
        ),        
        new(
            "Wizard",
            name => new Wizard(name).Character,
            name => new Wizard(name)
        )
    ];
}

public class HeroEntry
{
    public HeroEntry(string displayName, Func<string, Hero> create, Func<string, HeroBase> createBase)
    {
        DisplayName = displayName;
        Create = create;
        CreateBase = createBase;
    }

    public string DisplayName { get; }
    public Func<string, Hero> Create { get; }
    public Func<string, HeroBase> CreateBase { get; }
}