using WHQCore.Models;

namespace WHQCore.Heroes;

public abstract class HeroBase(string name, string type) : IHero
{
    protected readonly Hero _character = new(name, type)
    {
        Title = null,
        StartingWoundsRoll = null,
        BallisticSkill = null,
        EscapePinning = null
    };
    
    public Hero Character => _character;

    protected abstract IHeroProgression ProgressionService { get; }

    public virtual void LevelUp()
    {
        ProgressionService.LevelUp(Character);
    }

    public abstract void ApplyStartingSkills();
    public abstract void ApplyStartingEquipment();
    public virtual void ApplyStartingSpells()
    {
        // default: do nothing
    }
}