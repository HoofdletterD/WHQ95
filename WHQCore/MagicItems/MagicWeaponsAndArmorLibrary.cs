using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.MagicItems;

public static class MagicWeaponsAndArmorLibrary
{
    public static MagicItemData Heartseeker => new(
        "Heartseeker",
        "This sword has the ability to warp time, guiding its own destiny to the benefit of whoever wields it in battle.",
        "Once per turn, while your Warrior is using this sword, you may re-roll any one of his Attacks that misses.",
        treasureTableDiceResult: "11",
        ruleUsages: [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 500,
        imagePath: "images/magicweaponsandarmor/heartseeker.png"
    );
}