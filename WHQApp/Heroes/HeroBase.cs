using WHQApp.Models;

namespace WHQApp.Heroes;

public abstract class HeroBase(string name, string type) : IHero
{
    protected readonly Hero _character = new(name, type);
    public Hero Character => _character;

    protected abstract IHeroProgression ProgressionService { get; }

    public virtual void LevelUp()
    {
        ProgressionService.LevelUp(Character);
    }

    public abstract void ApplyStartingSkills();
    public abstract void ApplyStartingEquipment();
}