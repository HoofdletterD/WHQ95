using WHQCore.Models;
using WHQCore.Skills;
using WHQCreator.Heroes;

namespace WHQCompanion.HeroLevelUp.Barbarian;

public class BarbarianProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return BarbarianSkillsLibrary.GetSkillByValue(roll);
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return BarbarianProgressionTable.Progression.TryGetValue(level, out progression);
    }
}