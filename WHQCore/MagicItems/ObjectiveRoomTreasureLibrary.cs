using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.MagicItems;

public static class ObjectiveRoomTreasureLibrary
{
    public static MagicItemData RingOfSeeking => new(
        "Ring of Seeking",
        "This glittering ring is fashioned from some material that looks like quicksilver. Once placed on the finger, the ring shifts and changes as a shining, liquid-metal band.",
        "This ring allows your Warrior to attempt to avoid a trap he has just activated. Roll 1D6. On a score of 1, 2 or 3 the ring's magic fails to work and the trap goes off as normal. On a score of 4, 5 or 6 the trap is magically disarmed and fails to work.",
        treasureTableDiceResult: "11",
        ruleUsages: [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/ringofseeking.png"
    );
}