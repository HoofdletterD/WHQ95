using WHQCore.Models;
using WHQCore.Skills;

namespace WHQCompanion.HeroLevelUp.DwarfSoldier;

public class DwarfSoldierProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return DwarfSoldierSkillsLibrary.GetSkillByValue(roll);
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        throw new NotImplementedException();
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return DwarfSoldierProgressionTable.Progression.TryGetValue(level, out progression);
    }
}