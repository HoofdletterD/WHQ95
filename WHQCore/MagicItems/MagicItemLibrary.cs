using WHQCore.Models;
using WHQCore.Models.Enums;

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
        treasureType: [TreasureType.DungeonTreasure],
        magicItemType: [MagicItemType.MagicItem],
        costSell: 200,
        imagePath: "images/equipment/PotionOfHealing.png"
    );

    public static MagicItemData HandOfDeathScroll => new(
        "Hand of Death Scroll",
        "This green bottle contains a sweet-smelling liquid with a treacly consistency.",
        "The Hand of Death scroll contains a spell that may be cast against a single monster, and causes 3D6 wounds with no modifier for armour. The spell costs no power to cast.",
        treasureTableDiceResult: "10",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DifferentTreasure],
        magicItemType: [MagicItemType.MagicItem],
        costSell: 200,
        imagePath: "images/equipment/HandOfDeathScroll.png"
    );
}