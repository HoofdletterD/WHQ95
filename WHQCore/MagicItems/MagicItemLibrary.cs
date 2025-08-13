using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.MagicItems;

public static class MagicItemLibrary
{
    public static MagicItemData HandOfDeathScroll => new(
        "Hand of Death Scroll",
        "A dusty scroll that contains a powerful incantation to drain the life out of a single target.",
        "The Hand of Death scroll contains a spell that may be cast against a single monster, and causes 3D6 wounds with no modifier for armour. The spell costs no power to cast.",
        treasureTableDiceResult: "10",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DifferentTreasure],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/HandOfDeathScroll.png"
    );

    public static MagicItemData PotionOfHealing => new(
        "Potion of Healing",
        "This green bottle contains a sweet-smelling liquid with a treacly consistency.",
        "Heals all damage",
        treasureTableDiceResult: "35",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/PotionOfHealing.png"
    );
    
    public static MagicItemData? GetMagicItemByName(string name)
    {
        var type = typeof(MagicItemLibrary);
        var props = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

        foreach (var prop in props)
        {
            if (prop.PropertyType == typeof(MagicItemData))
            {
                var item = (MagicItemData)prop.GetValue(null);
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
        }
        return null;
    }
}