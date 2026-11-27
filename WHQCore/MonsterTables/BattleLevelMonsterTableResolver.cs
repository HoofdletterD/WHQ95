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
            3 => MonsterTableLevel3.Entries,
            4 => MonsterTableLevel4.Entries,
            5 => MonsterTableLevel5.Entries,
            6 => MonsterTableLevel6.Entries,
            7 => MonsterTableLevel7.Entries,
            8 => MonsterTableLevel8.Entries,
            9 => MonsterTableLevel9.Entries,
            10 => MonsterTableLevel10.Entries,

            _ => []
        };

        return entries.FirstOrDefault(
            e => e.D66Roll == d66Roll);
    }
}