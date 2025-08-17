using WHQCore.Libraries.Equipment;
using WHQCore.Libraries.MagicItems;
using WHQCore.Libraries.Skills;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Heroes.GladeGuard;

public class GladeGuard : HeroBase
{
    private readonly GladeGuardProgressionService _progressionService = new();
    protected override IHeroProgression ProgressionService => _progressionService;

    public GladeGuard(string name) : base(name, "Glade Guard")
    {
        Character.HeroCode = HeroCode.E;
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
        Character.Skills.Add(GladeGuardSkillsLibrary.Dodge);
    }

    public override void ApplyStartingEquipment()
    {
        Character.Equipment.Add(EquipmentLibrary.Sword);
        Character.Equipment.Add(EquipmentLibrary.ElfBow);
        Character.MagicItems.Add(MagicItemLibrary.PotionOfHealing);
    }
}