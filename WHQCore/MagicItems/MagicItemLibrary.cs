using WHQCore.Models;

namespace WHQCore.MagicItems;

public static class MagicItemLibrary
{
    public static MagicItemData PotionOfHealing => new(
        "Potion of Healing",
        "This green bottle contains a sweet-smelling liquid with a treacly consistency.",
        "Heals all damage",
        treasureTableDiceResult: "35",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [Models.TreasureType.DungeonTreasure],
        magicItemType: [Models.MagicItemType.MagicItem],
        costSell: 200,
        imagePath: "images/equipment/PotionOfHealing.png"
    );
}