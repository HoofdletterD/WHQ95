using WHQCompanion.HeroLevelUp.Wizard;
using WHQCore.Equipment;
using WHQCore.Logic;
using WHQCore.MagicItems;
using WHQCore.Models;

namespace WHQCreator.Heroes.Wizard;

public class Wizard : HeroBase
{
    private readonly WizardProgressionService _progressionService = new();
    protected override IHeroProgression ProgressionService => _progressionService;

    public Wizard(string name) : base(name, "Wizard")
    {
        SetBaseStats();
        ApplyStartingSkills();
        ApplyStartingEquipment();
    }

    protected virtual void SetBaseStats()
    {
        var result = DiceRoller.RollD6WithRerollIfOne(out _, out _);
        Character.StartingWounds = result.Total + 7;
        Character.GetRollDetails()["Wounds"] = result.ToString();
        Character.Gold = 1000000;

        Character.BattleLevel = 1;
        Character.Title = "Novice";
        Character.Movement = 4;
        Character.WeaponSkill = 4;
        Character.BallisticSkill = "4+";
        Character.Strength = 3;
        Character.DamageDice = 1;
        Character.Toughness = 3;
        Character.Initiative = 6;
        Character.Attacks = 1;
        Character.Willpower = 2;
        Character.EscapePinning = "Auto";
    }

    public override void ApplyStartingSkills()
    {
    // TODO: Add Random Spell
    }

    public override void ApplyStartingEquipment()
    {
        Character.Equipment.Add(EquipmentLibrary.Sword);
        Character.MagicItems.Add(MagicItemLibrary.HandOfDeathScroll);
    }
}