namespace WHQCore.Monsters;

public class EncounterMonsterSummary
{
    public required MonsterProfile Profile { get; init; }

    public required int Quantity { get; init; }

    public int TotalGold =>
        Quantity * Profile.GoldPerModel;
}