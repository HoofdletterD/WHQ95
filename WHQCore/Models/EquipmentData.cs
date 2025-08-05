namespace WHQCore.Models;

public class EquipmentData(
    string name,
    string rules,
    IEnumerable<HeroCode> warriors,
    IEnumerable<Trader> trader,
    IEnumerable<RuleUsage> ruleUsages,
    int costBuy,
    int costSell,
    int stock,
    string imagePath,
    Dictionary<string, int>? statModifiers = null)
{
    public string Name { get; } = name;
    public string Rules { get; } = rules;

    public HashSet<HeroCode> Warriors { get; } = [.. warriors];
    public HashSet<Trader> Trader { get; } = [.. trader];
    public HashSet<RuleUsage> RuleUsages { get; } = [.. ruleUsages];

    public int CostBuy { get; } = costBuy;
    public int CostSell { get; } = costSell;
    public int Stock { get; } = stock;

    public string ImagePath { get; } = imagePath;

    public Dictionary<string, int> StatModifiers { get; } = statModifiers ?? new Dictionary<string, int>();
    
    public override string ToString()
    {
        var statMods = StatModifiers.Any()
            ? " (" + string.Join(", ", StatModifiers.Select(kv => $"{kv.Key} +{kv.Value}")) + ")"
            : "";

        return $"{Name}{statMods}";
    }
}