namespace WHQCore.Models;

public class MagicItemData(
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
    Dictionary<string, int>? statModifiers = null)
{
    public string TreasureTableDiceResult = treasureTableDiceResult;
    public string Name { get; } = name;
    public string Flavor { get; } = flavor;
    public string Rules { get; } = rules;
    public HashSet<RuleUsage> RuleUsages { get; } = [.. ruleUsages];

    public HashSet<HeroCode> Warriors { get; } = [.. warriors];
    public HashSet<TreasureType> TreasureType { get; } = [.. treasureType];
    public HashSet<MagicItemType> MagicItemType { get; } = [.. magicItemType];

    public int CostSell { get; } = costSell;

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