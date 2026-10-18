using WHQCore.Helpers;
using WHQCore.Models;

namespace WHQCore.Heroes.DwarfWarrior;

public class DwarfWarriorProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return DwarfWarriorSkillsLibrary.GetSkillByValue(roll);
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        throw new NotImplementedException();
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return DwarfWarriorProgressionTable.Progression.TryGetValue(level, out progression);
    }
}