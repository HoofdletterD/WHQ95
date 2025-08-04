using WHQCore.Equipment;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Skills;

namespace WHQCreator.Heroes.Barbarian;

public class Barbarian : HeroBase
{
    private readonly BarbarianProgressionService _progressionService = new();
    protected override IHeroProgression ProgressionService => _progressionService;

    public Barbarian(string name) : base(name, "Barbarian")
    {
        SetBaseStats();
        ApplyStartingSkills();
        ApplyStartingEquipment();
    }

    protected virtual void SetBaseStats()
    {
        var result = DiceRoller.RollD6WithRerollIfOne(out _, out _);
        Character.StartingWounds = result.Total + 9;
        Character.GetRollDetails()["Wounds"] = result.ToString();
        Character.Gold = 1000000;

        Character.BattleLevel = 1;
        Character.Title = "Novice";
        Character.Movement = 4;
        Character.WeaponSkill = 3;
        Character.BallisticSkill = "5+";
        Character.Strength = 4;
        Character.DamageDice = 1;
        Character.Toughness = 3;
        Character.Initiative = 3;
        Character.Attacks = 1;
        Character.Willpower = 3;
        Character.EscapePinning = " 6+";
    }
    
    public override void ApplyStartingSkills()
    {
        Character.Skills.Add(BarbarianSkillsLibrary.Berserk);
    }

    public override void ApplyStartingEquipment()
    {
        Character.Equipment.Add(EquipmentLibrary.ThickFurs);
        Character.Equipment.Add(EquipmentLibrary.Lantern);
        Character.Equipment.Add(EquipmentLibrary.Sword);
    }
}