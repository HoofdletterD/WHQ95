using WHQCore.Models;
using WHQCreator.Heroes;
using WHQCreator.Heroes.Barbarian;

namespace WHQCreator.HeroManagement;

public static class HeroRegistry
{
    // List of available heroes with their display names and factory methods
    public static readonly List<HeroEntry> Heroes =
    [
        new HeroEntry(
            "Barbarian",
            name => new Barbarian(name).Character,
            name => new Barbarian(name)
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