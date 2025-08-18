using System.Linq;
using WHQCore.Models.Enums;

namespace WHQCore.Models;

public class MagicItemData : IInventoryItem
{
    // Required for JSON deserialization
    public MagicItemData()
    {
        RuleUsages = new HashSet<RuleUsage>();
        Warriors = new HashSet<HeroCode>();
        TreasureType = new HashSet<TreasureType>();
        MagicItemType = new HashSet<MagicItemType>();
        StatModifiers = new Dictionary<string, int>();
        Slots = new HashSet<InventorySlot>();
    }

    // Full constructor for manual creation (plural Slots)
    public MagicItemData(
        string name,
        string flavor,
        string rules,
        string treasureTableDiceResult,
        IEnumerable<RuleUsage> ruleUsages,
        IEnumerable<HeroCode> warriors,
        IEnumerable<TreasureType> treasureType,
        IEnumerable<MagicItemType> magicItemType,
        int costSell,
        string imagePath,
        IEnumerable<InventorySlot> slots,
        Dictionary<string, int>? statModifiers = null)
    {
        Name = name;
        Flavor = flavor;
        Rules = rules;
        TreasureTableDiceResult = treasureTableDiceResult;
        RuleUsages = new HashSet<RuleUsage>(ruleUsages);
        Warriors = new HashSet<HeroCode>(warriors);
        TreasureType = new HashSet<TreasureType>(treasureType);
        MagicItemType = new HashSet<MagicItemType>(magicItemType);
        CostSell = costSell;
        ImagePath = imagePath;
        Slots = new HashSet<InventorySlot>(slots);
        StatModifiers = statModifiers ?? new Dictionary<string, int>();
    }

    // Convenience overload: single inventorySlot (matches your call-site)
    public MagicItemData(
        string name,
        string flavor,
        string rules,
        string treasureTableDiceResult,
        IEnumerable<RuleUsage> ruleUsages,
        IEnumerable<HeroCode> warriors,
        IEnumerable<TreasureType> treasureType,
        IEnumerable<MagicItemType> magicItemType,
        int costSell,
        string imagePath,
        InventorySlot inventorySlot,
        Dictionary<string, int>? statModifiers = null)
        : this(
            name,
            flavor,
            rules,
            treasureTableDiceResult,
            ruleUsages,
            warriors,
            treasureType,
            magicItemType,
            costSell,
            imagePath,
            new[] { inventorySlot },
            statModifiers)
    { }

    public string Name { get; set; }
    public string Flavor { get; set; }
    public string Rules { get; set; }
    public string TreasureTableDiceResult { get; set; }
    public HashSet<RuleUsage> RuleUsages { get; set; }
    public HashSet<HeroCode> Warriors { get; set; }
    public HashSet<TreasureType> TreasureType { get; set; }
    public HashSet<MagicItemType> MagicItemType { get; set; }
    public int CostSell { get; set; }
    public string ImagePath { get; set; }
    public Dictionary<string, int> StatModifiers { get; set; }
    public HashSet<InventorySlot> Slots { get; set; }  // <- used by both constructors

    public string Description => throw new NotImplementedException();

    public HashSet<InventorySlot> Slot => throw new NotImplementedException();

    public override string ToString()
    {
        var statMods = StatModifiers.Any()
            ? " (" + string.Join(", ", StatModifiers.Select(kv => $"{kv.Key} +{kv.Value}")) + ")"
            : "";

        return $"{Name}{statMods}";
    }
}
