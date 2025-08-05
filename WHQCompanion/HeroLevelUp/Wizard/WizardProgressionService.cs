using WHQCore.Models;
using WHQCore.Spells;

namespace WHQCompanion.HeroLevelUp.Wizard;

public class WizardProgressionService : BaseHeroProgressionService
{
    protected override Skill GetSkillByRoll(string roll)
    {
        return null;
    }

    protected override Spell GetSpellByRoll(string roll)
    {
        return SpellLibrary.GetSpellByValue(roll);
    }

    protected override bool TryGetProgression(int level, out ILevelProgression progression)
    {
        return WizardLevelProgressionTable.Progression.TryGetValue(level, out progression);
    }
}