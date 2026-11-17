using WHQCore.Adventures;
using WHQCore.Cards.DungeonCards;
using WHQCore.Models.Enums;

namespace WHQCore.Dungeon;

public class DungeonDeckGenerator
{
    private readonly Random _random = new();

    private static ObjectiveRoomType MapObjectiveRoomType(string roomName)
    {
        return roomName switch
        {
            "Fountain of Light" => ObjectiveRoomType.FountainOfLight,
            "Firechasm" => ObjectiveRoomType.FireChasm,
            "Idol Chamber" => ObjectiveRoomType.IdolChamber,
            "Tomb Chamber" => ObjectiveRoomType.TombChamber,
            "Fighting Put" => ObjectiveRoomType.FightingPit,

            _ => throw new InvalidOperationException(
                $"Unknown objective room: {roomName}")
        };
    }

    public DungeonDeck GenerateCoreGameDungeon()
    {
        var coreCards =
            DungeonCards.All
                .Where(card => card.Set == ExpansionSet.CoreGame)
                .ToList();

        var entrance =
            coreCards.First(c => c.Name == "Stairway");


        var objectiveRooms =
            coreCards
                .Where(card => card.CardType == DungeonCardType.ObjectiveRoom)
                .ToList();

        var chosenObjective =
            objectiveRooms
                .OrderBy(_ => _random.Next())
                .First();

        var objectiveRoomType =
            MapObjectiveRoomType(chosenObjective.Name);

        var adventure =
            AdventureLibrary.GetRandomAdventure(
                objectiveRoomType,
                _random);

        var dungeonPool =
            coreCards
                .Where(card =>
                    card.CardType != DungeonCardType.ObjectiveRoom
                    && card.Name != "Stairway")
                .SelectMany(card =>
                    Enumerable.Repeat(card, card.Quantity))
                .ToList();

        var shuffledPool =
            dungeonPool
                .OrderBy(_ => _random.Next())
                .ToList();

        var firstSix =
            shuffledPool
                .Take(6)
                .ToList();

        firstSix.Add(chosenObjective);

        var objectiveSection =
            firstSix
                .OrderBy(_ => _random.Next())
                .ToList();

        var finalDeck = new List<DungeonCard>();

        finalDeck.AddRange(
            shuffledPool
                .Skip(6)
                .Take(6));

        finalDeck.AddRange(objectiveSection);


        return new DungeonDeck
        {
            Entrance = entrance,
            ObjectiveRoom = chosenObjective,
            Adventure = adventure,
            Cards = finalDeck
        };
    }
}