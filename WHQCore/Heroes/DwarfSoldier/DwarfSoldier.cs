using WHQCore.Libraries.Equipment;
using WHQCore.Libraries.Skills;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Heroes.DwarfSoldier;

public class DwarfSoldier : HeroBase
{
    private readonly DwarfSoldierProgressionService _progressionService = new();
    protected override IHeroProgression ProgressionService => _progressionService;

    public DwarfSoldier(string name) : base(name, "Dwarf Soldier")
    {
        Character.HeroCode = HeroCode.D;
        SetBaseStats();
        ApplyStartingSkills();
        ApplyStartingEquipment();
    }

    protected virtual void SetBaseStats()
    {
        var result = DiceRoller.RollD6WithRerollIfOne(out _, out _);
        Character.StartingWounds = result.Total + 8;
        Character.GetRollDetails()["Wounds"] = result.ToString();
        Character.Gold = 1000000;

        Character.BattleLevel = 1;
        Character.Title = "Novice";
        Character.Movement = 4;
        Character.WeaponSkill = 4;
        Character.BallisticSkill = "5+";
        Character.Strength = 3;
        Character.DamageDice = 1;
        Character.Toughness = 4;
        Character.Initiative = 2;
        Character.Attacks = 1;
        Character.Willpower = 4;
        Character.EscapePinning = " 5+";
    }

    public override void ApplyStartingSkills()
    {
        Character.Skills.Add(DwarfSoldierSkillsLibrary.RunicItems);
    }

    public override void ApplyStartingEquipment()
    {
        Character.Equipment.Add(EquipmentLibrary.Rope);
        Character.Equipment.Add(EquipmentLibrary.DwarfGreatAxe);
        Character.Equipment.Add(EquipmentLibrary.DwarfenChainmail);
    }
}