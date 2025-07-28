namespace WHQApp.Models;

public interface IHeroProgression
{
    void ApplyProgression(Hero character);
    void LevelUp(Hero character);
}