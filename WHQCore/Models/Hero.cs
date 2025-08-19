using WHQCore.Logic;
using WHQCore.Models.Enums;

namespace WHQCore.Models;

public class Hero(string name, string type)
{
    public static readonly Dictionary<int, int> GoldCostPerLevel = new()
    {
        { 2, 2000 },
        { 3, 4000 },
        { 4, 8000 },
        { 5, 12000 },
        { 6, 18000 },
        { 7, 24000 },
        { 8, 32000 },
        { 9, 45000 },
        { 10, 50000 }
    };

    private readonly Dictionary<string, string> _rollDetails = [];

    public string Name { get; set; } = name;
    public string HeroType { get; set; } = type;
    public HeroCode HeroCode { get; set; }
    public required string? Title { get; set; }
    public int BattleLevel { get; set; } = 1;
    public int Gold { get; set; } = 0;
    public int StartingWounds { get; set; }
    public int CurrentWounds { get; set; }
    public required DiceRoller.DiceRollResult? StartingWoundsRoll { get; set; }
    public int Movement { get; set; }
    public int WeaponSkill { get; set; }
    public required string? BallisticSkill { get; set; }
    public int Strength { get; set; }
    public int DamageDice { get; set; }
    public int Toughness { get; set; }
    public int Initiative { get; set; }
    public int Attacks { get; set; }
    public int Luck { get; set; }
    public int Willpower { get; set; }
    public required string? EscapePinning { get; set; }
    public List<EquipmentData> Equipment { get; set; } = [];
    public List<MagicItemData> MagicItems { get; set; } = [];
    public List<SpecialRule> SpecialRules { get; set; } = [];
    public List<Skill> Skills { get; set; } = [];
    public List<Spell> Spells { get; set; } = [];
    public int TotalToughness => Toughness + GetBonus("Toughness");
    public int TotalStrength => Strength + GetBonus("Strength");
    public int TotalAttacks => Attacks + GetBonus("Attacks");
    public Dictionary<InventorySlot, IInventoryItem?> EquippedItems { get; set; } = new();
    public List<IInventoryItem> Inventory { get; set; } = new();
    public List<string> SkillNotes { get; set; } = [];

    public Dictionary<string, string> GetRollDetails()
    {
        return _rollDetails;
    }

    public void AddSkillNote(string note)
    {
        SkillNotes.Add(note);
    }
    private int GetBonus(string statName)
    {
        return Equipment
            .Where(eq => eq.StatModifiers.TryGetValue(statName, out _))
            .Sum(eq => eq.StatModifiers[statName]);
    }

    public bool TryEquipItem(EquipmentData item)
    {
        foreach (var slot in item.Slot)
        {
            if (Equipment.Any(e => e.Slot.Contains(slot)))
            {
                // Slot already occupied
                return false;
            }
        }

        Equipment.Add(item);
        return true;
    }

    public void UnequipItem(EquipmentData item)
    {
        Equipment.Remove(item);
    }

}