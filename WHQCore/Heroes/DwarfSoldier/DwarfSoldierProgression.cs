using WHQCore.Models;

namespace WHQCore.Heroes.DwarfSoldier;

public class DwarfSoldierLevelProgression : ILevelProgression
{
    public int Level { get; set; }
    public string? Title { get; set; } = "";
    public int? Movement { get; }
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

public static class DwarfSoldierProgressionTable
{
    public static readonly Dictionary<int, ILevelProgression> Progression = new()
    {
        [2] = new DwarfSoldierLevelProgression
        {
            Level = 2,
            Title = "Champion",
            WeaponSkill = 5,
            BallisticSkill = "5+",
            Strength = 3,
            DamageDice = 1,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 2,
            Attacks = 2,
            Luck = 0,
            Willpower = 4,
            GainsRandomSkill = true,
            EscapePinning = "5+",
        },

        [3] = new DwarfSoldierLevelProgression
        {
            Level = 3,
            Title = "Champion",
            WeaponSkill = 5,
            BallisticSkill = "5+",
            Strength = 3,
            DamageDice = 1,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 3,
            Attacks = 2,
            Luck = 1,
            Willpower = 4,
            GainsRandomSkill = true,
            EscapePinning = "5+",
        },

        [4] = new DwarfSoldierLevelProgression
        {
            Level = 4,
            Title = "Champion",
            WeaponSkill = 5,
            BallisticSkill = "4+",
            Strength = 4,
            DamageDice = 1,
            Toughness = 5,
            GainsWoundRoll = true,
            Initiative = 3,
            Attacks = 2,
            Luck = 1,
            Willpower = 5,
            GainsRandomSkill = false,
            EscapePinning = "5+",
        },

        [5] = new DwarfSoldierLevelProgression
        {
            Level = 5,
            Title = "Hero",
            WeaponSkill = 6,
            BallisticSkill = "4+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 5,
            GainsWoundRoll = false,
            Initiative = 3,
            Attacks = 3,
            Luck = 1,
            Willpower = 5,
            GainsRandomSkill = true,
            EscapePinning = "4+",
        },

        [6] = new DwarfSoldierLevelProgression
        {
            Level = 6,
            Title = "Hero",
            WeaponSkill = 7,
            BallisticSkill = "4+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 5,
            GainsWoundRoll = false,
            Initiative = 3,
            Attacks = 3,
            Luck = 2,
            Willpower = 5,
            GainsRandomSkill = false,
            EscapePinning = "4+",
        },

        [7] = new DwarfSoldierLevelProgression
        {
            Level = 7,
            Title = "Hero",
            WeaponSkill = 7,
            BallisticSkill = "3+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 5,
            GainsWoundRoll = true,
            Initiative = 3,
            Attacks = 3,
            Luck = 2,
            Willpower = 5,
            GainsRandomSkill = true,
            EscapePinning = "4+",
        },

        [8] = new DwarfSoldierLevelProgression
        {
            Level = 8,
            Title = "Hero",
            WeaponSkill = 7,
            BallisticSkill = "3+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 5,
            GainsWoundRoll = false,
            Initiative = 4,
            Attacks = 4,
            Luck = 2,
            Willpower = 5,
            GainsRandomSkill = false,
            EscapePinning = "4+",
        },

        [9] = new DwarfSoldierLevelProgression
        {
            Level = 9,
            Title = "Lord",
            WeaponSkill = 7,
            BallisticSkill = "2+",
            Strength = 4,
            DamageDice = 3,
            Toughness = 5,
            GainsWoundRoll = true,
            Initiative = 4,
            Attacks = 4,
            Luck = 3,
            Willpower = 6,
            GainsRandomSkill = true,
            EscapePinning = "4+",
        },

        [10] = new DwarfSoldierLevelProgression
        {
            Level = 10,
            Title = "Lord",
            WeaponSkill = 7,
            BallisticSkill = "2+",
            Strength = 4,
            DamageDice = 3,
            Toughness = 5,
            GainsWoundRoll = true,
            Initiative = 5,
            Attacks = 4,
            Luck = 3,
            Willpower = 6,
            GainsRandomSkill = true,
            EscapePinning = "4+",
        }
    };
}