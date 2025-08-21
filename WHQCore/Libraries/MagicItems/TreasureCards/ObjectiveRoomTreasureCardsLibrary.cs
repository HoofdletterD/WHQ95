using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems.TreasureCards;

public static class ObjectiveRoomTreasureCardsLibrary
{
        public static MagicItemData PlaceHolder => new(
        "PlaceHolder",
        "",
        "",
        treasureTableDiceResult: "111",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.CatacombsOfTerrorObjectiveRoomCard],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/magicitems/treasurecards/PlacEHolder.png",
        inventorySlot: InventorySlot.Pouch
        );

    public static MagicItemData SceptreOfZandri => new(
    "Sceptre of Zandri",
    "The Sceptre of Zandri protects its wielder from the baneful gaze of the Undead, making him harder to hit.",
    "The Sceptre may be wielded like a normal sword, and inflicts an extra D6 wounds against Undead. In addition, Undead are at -2 to hit a Warrior using the Sceptre. Permanent.",
    treasureTableDiceResult: "111",
    ruleUsages: [RuleUsage.Permanent],
    new List<HeroCode> { HeroCode.All },
    treasureType: new[] { TreasureType.CatacombsOfTerrorObjectiveRoomCard },
    magicItemType: new[] { MagicItemType.Weapon },
    costSell: 1000,
    imagePath: "images/CatacombsOfTerrorTreasureCard/SceptreOfZandri.png",
    inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData? GetMagicItemByName(string name)
    {
        var type = typeof(ObjectiveRoomTreasureCardsLibrary);
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

