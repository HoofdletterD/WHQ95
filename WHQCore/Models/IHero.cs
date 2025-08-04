namespace WHQCore.Models;

public interface IHero
{
    Hero Character { get; }
    void LevelUp();
    void ApplyStartingSkills();
    void ApplyStartingEquipment();
}