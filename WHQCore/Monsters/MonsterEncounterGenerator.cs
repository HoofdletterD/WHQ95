using WHQCore.Logic;
using WHQCore.Models.MonsterModels;
using WHQCore.MonsterTables;

namespace WHQCore.Monsters;

public static class MonsterEncounterGenerator
{
    public static Encounter GenerateLevel1Encounter(int d66Roll)
    {

        var entries = MonsterTableLevel1.Entries
            .Where(x => x.D66Roll == d66Roll)
            .ToList();

        return new Encounter
        {
            MonsterGroups =
            [
                .. entries
                    .Select(x => new MonsterGroup
                    {
                        MonsterProfileId = x.MonsterProfileId,
                        QuantityExpression = x.Quantity
                    })
            ]
        };
    }

    public static GeneratedEncounter GenerateLevel1EncounterWithQuantities(int d66Roll)
    {
        var encounter = GenerateLevel1Encounter(d66Roll);

        return new GeneratedEncounter
        {
            MonsterGroups =
            [
                .. encounter.MonsterGroups
                    .Select(x => new GeneratedMonsterGroup
                    {
                        MonsterProfileId = x.MonsterProfileId,
                        Quantity = DiceRoller.RollExpression(x.QuantityExpression)
                    })
            ]
        };
    }

}
