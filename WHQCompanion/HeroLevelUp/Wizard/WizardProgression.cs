using System.Text;
using WHQCore.Models;

namespace WHQCompanion.HeroLevelUp.Wizard;

public class WizardLevelProgression : ILevelProgression
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

public static class WizardLevelProgressionTable
{
    public static readonly Dictionary<int, ILevelProgression> Progression = new()
    {
        [2] = new WizardLevelProgression
        {
            Level = 2,
            Title = "Champion",
            WeaponSkill = 2,
            BallisticSkill = "6+",
            Strength = 3,
            DamageDice = 1,
            Toughness = 3,
            GainsWoundRoll = true,
            Initiative = 4,
            Attacks = 1,
            Luck = 0,
            Willpower = 4,
            GainsRandomSpell = true,
            EscapePinning = "4+",
        },
        [3] = new WizardLevelProgression
        {
            Level = 3,
            Title = "Champion",
            WeaponSkill = 3,
            BallisticSkill = "6+",
            Strength = 3,
            DamageDice = 1,
            Toughness = 3,
            GainsWoundRoll = false,
            Initiative = 4,
            Attacks = 2,
            Luck = 1,
            Willpower = 4,
            GainsRandomSpell = true,
            EscapePinning = "4+",
        },
        [4] = new WizardLevelProgression
        {
            Level = 4,
            Title = "Champion",
            WeaponSkill = 3,
            BallisticSkill = "5+",
            Strength = 3,
            DamageDice = 1,
            Toughness = 3,
            GainsWoundRoll = true,
            Initiative = 4,
            Attacks = 2,
            Luck = 1,
            Willpower = 4,
            GainsRandomSpell = true,
            EscapePinning = "4+",
        },
        [5] = new WizardLevelProgression
        {
            Level = 5,
            Title = "Hero",
            WeaponSkill = 3,
            BallisticSkill = "5+",
            Strength = 3,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = false,
            Initiative = 4,
            Attacks = 2,
            Luck = 2,
            Willpower = 4,
            GainsRandomSpell = true,
            EscapePinning = "3+",
        },
        [6] = new WizardLevelProgression
        {
            Level = 6,
            Title = "Hero",
            WeaponSkill = 4,
            BallisticSkill = "5+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 4,
            Attacks = 2,
            Luck = 2,
            Willpower = 5,
            GainsRandomSpell = true,
            EscapePinning = "3+",
        },
        [7] = new WizardLevelProgression
        {
            Level = 7,
            Title = "Hero",
            WeaponSkill = 4,
            BallisticSkill = "5+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = false,
            Initiative = 4,
            Attacks = 3,
            Luck = 2,
            Willpower = 5,
            GainsRandomSpell = true,
            EscapePinning = "3+",
        },
        [8] = new WizardLevelProgression
        {
            Level = 8,
            Title = "Hero",
            WeaponSkill = 4,
            BallisticSkill = "5+",
            Strength = 4,
            DamageDice = 2,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 5,
            Attacks = 3,
            Luck = 3,
            Willpower = 5,
            GainsRandomSpell = true,
            EscapePinning = "3+",
        },
        [9] = new WizardLevelProgression
        {
            Level = 9,
            Title = "Lord",
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            DamageDice = 3,
            Toughness = 4,
            GainsWoundRoll = false,
            Initiative = 5,
            Attacks = 3,
            Luck = 3,
            Willpower = 5,
            GainsRandomSpell = true,
            EscapePinning = "3+",
        },
        [10] = new WizardLevelProgression
        {
            Level = 10,
            Title = "Lord",
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            DamageDice = 3,
            Toughness = 4,
            GainsWoundRoll = true,
            Initiative = 6,
            Attacks = 3,
            Luck = 3,
            Willpower = 5,
            GainsRandomSpell = true,
            EscapePinning = "3+",
        },
    };
}