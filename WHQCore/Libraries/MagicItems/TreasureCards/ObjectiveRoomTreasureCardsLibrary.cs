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
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTrasureCard],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/magicitems/treasurecards/PlacEHolder.png",
        inventorySlot: InventorySlot.Pouch
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

