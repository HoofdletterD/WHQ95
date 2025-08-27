using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems.RolePlayBookTables;

public static class MagicWeaponsAndArmorLibrary
{
    public static MagicItemData Heartseeker => new(
        "Heartseeker",
        "This sword has the ability to warp time, guiding its own destiny to the benefit of whoever wields it in battle.",
        "Once per turn, while your Warrior is using this sword, you may re-roll any one of his Attacks that misses.",
        treasureTableDiceResult: "11",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 500,
        imagePath: "images/equipment/Heartseeker.png",
        inventorySlot: InventorySlot.MainHand
    );


    public static MagicItemData BerserkerSword => new(
        "Berserker Sword",
        "This brutal weapon appears to be crudely fashioned from a dull, iron-like metal, and has sinister-looking runes engraved upon its hilt.",
        "When used by the Barbarian, this sword adds +1 to the dice roll to see if he becomes berserk. When used by other Warriors, this sword has no magical effect.",
        treasureTableDiceResult: "12",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 250,
        imagePath: "images/equipment/BerserkerSword.png",
        inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData BronzeSigilSword => new(
        "Bronze Sigil Sword",
        "The runes on this blade shimmer in the light. It is exceptionally light and well-balanced in the hand.",
        "While your Warrior is using this sword, he gains +2 Initiative.",
        treasureTableDiceResult: "13",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 100,
        imagePath: "images/equipment/BronzeSigilSword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BootsOfQuargskin => new(
        "Boots of Quargskin",
        "These boots are made of a strange, soft leather covered with multicoloured swirls and stripes.",
        "For one turn per adventure, while your Warrior is wearing these boots, he gains +2 Movement. If your Warrior tries to sell these boots, no trader will take him seriously, and they will refuse to buy them.",
        treasureTableDiceResult: "14",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 0,
        imagePath: "images/equipment/BootsOfQuargskin.png",
        inventorySlot: InventorySlot.Legs
    );

    public static MagicItemData SwordOfEnsorcelledIron => new(
        "Sword of Ensorcelled Iron",
        "This dark iron blade is surrounded by a crackling, spitting aura of energy.",
        "While your Warrior is using this sword, he gets +1 on all to-hit rolls.",
        treasureTableDiceResult: "15",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 150,
        imagePath: "images/equipment/SwordOfEnsorcelledIron.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BitingBlade => new(
        "Biting Blade",
        "This sword has been magically sharpened to a razor-fine edge, and is capable of biting through sheet steel as if it were paper.",
        "While your Warrior is using this sword, each attack he makes ignores the first point of his opponent's armour.",
        treasureTableDiceResult: "16",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 150,
        imagePath: "images/equipment/BitingBlade.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData SwordOfStone => new(
        "Sword of Stone",
        "As soon as your Warrior picks up this sword, he feels his skin hardening into a stone-like material, which remains as flexible as normal flesh.",
        "While your Warrior is using this sword, he gets +2 Toughness.",
        treasureTableDiceResult: "21",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 500,
        imagePath: "images/equipment/SwordOfStone.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BladeOfLeapingCopper => new(
        "Blade of Leaping Copper",
        "This sword seems to have a life of its own, striking in a blurred arc of slicing metal.",
        "While your Warrior is using this sword, he gets +1 Attack.",
        treasureTableDiceResult: "22",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 300,
        imagePath: "images/equipment/BladeOfLeapingCopper.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BladeOfCouronne => new(
        "Blade of Couronne",
        "This is the blade that the master swordsmiths of Bretonnia forged to defeat an Undead Liche-king many centuries past.",
        "While he uses this sword, each undead Monster in a square adjacent to your Warrior automatically suffers 1 Wound at the end of each turn, after any Regeneration, with no modifiers for Toughness or armour.",
        treasureTableDiceResult: "23",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 200,
        imagePath: "images/equipment/BladeOfCouronne.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData MagicSword => new(
        "Magic Sword",
        "This blade glows with a yellow light and is slightly warm to the touch.",
        "While your Warrior is using this sword, he may attack Monsters that are only affected by magical weapons.",
        treasureTableDiceResult: "24",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 25,
        imagePath: "images/equipment/MagicSword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData RelicBlade => new(
        "Relic Blade",
        "This holy blade is an artefact of great religious significance within the Empire, and was reputed to have been used by the realm's mightiest heroes in numerous battles.",
        "While your Warrior is using this sword, he gets +1 on his to-hit roll.",
        treasureTableDiceResult: "25",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 400,
        imagePath: "images/equipment/RelicBlade.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BladeOfSlicing => new(
        "Blade of Slicing",
        "This sword moans softly as it is drawn from its scabbard, in eager anticipation of the blood it is about to spill.",
        "While your Warrior is using this sword, he causes +2 Wounds on each successful attack.",
        treasureTableDiceResult: "26",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 300,
        imagePath: "images/equipment/BladeOfSlicing.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData DartingSteelBlades => new(
        "Darting Steel Blades",
        "These daggers guide the hand of whoever wields them and have never been known to miss their target.",
        "While your Warrior is using these daggers, he gets +1 Attack and you do not have to roll to see if he hits his opponent. Each attack hits automatically. However, each hit from one of these daggers only does 1D6 Wounds, with no modifier for Strength.",
        treasureTableDiceResult: "31",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 350,
        imagePath: "images/equipment/DartingSteelBlades.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData MagicalQuiver => new(
    "Magical Quiver",
    "This quiver is made from soft leather and has magical runes branded into its surface.",
    "Any arrows or crossbow bolts placed in this quiver immediately become enchanted so they can affect Monsters that can only be hit with magical weapons.",
    treasureTableDiceResult: "32",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.B, HeroCode.E },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Item],
    costSell: 25,
    imagePath: "images/equipment/MagicalQuiver.png",
    inventorySlot: InventorySlot.Back
);

    public static MagicItemData BoneBlade => new(
    "Bone Blade",
    "This magical blade is made of a bleached white substance that looks like bone, but is as sharp as steel.",
    "Once per adventure your Warrior may trade in all his normal attacks and use this sword to make a single attack that causes normal damage +(1D6 x his Battle-level) extra wounds.",
    treasureTableDiceResult: "33",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Weapon],
    costSell: 400,
    imagePath: "images/equipment/BoneBlade.png",
    inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData EltharionsBow => new(
        "Eltharion's Bow",
        "This bow is enchanted with Elf magic that makes it much more accurate.",
        "While your Warrior is using this bow he gets +1 to hit.",
        treasureTableDiceResult: "34",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Bow],
        costSell: 200,
        imagePath: "images/equipment/EltharionsBow.png",
    inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData SwordOfMight => new(
        "Sword of Might",
        "This sword is imbued with the strength of a Minotaur, and any blow it strikes is delivered with the power of a raging beast.",
        "While your Warrior is using this sword he gets +1 Strength.",
        treasureTableDiceResult: "35",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 150,
        imagePath: "images/equipment/SwordOfMight.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData CloakOfStealth => new(
        "Cloak of Stealth",
        "This cloak is made of an odd material that is slippery to the touch.",
        "Once per adventure, while your Warrior is wearing this cloak, he may automatically break from pinning.",
        treasureTableDiceResult: "36",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/equipment/CloakOfStealth.png",
        inventorySlot: InventorySlot.Back
    );

    public static MagicItemData ObsidianBlade => new(
        "Obsidian Blade",
        "It is believed that this sword is made from the solidified blackness of the void, explaining its ability to destroy any armour it touches.",
        "After your Warrior has made a successful attack while using this sword, roll a D6. On a score of 1, 2 or 3 the sword makes a normal attack. On a score of 4, 5 or 6 the sword ignores and destroys the target's armour.",
        treasureTableDiceResult: "41",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 450,
        imagePath: "images/equipment/ObsidianBlade.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData GiantSlayer => new(
        "Giant Slayer",
        "This massive sword may only be wielded with both hands and even then it takes a mighty Warrior to use it effectively.",
        "While your Warrior is using this sword he gets +3 Strength. This sword may not be used while using a shield.",
        treasureTableDiceResult: "42",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 250,
        imagePath: "images/equipment/GiantSlayer.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData SwordOfResilience => new(
        "Sword of Resilience",
        "This sword throws a mantle of power around its wielder, protecting him from his enemies.",
        "While your Warrior is using this sword he gets +1 Toughness.",
        treasureTableDiceResult: "43-44",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 200,
        imagePath: "images/equipment/SwordOfResilience.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData HelmetOfFarseeing => new(
        "Helmet of Farseeing",
        "This black helm has no apparent visor. Yet it imparts upon the wearer the ability to see clearly even in the dim light of the dungeon.",
        "While wearing this helmet your Warrior gets the normal +1 Toughness for wearing a helm. In addition, this helmet allows him to move around and see in the dark just as if he had a lantern.",
        treasureTableDiceResult: "45",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Helmet],
        costSell: 800,
        imagePath: "images/equipment/HelmetOfFarseeing.png",
        inventorySlot: InventorySlot.Head
    );

    public static MagicItemData ParryingBlade => new(
        "Parrying Blade",
        "This sword darts forward of its own volition to meet the weapon of an attacker, stopping the blow from hitting home.",
        "While your Warrior is using this sword he may attempt to parry any single incoming attack. Roll a D6. On a score of 1, 2 or 3 the blade fails to work and the attack hits home. On a score of 4, 5 or 6 the attack is magically turned away and has no effect.",
        treasureTableDiceResult: "46",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 400,
        imagePath: "images/equipment/ParryingBlade.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData Deathsword => new(
        "Deathsword",
        "This sword's power is such that it cannot really be controlled and would soon overwhelm whoever carried it.",
        "Once per adventure your Warrior may use this sword to increase his Strength to 10 for one turn.",
        treasureTableDiceResult: "51",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 400,
        imagePath: "images/equipment/Deathsword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData Dragonhelm => new(
        "Dragonhelm",
        "This ancient Elven helm is inscribed with a glowing rune of fire.",
        "While your Warrior is wearing this helmet he gets +2 Toughness against all fire-based attacks.",
        treasureTableDiceResult: "52",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Helmet],
        costSell: 300,
        imagePath: "images/equipment/Dragonhelm.png",
        inventorySlot: InventorySlot.Head
    );

    public static MagicItemData BladeOfSeaGold => new(
    "Blade of Sea Gold",
    "Forged from gold taken from the depths of the sea when the world was young, this blade is covered in runes so ancient and worn that they can no longer be read.",
    "While your Warrior is using this sword each attack he makes ignores the first point of his opponent's armour.",
    treasureTableDiceResult: "53",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Weapon],
    costSell: 150,
    imagePath: "images/equipment/BladeOfSeaGold.png",
        inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData BladeOfLeapingSeaGold => new(
"Blade of Leaping Sea Gold",
"Forged from gold taken from the depths of the sea when the world was young, this blade is covered in runes so ancient and worn that they can no longer be read.",
"While your Warrior is using this sword each attack he makes ignores the first point of his opponent's armour.",
treasureTableDiceResult: "54",
ruleUsages: [RuleUsage.None],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.DungeonTreasureMagicItems],
magicItemType: [MagicItemType.Weapon],
costSell: 150,
imagePath: "images/equipment/BladeOfSeaGold.png",
    inventorySlot: InventorySlot.MainHand
);


    public static MagicItemData OgreSlayer => new(
        "Ogre Slayer",
        "This brutal, broad-bladed axe is a powerful weapon, almost certainly of Dwarf origin.",
        "While using this axe your Warrior gets +2 Strength (+3 if he is a Dwarf).",
        treasureTableDiceResult: "55",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Axe],
        costSell: 400,
        imagePath: "images/equipment/OgreSlayer.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData OgreSlayerAxe => new(
    "Ogre Slayer Axe",
    "This brutal, broad-bladed axe is a powerful weapon, almost certainly of Dwarf origin.",
    "While using this axe your Warrior gets +2 Strength (+3 if he is a Dwarf).",
    treasureTableDiceResult: "56",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.B, HeroCode.D },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Axe],
    costSell: 400,
    imagePath: "images/equipment/OgreSlayer.png",
    inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData BlessedSword => new(
        "Blessed Sword",
        "Cooled in the waters of the temple of Ulric, this sword is a powerful weapon of purity.",
        "While your Warrior is using this sword he only misses his opponent if his to hit roll is a 1 or a 2.",
        treasureTableDiceResult: "61",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Weapon],
        costSell: 300,
        imagePath: "images/equipment/BlessedSword.png",
        inventorySlot: InventorySlot.MainHand
    );


    public static MagicItemData GreyArmourOfEshkalon => new(
        "Grey Armour of Eshkalon",
        "This dull grey armour is made of a flaky, stone-like substance and is extremely resilient.",
        "While your Warrior is wearing this armour roll 1D6 for each incoming attack. On a score of 1 the armour shatters and is useless. On a score of 2 or more the armour absorbs that many Wounds.",
        treasureTableDiceResult: "62",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Armour],
        costSell: 400,
        imagePath: "images/equipment/GreyArmourOfEshkalon.png",
        inventorySlot: InventorySlot.Torso
    );

    public static MagicItemData ArmourOfFortune => new(
        "Armour of Fortune",
        "This armour's gleaming metal plates magically reflect all the battles in which it has been worn in a rainbow array of never-ending carnage and war.",
        "The armour absorbs and stores damage. Once worn it cannot be removed for the rest of the adventure. It can absorb 30 Wounds, after which it explodes, taking the Warrior down to zero wounds (unless a potion or spell intervenes).",
        treasureTableDiceResult: "63",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Armour],
        costSell: 500,
        imagePath: "images/equipment/ArmourOfFortune.png",
        inventorySlot: InventorySlot.Torso
    );

    public static MagicItemData ArmourOfFortunes => new(
    "Armour of Fortunes",
    "This armour's gleaming metal plates magically reflect all the battles in which it has been worn in a rainbow array of never-ending carnage and war.",
    "The armour absorbs and stores damage. Once worn it cannot be removed for the rest of the adventure. It can absorb 30 Wounds, after which it explodes, taking the Warrior down to zero wounds (unless a potion or spell intervenes).",
    treasureTableDiceResult: "64",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Armour],
    costSell: 500,
    imagePath: "images/equipment/ArmourOfFortune.png",
    inventorySlot: InventorySlot.Torso
);

    public static MagicItemData UndeadBane => new(
        "Undead Bane",
        "This sword was forged in the time of Nagash, the Liche-king, and is a powerful weapon against his undead hordes.",
        "While your Warrior is using this sword each Attack he makes against undead Monsters causes an extra 1D6 Wounds.",
        treasureTableDiceResult: "65",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/UndeadBane.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData UndeadBaneBlade => new(
    "Undead Bane Blade",
    "This sword was forged in the time of Nagash, the Liche-king, and is a powerful weapon against his undead hordes.",
    "While your Warrior is using this sword each Attack he makes against undead Monsters causes an extra 1D6 Wounds.",
    treasureTableDiceResult: "66",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Item],
    costSell: 200,
    imagePath: "images/equipment/UndeadBane.png",
    inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData? GetMagicWeaponsAndSwordsByName(string name)
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