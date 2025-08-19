using WHQCore.Heroes.Wizard.Spells;
using WHQCore.Libraries.Equipment;
using WHQCore.Libraries.MagicItems;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Heroes.Wizard;

public class Wizard : HeroBase
{
    private readonly WizardProgressionService _progressionService = new();
    protected override IHeroProgression ProgressionService => _progressionService;

    public Wizard(string name) : base(name, "Wizard")
    {
        Character.HeroCode = HeroCode.W;
        SetBaseStats();
        ApplyStartingSkills();
        ApplyStartingSpells();
        ApplyStartingEquipment();
    }

    protected virtual void SetBaseStats()
    {
        var result = DiceRoller.RollD6WithRerollIfOne(out _, out _);
        Character.StartingWounds = result.Total + 6;
        Character.CurrentWounds = Character.StartingWounds;
        Character.GetRollDetails()["Wounds"] = result.ToString();
        Character.Gold = 1000000;

        Character.BattleLevel = 1;
        Character.Title = "Novice";
        Character.Movement = 4;
        Character.WeaponSkill = 2;
        Character.BallisticSkill = "6+";
        Character.Strength = 3;
        Character.DamageDice = 1;
        Character.Toughness = 3;
        Character.Initiative = 3;
        Character.Attacks = 1;
        Character.Willpower = 3;
        Character.EscapePinning = "4+";
    }

    public override void ApplyStartingSkills()
    {
        // wizards don't have a starting skill.
    }

    public override void ApplyStartingSpells()
    {
        var random = new Random();

        var randomAttack = SpellLibrary.StartingAttackSpells[random.Next(SpellLibrary.StartingAttackSpells.Count)];
        var randomDefensive = SpellLibrary.StartingDefensiveSpells[random.Next(SpellLibrary.StartingDefensiveSpells.Count)];
        var randomHealing = SpellLibrary.StartingHealingSpells[random.Next(SpellLibrary.StartingHealingSpells.Count)];

        Character.Spells ??= [];
        Character.Spells.AddRange([randomAttack, randomDefensive, randomHealing]);
    }

    public override void ApplyStartingEquipment()
    {
        Character.Equipment.Add(EquipmentLibrary.Sword);
        Character.MagicItems.Add(MagicItemLibrary.HandOfDeathScroll);
    }
}