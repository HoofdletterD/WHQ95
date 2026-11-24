namespace WHQCore.MonsterTables;

public class MonsterTableEntry
{
    public int BattleLevel { get; init; }

    public int D66Roll { get; init; }

    public string Quantity { get; init; } = string.Empty;

    public string MonsterProfileId { get; init; } = string.Empty;

    public string? Notes { get; init; }
}