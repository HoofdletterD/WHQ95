using WHQCore.Models;

namespace WHQCompanion.HeroLevelUp.GladeGuard;

public class GladeGuardLevelProgression : ILevelProgression
{
    public int Level { get; set; }
    public string? Title { get; set; } = "";
    public int? Movement { get; set; }
    public int? WeaponSkill { get; set; }
    public string? BallisticSkill { get; set; }
    public int? Strength { get; set; }
    public int? DamageDice { get; set; }
    public int? Toughness { get; set; }
    public int? Initiative { get; set; }
    public int? Attacks { get; set; }
    public int? Willpower { get; set; }
    public int? Luck { get; set; }
    public string? EscapePinning { get; set; }
    public bool GainsRandomSkill { get; set; }
    public bool GainsWoundRoll { get; set; }
    public bool GainsRandomSpell { get; set; }
}

public static class GladeGuardLevelProgressionTable
{
    public static readonly Dictionary<int, ILevelProgression> Progression = new()
    {
        [2] = new GladeGuardLevelProgression
        {
            Level = 2,
            Title = "Champion",
            WeaponSkill = 5,
            BallisticSkill = "4+",
            Strength = 3,
            DamageDice = 1,
            Toughness = 3,
            GainsWoundRoll = true,
            Initiative = 6,
            Attacks = 2,
            Luck = 1,
            Willpower = 2,
            GainsRandomSkill = true,
            EscapePinning = "Auto",
        },
        [3] = new GladeGuardLevelProgression
        {
            Level = 3,
            Title = "Champion",
            WeaponSkill = 5,
            BallisticSkill = "4+",
            Strength = 4,
            DamageDice = 1,
            Toughness = 3,
            GainsWoundRoll = false,
            Initiative = 7,
            Attacks = 2,
            Luck = 2,
            Willpower = 3,
            GainsRandomSkill = false,
            EscapePinning = "Auto",
        },
        [4] = new GladeGuardLevelProgression
        {
            Level = 4,
            Title = "Champion",
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            DamageDice = 1,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 7,
            Attacks = 2,
            Luck = 2,
            Willpower = 3,
            GainsRandomSkill = true,
            EscapePinning = "Auto",
        },
        [5] = new GladeGuardLevelProgression
        {
            Level = 5,
            Title = "Hero",
            Movement = 5,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = false,
            Initiative = 8,
            Attacks = 3,
            Luck = 2,
            Willpower = 3,
            GainsRandomSkill = false,
            EscapePinning = "Auto",
        },
        [6] = new GladeGuardLevelProgression
        {
            Level = 6,
            Title = "Hero",
            WeaponSkill = 6,
            BallisticSkill = "3+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 8,
            Attacks = 3,
            Luck = 3,
            Willpower = 3,
            GainsRandomSkill = true,
            EscapePinning = "Auto",
        },
        [7] = new GladeGuardLevelProgression
        {
            Level = 7,
            Title = "Hero",
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = false,
            Initiative = 9,
            Attacks = 3,
            Luck = 3,
            Willpower = 3,
            GainsRandomSkill = false,
            EscapePinning = "Auto",
        },
        [8] = new GladeGuardLevelProgression
        {
            Level = 8,
            Title = "Hero",
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 9,
            Attacks = 4,
            Luck = 3,
            Willpower = 3,
            GainsRandomSkill = true,
            EscapePinning = "Auto",
        },
        [9] = new GladeGuardLevelProgression
        {
            Level = 9,
            Title = "Lord",
            WeaponSkill = 7,
            BallisticSkill = "2+",
            Strength = 4,
            DamageDice = 3,
            Toughness = 4,
            GainsWoundRoll = false,
            Initiative = 9,
            Attacks = 4,
            Luck = 3,
            Willpower = 4,
            GainsRandomSkill = true,
            EscapePinning = "Auto",
        },
        [10] = new GladeGuardLevelProgression
        {
            Level = 10,
            Title = "Lord",
            WeaponSkill = 7,
            BallisticSkill = "1+",
            Strength = 4,
            DamageDice = 4,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 9,
            Attacks = 4,
            Luck = 4,
            Willpower = 4,
            GainsRandomSkill = true,
            EscapePinning = "Auto",
        },
    };
}