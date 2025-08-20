using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems.TreasureCards;

public static class DungeonRoomTreasureCardsLibrary
{
    public static MagicItemData BlessedWater => new(
        "Blessed Water",
        "The blessed water can be used to heal or exorcise evil spirits and banish undead.",
        "A warrior can drink some blessed water in which case he immediately heals 1D6 wounds. Everytime a warrior drinks some blessed water roll a D6. On a 1, the water has run out and discard this treasure. The blessed water can also be thrown just like a missile weapon and all the normal rules apply. It will only effect the undead or daemons, and on a succesful hit causes 2D6 wounds with no deduction for toughness and armor. This card this card after thrown.",
        treasureTableDiceResult: "111",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
        magicItemType: [MagicItemType.Item],
        costSell: 150,
        imagePath: "images/magicitems/treasurecards/BlessedWater.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static MagicItemData FreezingDeathSpellJewel => new(
        "Freezing Death Spell Jewel",
        "This jewel is carved of ice that never melts, and it's freezing to the touch. When it's power is invoked, it releases a lethal blast of icy shards at the wizard's foes.",
        "This jewel may be used once per turn to cast the Freezing Death spell. The bearer must make his normal BS roll to hit as with normal missile attack. If he hits the monster, then he rolls 1D6 to see how many dice of wounds he causes. e.g: if he rolls a 2, he causes 2D6 wounds, not just 2 wounds.",
        treasureTableDiceResult: "112",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
        magicItemType: [MagicItemType.Item],
        costSell: 400,
        imagePath: "images/magicitems/treasurecards/FreezingDeathSpellJewel.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static MagicItemData GlobeOfDetection => new(
        "Globe of Detection",
        "The Globe of Detection allows the warrior's vision to pierce the solid rock of the dungeon walls.",
        "A warrior with the globe of detection can easily find hidden passages. When the warrior rolls on the Hidden Passage table, he may add +1 to his roll. However, if the warrior rolls a 1, then that result stants and the warriors will suffer a 'Collapse!' result.",
        treasureTableDiceResult: "113",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/magicitems/treasurecards/GlobeOfDetection.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static MagicItemData GemOfPassage => new(
    "Gem of Passage",
    "The gem of passage was wrought many centuries ago by the Dwarfs. It aided them in building their underground empire and can be used to control the very rocks that make up the ceiling and floor of the dungeon.",
    "When a warrior invokes its power, the Gem of Passage opens a hole in one of the walls. Place another doorway on the board section the warrior occupies. Beyond this doorway will be 1D6+3 more dungeon cards which the warriors can explore as normal.",
    treasureTableDiceResult: "114",
    ruleUsages: [RuleUsage.OncePerDungeon],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
    magicItemType: [MagicItemType.Item],
    costSell: 250,
    imagePath: "images/magicitems/treasurecards/GemOfPassage.png",
    inventorySlot: InventorySlot.Pouch
);

    public static MagicItemData Grimstone => new(
    "Grimstone",
    "The age-pitted surface of this ancient stone hides the power to drain the life energy of others and transfer it to its wearer.",
    "Upon invoking the grimstone, choose any other warrior in the party. Your warrior now has the same number of wounds as that warrior, while he has the numer of woounds your warrior had. In effect, their suffered wounds are swapped. The grimstone may not take any warrior above their starting wounds.",
    treasureTableDiceResult: "115",
    ruleUsages: [RuleUsage.DiscardAfterUse],
    new List<HeroCode> { HeroCode.D },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
    magicItemType: [MagicItemType.Item],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/Grimstone.png",
    inventorySlot: InventorySlot.Pouch
);
    public static MagicItemData MoradrielsBoots => new(
    "Moradriel's Boots",
    "Moradriel was a skilled elf mage who created many powerful magic items, most of which have been lost or destroyed down the long years. As soon as these boots are put on, the whole world seems to slow down.",
    "While wearing these boots, your warrior's movement charactaristic is 1D6+1. Roll each turn to see how far your warrior can move.",
    treasureTableDiceResult: "116",
    ruleUsages: [RuleUsage.Permanent],
    new List<HeroCode> { HeroCode.E },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
    magicItemType: [MagicItemType.Boots],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/MoradrielsBoots.png",
    inventorySlot: InventorySlot.Pouch
);
    public static MagicItemData ReaperSword => new(
    "ReaperSword",
    "This mighty sword is sharper than a razor. Its keen blade glistens in the light of the lantern, and even in the shadows it shimmers with an eerie inner light.",
    "While your warrior is using this sword he gets +2 Strength.",
    treasureTableDiceResult: "117",
    ruleUsages: [RuleUsage.Permanent],
    new List<HeroCode> { HeroCode.B },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
    magicItemType: [MagicItemType.Weapon],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/ReaperSword.png",
    inventorySlot: InventorySlot.MainHand
);
    public static MagicItemData Soulstone => new(
    "Soulstone",
    "The soulstone captures the departing soul of the bearer, should he be slain. Someone with the correct knowledge can then restore the soul to its body, resurrecting the unfortunate person.",
    "If the warrior with the soulstone is killed, by whatever means, he can be resurrected once the adventure is over. He loses any gold and treasure he may have accumulated during that adventure and is unchanged from the warrior he was when he set off down the dungeon.",
    treasureTableDiceResult: "118",
    ruleUsages: [RuleUsage.OneUseOnly],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
    magicItemType: [MagicItemType.Item],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/Soulstone.png",
    inventorySlot: InventorySlot.Pouch
);    

    public static MagicItemData? GetMagicItemByName(string name)
    {
        var type = typeof(DungeonRoomTreasureCardsLibrary);
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

