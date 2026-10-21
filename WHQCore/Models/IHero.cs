namespace WHQCore.Models;

public interface IHero
{
    Hero Character { get; }
    LevelUpResult LevelUp();
    void ApplyStartingSkills();
    void ApplyStartingEquipment();
    void ApplyStartingSpells();
}