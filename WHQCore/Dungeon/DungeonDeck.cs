using WHQCore.Adventures;
using WHQCore.Models.Enums;

namespace WHQCore.Dungeon;

public class DungeonDeck
{
    public DungeonCard Entrance { get; init; } = null!;

    public DungeonCard ObjectiveRoom { get; init; } = null!;

    public Adventure Adventure { get; init; } = null!;

    public List<DungeonCard> Cards { get; init; } = [];
}