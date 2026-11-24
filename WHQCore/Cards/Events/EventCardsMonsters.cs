namespace WHQCore.Cards.Events;

public class EventCardMonster
{
    public string CardName { get; init; } = string.Empty;
    public string Set { get; init; } = string.Empty;
    public string Quantity { get; init; } = string.Empty;
    public string ApplicableRace { get; init; } = string.Empty;
    public string? SpecialRules { get; init; }
    public bool DrawAnotherEventCardMonster { get; init; }
    public bool TreasureCard { get; init; }
}

public static class CoreMonsterCards
{
    public static readonly List<EventCardMonster> Cards =
    [
        new()
        {
            CardName = "Minotaur",
            Set = "Core",
            Quantity = "1",
            ApplicableRace = "Beastmen",
            DrawAnotherEventCardMonster = true,
            TreasureCard = true
        },

        new()
        {
            CardName = "Minotaur",
            Set = "Core",
            Quantity = "D3",
            ApplicableRace = "Beastmen",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },

        new()
        {           
            CardName = "Giant Bats",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Vampire Counts",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Giant Rats",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Skaven",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Giant Spider",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Goblin Archer",
            Set = "Core",
            Quantity = "1D6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Goblins",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            SpecialRules = "Place 1D6 goblin spearmen and 1D6 goblin archers.",
            DrawAnotherEventCardMonster = true,
            TreasureCard = true
        },
        new()
        {
            CardName = "Goblin Spearmen",
            Set = "Core",
            Quantity = "6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Orcs",
            Set = "Core",
            Quantity = "6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Orcs",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            SpecialRules = "Place 1D6 Orc warriors and 1D6 Orc archers.",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Skaven Warriors",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Skaven",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        },
        new()
        {
            CardName = "Snotlings",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCardMonster = false,
            TreasureCard = true
        }
    ];
}