using WHQCore.Models;
using WHQCore.Skills;

namespace WHQCompanion.HeroLevelUp.GladeGuard;

public class GladeGuardProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return GladeGuardSkillsLibrary.GetSkillByValue(roll);
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        throw new NotImplementedException();
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return GladeGuardLevelProgressionTable.Progression.TryGetValue(level, out progression);
    }
}