using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems;

public static class MagicItemLibrary
{
    public static MagicItemData HandOfDeathScroll => new(
        "Hand of Death Scroll",
        "A dusty scroll that contains a powerful incantation to drain the life out of a single target.",
        "The Hand of Death scroll contains a spell that may be cast against a single monster, and causes 3D6 wounds with no modifier for armour. The spell costs no power to cast.",
        treasureTableDiceResult: "10",
        ruleUsages: [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/HandOfDeathScroll.png"
    );

    public static MagicItemData DispelMagicScroll => new(
        "Dispel Magic Scroll",
        "The parchment of this scroll is crumbling with age, the faint sigils and runes now barely readable.",
        "This scroll allows the Wizard to render harmless a single spell cast against himself or his companions, whatever its source. The scroll may only be used by a Wizard.",
        treasureTableDiceResult: "11",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 150,
        imagePath: "images/equipment/DispelMagicScroll.png"
    );

    public static MagicItemData EnergyJewel => new(
        "Energy Jewel",
        "This glowing jewel, set in a silver clasp, stores powerful magic.",
        "This jewel contains 1D6 points of Power that the Wizard can use to augment his spellcasting ability. Once drained the jewel is useless and worthless.",
        treasureTableDiceResult: "12",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/EnergyJewel.png"
    );

    public static MagicItemData AmuletOfFury => new(
        "Amulet of Fury",
        "At the heart of this crystal amulet a golden, magical fire rages.",
        "The Amulet of Fury allows a Warrior who is otherwise nonmagical to cast a spell. The bearer may attempt to cast the spell once per turn, rolling equal to or over its casting number on 1D6 to succeed. After successful use, the amulet disintegrates into powder.",
        treasureTableDiceResult: "13",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All }, // BDEW
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/AmuletOfFury.png"
    );

    public static MagicItemData ArrowOfSlaying => new(
        "Arrow of Slaying",
        "A thick black light drips from the end of this arrow, consuming nearby energy and chilling the air.",
        "The magical venom can fell even the toughest monster. If your Warrior hits a Monster, roll 1D6. On 1-3 normal damage, 4-6 Monster is immediately slain. Use once, then discard.",
        treasureTableDiceResult: "14",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.E }, // B and E
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/equipment/ArrowOfSlaying.png"
    );

    public static MagicItemData CrownOfNight => new(
        "Crown of Night",
        "This jet black crown is fashioned from bands of iron and engraved with powerful runes.",
        "While wearing this crown your Warrior may attempt to resist any one spell cast against him per turn. Roll 1D6. On 1-5 fails, on 6 it works.",
        treasureTableDiceResult: "15",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 300,
        imagePath: "images/equipment/CrownOfNight.png"
    );

    public static MagicItemData TalismanOfJet => new(
        "Talisman of Jet",
        "This glittering black jewel feels warm to the touch and pulses when picked up.",
        "This talisman allows a Wizard to exchange spells at the start of the game. Roll 1D6 to see if exchange succeeds. Once drained it is useless.",
        treasureTableDiceResult: "16",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 600,
        imagePath: "images/equipment/TalismanOfJet.png"
    );

    public static MagicItemData SpellRing => new(
        "Spell Ring",
        "Any Wizard recognises this as a potent magical ring, capable of storing magical knowledge.",
        "Take one Spell card at random: this is the stored spell. May cast it automatically at any time. After use, drained until start of next dungeon. One use per adventure.",
        treasureTableDiceResult: "21",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All }, // BDEW
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/equipment/SpellRing.png"
    );

    public static MagicItemData DestroyMagicScroll => new(
        "Destroy Magic Scroll",
        "This piece of crisp white parchment rustles and crackles as it is handled.",
        "Allows the Wizard to automatically dispel and destroy any one spell cast against him or companions. One use, then discard.",
        treasureTableDiceResult: "22",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 350,
        imagePath: "images/equipment/DestroyMagicScroll.png"
    );

    public static MagicItemData CloakOfInvisibility => new(
        "Cloak of Invisibility",
        "This cloak catches the light in a very strange manner, becoming transparent in places.",
        "While wearing this cloak your Warrior becomes invisible and cannot be attacked. One turn per adventure.",
        treasureTableDiceResult: "23",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All }, // BDEW
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/CloakOfInvisibility.png"
    );

    public static MagicItemData ArrowsOfPiercing => new(
    "Arrows of Piercing",
    "These white arrows have magically sharpened tips and are reputed to be able to pierce the toughest armour or hide at a thousand paces.",
    "Each time your Warrior successfully hits his target with one of these arrows, roll an additional D6. On 1-4 no additional effect, on 5-6 the arrow pierces armour. Enough arrows for one adventure.",
    treasureTableDiceResult: "24",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W }, // BEW
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Item],
    costSell: 300,
    imagePath: "images/equipment/ArrowsOfPiercing.png"
);

    public static MagicItemData RingOfDadaan => new(
        "The Ring of Dadaan",
        "This ring feels unusually heavy for its size and crackles with power.",
        "Allows a Warrior to cast a spell once per adventure. Take a Spell card at random. After use, ring is drained and becomes worthless.",
        treasureTableDiceResult: "25",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/RingOfDadaan.png"
    );

    public static MagicItemData BootsOfLeaping => new(
        "Boots of Leaping",
        "These boots are fashioned from the tough leather of a Wyvern's wings.",
        "Allows a Warrior to leap 1 square in any direction as part of movement. Obstacles in the square being leaped are ignored. Once per turn.",
        treasureTableDiceResult: "26",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 400,
        imagePath: "images/equipment/BootsOfLeaping.png"
    );

    public static MagicItemData BootsOfSwiftness => new(
        "Boots of Swiftness",
        "As soon as these boots are put on the rest of the world seems to slow down.",
        "While wearing these boots your Warrior gets +1 Movement.",
        treasureTableDiceResult: "31",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/BootsOfSwiftness.png"
    );

    public static MagicItemData BootsOfFlight => new(
        "Boots of Flight",
        "These elegant boots float an inch or so off the ground, their outline shimmering with magical energy.",
        "While wearing these boots, your Warrior may levitate a few inches above the ground while moving. Pass over chasms, pits, etc. Lasts one adventure, then discard.",
        treasureTableDiceResult: "32",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 750,
        imagePath: "images/equipment/BootsOfFlight.png"
    );

    public static MagicItemData BootsOfBattle => new(
        "Boots of Battle",
        "These sturdy iron-shod boots are magically made to be an exact fit for whoever wears them.",
        "While wearing these boots your Warrior gets an extra kick attack at -1 to hit and +1 Strength.",
        treasureTableDiceResult: "33",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 250,
        imagePath: "images/equipment/BootsOfBattle.png"
    );

    public static MagicItemData PotionOfFlight => new(
        "Potion of Flight",
        "The contents of this bottle bubble and hiss as they are drunk, burning the throat and searing the tongue.",
        "After drinking this potion, your Warrior levitates a few inches above the ground while moving. Pass over chasms, pits, etc. Lasts one turn.",
        treasureTableDiceResult: "34",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 250,
        imagePath: "images/equipment/PotionOfFlight.png"
    );

    public static MagicItemData PotionOfHealing => new(
        "Potion of Healing",
        "This green bottle contains a sweet-smelling liquid with a treacly consistency.",
        "Upon drinking this potion your Warrior regains 1D6 Wounds.",
        treasureTableDiceResult: "35",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/PotionOfHealing.png"
    );

    public static MagicItemData PotionOfInvisibility => new(
        "Potion of Invisibility",
        "This vial contains a multi-coloured liquid that swirls sluggishly and gives off heady vapours.",
        "After drinking this potion your Warrior becomes invisible and may not be attacked. Cannot cast spells if he has that ability. Lasts one turn.",
        treasureTableDiceResult: "36",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/PotionOfInvisibility.png"
    );

    public static MagicItemData PotionOfStrength => new(
    "Potion of Strength",
    "An intoxicating liquid flows from this bottle, bringing a sense of power and might to whoever drinks it.",
    "After drinking this potion your Warrior gets +1D6 Strength. Lasts for one turn.",
    treasureTableDiceResult: "41",
    ruleUsages: [RuleUsage.None],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.DungeonTreasureMagicItems],
    magicItemType: [MagicItemType.Item],
    costSell: 100,
    imagePath: "images/equipment/PotionOfStrength.png"
);

    public static MagicItemData PotionOfDisguise => new(
        "Potion of Disguise",
        "This black liquid has no taste and leaves no trace of moisture on the lips.",
        "After drinking this potion your Warrior will not be attacked or pinned as long as he does not initiate combat. Lasts for one turn.",
        treasureTableDiceResult: "42",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/equipment/PotionOfDisguise.png"
    );

    public static MagicItemData PotionOfWaterWalking => new(
        "Potion of Water Walking",
        "This effervescent liquid has a salty tang reminiscent of the sea.",
        "After drinking this potion your Warrior can walk over areas of water at 3x his normal Movement. Lasts for one turn.",
        treasureTableDiceResult: "43",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/equipment/PotionOfWaterWalking.png"
    );

    public static MagicItemData PotionOfToughness => new(
        "Potion of Toughness",
        "Upon drinking this red-flecked liquid you feel your muscles bulge and your sinews toughen.",
        "After drinking this potion your Warrior gets +3 Toughness. Lasts for one turn.",
        treasureTableDiceResult: "44",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/equipment/PotionOfToughness.png"
    );

    public static MagicItemData ProtectionRing => new(
        "Protection Ring",
        "The image of a shield is engraved on the uppermost surface of this small ring.",
        "While wearing this ring your Warrior gets +1 Toughness.",
        treasureTableDiceResult: "45",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 300,
        imagePath: "images/equipment/ProtectionRing.png"
    );

    public static MagicItemData RingOfInvisibility => new(
        "Ring of Invisibility",
        "As soon as you slip this ring onto your finger you fade from sight.",
        "While wearing this ring your Warrior is invisible. One use per adventure, lasts one turn.",
        treasureTableDiceResult: "46",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/RingOfInvisibility.png"
    );

    public static MagicItemData RingOfPower => new(
        "Ring of Power",
        "This simple band of stone slips easily onto your finger, contracting until it is a perfect fit.",
        "While wearing this ring one of your Warrior’s characteristics is increased by +1. Choose the characteristic the first time it is worn.",
        treasureTableDiceResult: "51",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/equipment/RingOfPower.png"
    );

    public static MagicItemData ArkaiPowder => new(
        "Arkai's Powder",
        "This silver dust swirls in its casket as if shifted by an unseen finger.",
        "After consuming this powder, your Warrior may immediately move another 3D6 squares, ignoring pinning. Use once, then discard.",
        treasureTableDiceResult: "52",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/equipment/ArkaiPowder.png"
    );

    public static MagicItemData CharmOfLearning => new(
        "Charm of Learning",
        "As soon as you put on this charm the world seems to have a clearer definition and edge...",
        "This charm allows your Warrior to assimilate the knowledge required for training quickly, costing 300 less gold to train to the next Battle-level. Use once, then discard.",
        treasureTableDiceResult: "53",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 100,
        imagePath: "images/equipment/CharmOfLearning.png"
    );

    public static MagicItemData RingOfSureSeeing => new(
        "Ring of Sure Seeing",
        "This ring has a large gem set in its surface that, in times of danger, shows a picture of what is to come.",
        "Allows re-roll of any single Hazard or Settlement Event roll. Use once, then discard.",
        treasureTableDiceResult: "54",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/RingOfSureSeeing.png"
    );

    public static MagicItemData GemsOfLife => new(
        "Gems of Life",
        "These small gems sparkle with a strange, otherworldly energy.",
        "These gems come as a pair. If the wearer is killed, their body shrinks into a pinprick of light contained within the gem. Use once, then discard.",
        treasureTableDiceResult: "55",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 700,
        imagePath: "images/equipment/GemsOfLife.png"
    );

    public static MagicItemData BraceletOfTransformation => new(
        "Bracelet of Transformation",
        "This plain bronze bracelet has a single rune embossed on its surface.",
        "Allows your Warrior to take on appearance of any other creature. Lasts until combat. One use per adventure.",
        treasureTableDiceResult: "56",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 350,
        imagePath: "images/equipment/BraceletOfTransformation.png"
    );

    public static MagicItemData Lifestone => new(
        "Lifestone",
        "The Lifestone has the power to drain the life energy from the surrounding area and transfer it to its wearer.",
        "Swap Wounds with another Warrior once per adventure. Cannot exceed Starting Wounds.",
        treasureTableDiceResult: "61",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/equipment/Lifestone.png"
    );

    public static MagicItemData BraceletOfAshain => new(
        "Bracelet of Ashain",
        "This slim golden band fits comfortably around the wearer's forearm, even on top of armour.",
        "While wearing this bracelet your Warrior gets +3 Starting Wounds.",
        treasureTableDiceResult: "62",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 350,
        imagePath: "images/equipment/BraceletOfAshain.png"
    );

    public static MagicItemData CircletOfWrath => new(
        "Circlet of Wrath",
        "This band of silvered, luminescent metal, worn around the forehead, glistens and gleams with an unnatural light.",
        "Enter a blood rage: D6 roll 2+ double Attacks. 1 double Attacks but must move toward nearest Warrior. Cannot be pinned. One use per adventure, lasts one turn.",
        treasureTableDiceResult: "63",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 400,
        imagePath: "images/equipment/CircletOfWrath.png"
    );

    public static MagicItemData BeltOfGagron => new(
        "Belt of Gagron",
        "This thick leather belt belonged to the Dwarf Gagron the Giantslayer.",
        "If reduced to 0 Wounds, roll 1D6: 1-2 no effect, 3-5 restore 1D6, 6 restore 2D6 Wounds. Cannot be removed.",
        treasureTableDiceResult: "64",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/equipment/BeltOfGagron.png"
    );

    public static MagicItemData StoneOfTransmutation => new(
        "Stone of Transmutation",
        "This small, plain stone hangs from a delicate copper chain.",
        "Transmute a Monster into stone. Roll 1D6 + Battle-level > Monster Wounds to succeed. Use once, then discard.",
        treasureTableDiceResult: "65",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 200,
        imagePath: "images/equipment/StoneOfTransmutation.png"
    );

    public static MagicItemData GauntletOfDamzhar => new(
        "Gauntlet of Damzhar",
        "This thick iron gauntlet is covered with studs in the shape of Dwarf runes.",
        "Gives +1 Attack at -1 to hit and +1 Strength. Wearing two gives additional +1 Attack (total +3), +1 to hit, 4D6 damage.",
        treasureTableDiceResult: "66",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicItems],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/equipment/GauntletOfDamzhar.png"
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
