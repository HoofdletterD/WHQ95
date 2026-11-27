using WHQCore.Models.Enums;
using WHQCore.Monsters;

namespace WHQCore.Cards.Events;

public class EventCardMonster
{
    public string CardName { get; init; } = string.Empty;
    public ExpansionSet Set { get; init; }
    public string Quantity { get; init; } = string.Empty;
    public MonsterAllegiance MonsterAllegiance { get; init; }
    public string? SpecialRules { get; init; }
    public bool DrawAnotherEventCard { get; init; }
    public bool TreasureCard { get; init; }
    public required string MonsterProfileId { get; init; }
}

// TODO: Support multiple monster profiles per card.
public static class CoreMonsterCards
{
    public static readonly List<EventCardMonster> Cards =
    [
        new()
        {
            CardName = "Minotaur",
            Set = ExpansionSet.CoreGame,
            Quantity = "1",
            MonsterAllegiance = MonsterAllegiance.Beastmen,
            DrawAnotherEventCard = true,
            TreasureCard = true,
            MonsterProfileId = "core.minotaur"
        },

        new()
        {
            CardName = "Minotaur",
            Set = ExpansionSet.CoreGame,
            Quantity = "D3",
            MonsterAllegiance = MonsterAllegiance.Beastmen,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.minotaur"
        },

        new()
        {           
            CardName = "Giant Bats",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.VampireCounts,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.giant_bat"
        },
        new()
        {
            CardName = "Giant Rats",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.Skaven,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.giant_rat"
        },
        new()
        {
            CardName = "Giant Spiders",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.Neutral,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.giant_spider"
        },
        new()
        {
            CardName = "Goblin Archers",
            Set = ExpansionSet.CoreGame,
            Quantity = "1D6",
            MonsterAllegiance = MonsterAllegiance.Greenskins,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.goblin_archer"
        },
        new()
        {
            CardName = "Goblins",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.Greenskins,
            SpecialRules = "Place 1D6 goblin spearmen and 1D6 goblin archers.",
            DrawAnotherEventCard = true,
            TreasureCard = true,
            MonsterProfileId = "core.goblin_warrior"
        },
        new()
        {
            CardName = "Goblin Spearmen",
            Set = ExpansionSet.CoreGame,
            Quantity = "6",
            MonsterAllegiance = MonsterAllegiance.Greenskins,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.goblin_warrior"
        },
        new()
        {
            CardName = "Orcs",
            Set = ExpansionSet.CoreGame,
            Quantity = "6",
            MonsterAllegiance = MonsterAllegiance.Greenskins,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.orc_warrior"
        },
        new()
        {
            CardName = "Orcs",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.Greenskins,
            SpecialRules = "Place 1D6 Orc warriors and 1D6 Orc archers.",
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.orc_warrior"
        },
        new()
        {
            CardName = "Skaven Warriors",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.Skaven,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.skaven_warrior"
        },
        new()
        {
            CardName = "Snotlings",
            Set = ExpansionSet.CoreGame,
            Quantity = "2D6",
            MonsterAllegiance = MonsterAllegiance.Greenskins,
            DrawAnotherEventCard = false,
            TreasureCard = true,
            MonsterProfileId = "core.snotling"
        }
    ];
}