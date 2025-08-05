namespace WHQCore.Models
{
    public interface ILevelProgression
    {
        int Level { get; }
        string? Title { get; }

        int? Movement { get; }
        int? WeaponSkill { get; }
        string? BallisticSkill { get; }
        int? Strength { get; }
        int? DamageDice { get; }
        int? Toughness { get; }
        int? Initiative { get; }
        int? Attacks { get; }
        int? Willpower { get; }
        int? Luck { get; }
        string? EscapePinning { get; }

        bool GainsRandomSkill { get; }
        bool GainsWoundRoll { get; }
    }
}
