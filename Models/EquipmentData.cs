using WHQCore.Models.Enums;

namespace WHQCore.Models;

public class EquipmentData : IInventoryItem
{
    // Parameterless ctor for JSON deserialization
    public EquipmentData()
    {
        Warriors = [];
        Trader = [];
        RuleUsages = [];
        StatModifiers = new Dictionary<string, int>();
        InventorySlots = [];
    }

    // Full constructor
    public EquipmentData(
        string name,
        string rules,
        IEnumerable<HeroCode> warriors,
        IEnumerable<Trader> trader,
        IEnumerable<RuleUsage> ruleUsages,
        int costBuy,
        int costSell,
        int stock,
        string imagePath,
        IEnumerable<InventorySlot> inventorySlot,
        Dictionary<string, int>? statModifiers = null)
    {
        Name = name;
        Rules = rules;
        Warriors = new HashSet<HeroCode>(warriors);
        Trader = new HashSet<Trader>(trader);
        RuleUsages = new HashSet<RuleUsage>(ruleUsages);
        CostBuy = costBuy;
        CostSell = costSell;
        Stock = stock;
        ImagePath = imagePath;
        InventorySlots = new HashSet<InventorySlot>(inventorySlot);
        StatModifiers = statModifiers ?? new Dictionary<string, int>();
    }

    // Convenience overload: single inventory slot
    public EquipmentData(
        string name,
        string rules,
        IEnumerable<HeroCode> warriors,
        IEnumerable<Trader> trader,
        IEnumerable<RuleUsage> ruleUsages,
        int costBuy,
        int costSell,
        int stock,
        string imagePath,
        InventorySlot inventorySlot,
        Dictionary<string, int>? statModifiers = null)
        : this(name, rules, warriors, trader, ruleUsages, costBuy, costSell, stock, imagePath, [inventorySlot], statModifiers)
    { }

    public string Name { get; set; } = string.Empty;
    public string Rules { get; set; } = string.Empty;

    public HashSet<HeroCode> Warriors { get; set; }
    public HashSet<Trader> Trader { get; set; }
    public HashSet<RuleUsage> RuleUsages { get; set; }

    public int CostBuy { get; set; }
    public int CostSell { get; set; }
    public int Stock { get; set; }

    public string ImagePath { get; set; } = string.Empty;

    public Dictionary<string, int> StatModifiers { get; set; }

    // Inventory slots that this equipment occupies
    public HashSet<InventorySlot> InventorySlots { get; set; }

    // Implementation for IInventoryItem
    public HashSet<InventorySlot> Slot => InventorySlots;

    // Description now returns a safe string
    public string Description => Rules;

    public override string ToString()
    {
        var statMods = StatModifiers != null && StatModifiers.Any()
            ? " (" + string.Join(", ", StatModifiers.Select(kv => $"{kv.Key} +{kv.Value}")) + ")"
            : "";

        return $"{Name}{statMods}";
    }
}
