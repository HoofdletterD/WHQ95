using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.HeroManagement;
public class HeroSaveData
{
    public string Name { get; set; }
    public string HeroType { get; set; }
    public int BattleLevel { get; set; }
    public int Gold { get; set; }
    public int StartingWounds { get; set; }
    public int Movement { get; set; }
    public int WeaponSkill { get; set; }
    public string BallisticSkill { get; set; }
    public int Strength { get; set; }
    public int Toughness { get; set; }
    public int Initiative { get; set; }
    public int Attacks { get; set; }
    public int Luck { get; set; }
    public int Willpower { get; set; }
    public string EscapePinning { get; set; }

    public List<SkillSaveData> Skills { get; set; } = [];
    public List<string> Spells { get; set; } = [];
    public List<string> Equipment { get; set; } = [];
    public List<MagicItemData> MagicItems { get; set; } = [];
    public List<MagicItemData> MagicWeaponsAndArmor { get; set; } = [];
    public List<MagicItemData> ObjectiveRoomTreasure { get; set; } = [];
    public List<string> SpecialRules { get; set; } = [];
    public Dictionary<InventorySlot, string> EquippedItems { get; set; } = new();
    public string Bio { get; set; }
    public List<string> Traits { get; set; } = new();
}

public class SkillSaveData
{
    public string Name { get; set; }
    public string Value { get; set; }
}

