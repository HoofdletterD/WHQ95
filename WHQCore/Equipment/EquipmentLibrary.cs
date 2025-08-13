using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Equipment;

public static class EquipmentLibrary
{
    public static EquipmentData Furs => new(
        "Furs",
        "+1 Toughness. Can be combined with chainmail or light armor, in which case it causes -1 movement and -1 on all to hit rolls.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.Armourer },
        costBuy: 300,
        costSell: 75,
        stock: 4,
        imagePath: "images/equipment/Furs.png",
        statModifiers: new Dictionary<string, int>
        {
            { "Toughness", 1 }
        }
    );

    public static EquipmentData Sword => new(
        "Sword",
        "Normal Damage (1D6 + Warrior's Strength)",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.Weaponsmith },
        costBuy: 200,
        costSell: 15,
        stock: 5,
        imagePath: "images/equipment/Sword.png"
    );

    public static EquipmentData Lantern => new(
        "Lantern",
        "Illuminates the boardsection you're on and the next over boardsection. If any other hero moves outside of illuminated board sections, they will have to roll on the 'Lost in the deep' table",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.NoTraderAvailable },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/Lantern.png"
    );

    public static EquipmentData Rope => new(
        "Rope",
        "Can be used to get out of 'the Pit'. Roll a D6 after use: on a 1 or a 2, discard this item.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        ruleUsages: [RuleUsage.RequiresAction],
        trader: new List<Trader> { Trader.GeneralStore },
        costBuy: 30,
        costSell: 5,
        stock: 5,
        imagePath: "images/equipment/Sword.png"
    );

    public static EquipmentData DwarfGreatAxe => new(
        "Dwarf Great Axe",
        "Roll an additional dice to wound and choose the highest result. If two 1's are rolled for damage, the dwarf trips over his own beard. Monsters will hit the dwarf soldier with a +2 modifier until the next turn.",
        new List<HeroCode> { HeroCode.D },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.NoTraderAvailable },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/DwarfGreatAxe.png"
    );

    public static EquipmentData DwarfenChainmail => new(
        "Dwarfen Chainmail",
        "+1 Toughness.",
        new List<HeroCode> { HeroCode.D },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.NoTraderAvailable },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/DwarfenChainmail.png",
        statModifiers: new Dictionary<string, int>
        {
            { "Toughness", 1 }
        }
    );

    public static EquipmentData ElfBow => new(
        "Elf Bow",
        "Roll an additional dice to wound and choose the highest result. If two 1's are rolled for damage, the dwarf trips over his own beard. Monsters will hit the dwarf soldier with a +2 modifier until the next turn.",
        new List<HeroCode> { HeroCode.E },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.NoTraderAvailable },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/ElfBow.png"
    );

    public static EquipmentData HealingPotion => new(
        "Healing Potion",
        "Brings one warrior back up to full wounds. One use only. Discard after use.",
        new List<HeroCode> { HeroCode.All },
        ruleUsages: [RuleUsage.DiscardAfterUse],
        trader: new List<Trader> { Trader.GeneralStore },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/DwarfGreatAxe.png"
    );

    public static EquipmentData? GetEquipmentByName(string name)
    {
        var type = typeof(EquipmentLibrary);
        var props = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

        foreach (var prop in props)
        {
            if (prop.PropertyType == typeof(EquipmentData))
            {
                var eq = (EquipmentData)prop.GetValue(null);
                if (eq.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return eq;
            }
        }
        return null;
    }

}