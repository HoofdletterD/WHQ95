using WHQCore.Models;

namespace WHQCompanion.HeroLevelUp.Barbarian;

public class BarbarianLevelProgression : ILevelProgression
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

public static class BarbarianProgressionTable
{
    public static readonly Dictionary<int, ILevelProgression> Progression = new()
    {
        [2] = new BarbarianLevelProgression
        {
            Level = 2,
            Title = "Champion",
            Toughness = 4,
            Luck = 1,
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [3] = new BarbarianLevelProgression
        {
            Level = 3,
            Title = "Champion",
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Toughness = 4,
            Luck = 1,
            Attacks = 2,
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [4] = new BarbarianLevelProgression
        {
            Level = 4,
            Title = "Champion",
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Toughness = 4,
            Luck = 2,
            Attacks = 2,
            Willpower = 4,
            Initiative = 4,
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [5] = new BarbarianLevelProgression
        {
            Level = 5,
            Title = "Hero",
            WeaponSkill = 5,
            BallisticSkill = "4+",
            Toughness = 4,
            Luck = 2,
            Attacks = 3,
            Willpower = 4,
            Initiative = 4,
            DamageDice = 2,
            EscapePinning = "5+",
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [6] = new BarbarianLevelProgression
        {
            Level = 6,
            Title = "Hero",
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Toughness = 4,
            Luck = 2,
            Willpower = 4,
            Attacks = 3,
            Initiative = 5,
            DamageDice = 2,
            EscapePinning = "5+",
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [7] = new BarbarianLevelProgression
        {
            Level = 7,
            Title = "Hero",
            WeaponSkill = 6,
            BallisticSkill = "3+",
            Toughness = 4,
            Luck = 3,
            Willpower = 4,
            Attacks = 3,
            Initiative = 5,
            DamageDice = 2,
            EscapePinning = "5+",
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [8] = new BarbarianLevelProgression
        {
            Level = 8,
            Title = "Hero",
            WeaponSkill = 6,
            BallisticSkill = "3+",
            Toughness = 4,
            Luck = 3,
            Willpower = 4,
            Attacks = 4,
            Initiative = 5,
            DamageDice = 2,
            EscapePinning = "5+",
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [9] = new BarbarianLevelProgression
        {
            Level = 9,
            Title = "Lord",
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Toughness = 4,
            Luck = 3,
            Willpower = 4,
            Attacks = 4,
            Initiative = 6,
            DamageDice = 3,
            EscapePinning = "5+",
            GainsWoundRoll = true,
            GainsRandomSkill = true
        },

        [10] = new BarbarianLevelProgression
        {
            Level = 10,
            Title = "Lord",
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Toughness = 4,
            Luck = 3,
            Willpower = 4,
            Attacks = 4,
            Initiative = 6,
            DamageDice = 3,
            EscapePinning = "5+",
            GainsWoundRoll = true,
            GainsRandomSkill = true
        }
    };
}