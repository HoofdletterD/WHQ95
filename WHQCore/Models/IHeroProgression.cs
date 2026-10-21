namespace WHQCore.Models;

public interface IHeroProgression
{
    void ApplyProgression(Hero character);
    LevelUpResult LevelUp(Hero character);
}
