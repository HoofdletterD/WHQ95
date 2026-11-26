namespace WHQCore.MonsterTables;

public static class BattleLevelMonsterTableResolver
{
    public static MonsterTableEntry? Resolve(
        int battleLevel,
        int d66Roll)
    {
        var entries = battleLevel switch
        {
            1 => MonsterTableLevel1.Entries,
            2 => MonsterTableLevel2.Entries,
            3 => MonsterTableLevel2.Entries,
            4 => MonsterTableLevel2.Entries,
            5 => MonsterTableLevel2.Entries,
            6 => MonsterTableLevel2.Entries,
            _ => []
        };

        return entries.FirstOrDefault(
            e => e.D66Roll == d66Roll);
    }
}