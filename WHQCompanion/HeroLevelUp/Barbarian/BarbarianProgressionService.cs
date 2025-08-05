using WHQCore.Models;
using WHQCore.Skills;

namespace WHQCompanion.HeroLevelUp.Barbarian;

public class BarbarianProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return BarbarianSkillsLibrary.GetSkillByValue(roll);
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        throw new NotImplementedException();
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return BarbarianProgressionTable.Progression.TryGetValue(level, out progression);
    }
}