using WHQCore.Helpers;
using WHQCore.Models;

namespace WHQCore.Heroes.ElfWarrior;

public class ElfWarriorProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return ElfWarriorSkillsLibrary.GetSkillByValue(roll);
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        throw new NotImplementedException();
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return ElfWarriorLevelProgressionTable.Progression.TryGetValue(level, out progression);
    }
}