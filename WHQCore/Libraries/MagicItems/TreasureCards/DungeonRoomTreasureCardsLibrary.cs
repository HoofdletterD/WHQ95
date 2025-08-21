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
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
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
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
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
        treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
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
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
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
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
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
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
    magicItemType: [MagicItemType.Boots],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/MoradrielsBoots.png",
    inventorySlot: InventorySlot.Pouch
);
    public static MagicItemData ReaperSword => new(
    "ReaperSword",
    "This mighty sword is sharper than a razor. Its keen blade glistens in the light of the lantern, and even in the shadows it shimmers with an eerie inner light.",
    "While your warrior is using this sword he gets +2 Strength.",
    treasureTableDiceResult: "121",
    ruleUsages: [RuleUsage.Permanent],
    new List<HeroCode> { HeroCode.B },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
    magicItemType: [MagicItemType.Weapon],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/ReaperSword.png",
    inventorySlot: InventorySlot.MainHand
);
    public static MagicItemData Soulstone => new(
    "Soulstone",
    "The soulstone captures the departing soul of the bearer, should he be slain. Someone with the correct knowledge can then restore the soul to its body, resurrecting the unfortunate person.",
    "If the warrior with the soulstone is killed, by whatever means, he can be resurrected once the adventure is over. He loses any gold and treasure he may have accumulated during that adventure and is unchanged from the warrior he was when he set off down the dungeon.",
    treasureTableDiceResult: "122",
    ruleUsages: [RuleUsage.OneUseOnly],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
    magicItemType: [MagicItemType.Item],
    costSell: 400,
    imagePath: "images/magicitems/treasurecards/Soulstone.png",
    inventorySlot: InventorySlot.Pouch
);

    public static MagicItemData AmuletOfPower => new(
name: "Amulet Of Power",
flavor: "This ornate amulet throbs dully and a thick, black liquid apears to flow within its core.",
rules: "At the start of each of your warrior's phase, you may roll a D6. On a 2 to 6, your warrior's strength is increased by +2 for the rest of the turn. On a 1, the amulet explodes causing 1D6 wounds with no modifiers for toughness or armour. Use until destroyed, then discard.",
treasureTableDiceResult: "123",
ruleUsages: [RuleUsage.DiscardAfterUse],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Amulet],
costSell: 350,
imagePath: "images/magicitems/treasurecards/AmuletOfPower.png",
inventorySlot: InventorySlot.Neck
);

    public static MagicItemData ArrowsOfDeath => new(
name: "Arrows of Death",
flavor: "You find a pouch containing a number of jet-black arrows. Their shafts are encrusted with golden runes and their tips glow with a pale green light.",
rules: "These enchanted arrows are magically sharpened. While using the arrows of Death, your warrior inflicts +3 wounds on his opponent with his missile attacks. The arrows of Death can only be used by a warrior with a bow equipped. 1D6 arrows; 1 use each. Each arrow has 100g value.",
treasureTableDiceResult: "124",
ruleUsages: [RuleUsage.DiscardAfterUse],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Item],
costSell: 100,
imagePath: "images/magicitems/treasurecards/xxx.png",
inventorySlot: InventorySlot.Pouch
);

    public static MagicItemData ChaliceOfFate => new(
name: "Chalice of Fate",
flavor: "The chalice of fate has the power to warp time, to change fate and alter reality.",
rules: "The chalice allows you to re-roll when determening the wizard's power during the power phase. You may only re-roll once, and you must accept the second roll, even if the score is worse.",
treasureTableDiceResult: "125",
ruleUsages: [RuleUsage.OncePerDungeon],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Item],
costSell: 200,
imagePath: "images/magicitems/treasurecards/ChaliceOfFate.png",
inventorySlot: InventorySlot.Pouch
);

    public static MagicItemData Deathstone => new(
name: "Deathstone",
flavor: "The Deathstone is a small black crystal that seems to soak up the light from the lantern, converting it into raw power.",
rules: "The Deathstone acts as a source of power for the wizard. When casting a spell, he may use the deathstone to increase his chance of success. Roll 1D6. On a 3 to 6, the spell may be cast at a cost of zero Power instead of its normal cost. On a 1 or 2, the spell fails and the wizards power for that turn is lost.",
treasureTableDiceResult: "126",
ruleUsages: [RuleUsage.OneUseOnly],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Item],
costSell: 150,
imagePath: "images/magicitems/treasurecards/Deathstone.png",
inventorySlot: InventorySlot.Pouch
);

    public static MagicItemData DragonShield => new(
name: "Dragon Shield",
flavor: "This shield is fashioned from the deep-red, sulphorous scales of a great fire dragon.",
rules: "While wearing the Dragon Shield, your warrior is invulnerable to any one, single attack, whatever its origin.",
treasureTableDiceResult: "131",
ruleUsages: [RuleUsage.OneUseOnly],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Armour],
costSell: 300,
imagePath: "images/magicitems/treasurecards/Dragonshield.png",
inventorySlot: InventorySlot.OffHand
);

    public static MagicItemData EnchantedShield => new(
name: "Enchanted Shield",
flavor: "The surface of this shield gleams as brightly as a mirror. Clouds roll across its surface, and shards of light cut the air around it as you move.",
rules: "Each time your warrior is hit, he may use this shield to try and absorb the blow. Roll 1D6. On a 5 or 6, the shield absords all the damage. On a 1, the shield explodes, and your warrior takes 1D6 wounds with no modifiers for toughness or armour.",
treasureTableDiceResult: "132",
ruleUsages: [RuleUsage.OneUseOnly],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Armour],
costSell: 300,
imagePath: "images/magicitems/treasurecards/EnchantedShield.png",
inventorySlot: InventorySlot.OffHand
);

    public static MagicItemData FingerOfDoomScroll => new(
name: "Finger of Doom scroll",
flavor: "It's a dusty scroll, on which magical sigils are traced in a spidery scrawl.",
rules: "Maybe used by the wizard as any other spell with a casting number of 6. When cast, the finger of doom inflicts 6 wounds on asingle monster with no modifiers for toughness or armor.",
treasureTableDiceResult: "133",
ruleUsages: [RuleUsage.OneUseOnly],
new List<HeroCode> { HeroCode.W },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Item],
costSell: 450,
imagePath: "images/magicitems/treasurecards/FingerOfDoomScroll.png",
inventorySlot: InventorySlot.OffHand
);

    public static MagicItemData xxx => new(
name: "xxx",
flavor: "",
rules: "",
treasureTableDiceResult: "118",
ruleUsages: [RuleUsage.OneUseOnly],
new List<HeroCode> { HeroCode.All },
treasureType: [TreasureType.CoreSetTreasureCard],
magicItemType: [MagicItemType.Item],
costSell: 400,
imagePath: "images/magicitems/treasurecards/xxx.png",
inventorySlot: InventorySlot.Pouch
);

    public static MagicItemData AmuletOfCharadris => new(
    "Amulet of Charadris",
    "Charadris was a Priest of Sigmar who abhorred magic in all its forms, believing that his faith in Sigmar was the greatest power of all.",
    "Any Undead Monster with the Regenerate ability standing next to the Warrior may only regenerate half the number of wounds they normally do (rounding fractions down).",
    treasureTableDiceResult: "611",
    ruleUsages: null,
    new List<HeroCode> { HeroCode.All }, // all warriors
    treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
    magicItemType: new[] { MagicItemType.Item },
    costSell: 300,
    imagePath: "images/CatacombsOfTerrorTreasureCard/AmuletOfCharadris.png",
    inventorySlot: InventorySlot.Neck
);

    public static MagicItemData AxeOfKhemri => new(
        "Axe of Khemri",
        "This magic axe was forged many centuries ago by the Priest Kings of the ancient realm of Khemri. It is a mighty weapon with a pure white blade. When their kingdom fell, the axe was lost, presumed destroyed.",
        "The axe confers the same Strength bonus as the axe carried by the Dwarf and follows the same rules (roll an extra dice for wounds, and choose the highest score). In addition, when used against Undead, the wielder gains +1 to hit. (RPG – the abilities of this axe cannot be added to in any way, such as runes, etc.)",
        treasureTableDiceResult: "612",
        ruleUsages: [RuleUsage.UnlimitedUses],
        new List<HeroCode> { HeroCode.All }, // all warriors
        treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 300,
        imagePath: "images/CatacombsOfTerrorTreasureCard/AxeOfKhemri.png",
        inventorySlot: InventorySlot.MainHand
    );

        public static MagicItemData BlessedGem => new(
            "Blessed Gem",
            "This huge ruby has been empowered with warding spells engraved into it by the wizards of the Empire.",
            "The ruby can be used to dispel a Necromantic spell. When the spell is cast, roll a dice. On a roll of 4+, the spell has no effect. Wizards only.",
            treasureTableDiceResult: "613",
            ruleUsages: [RuleUsage.UnlimitedUses],
            new List<HeroCode> { HeroCode.W },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 350,
            imagePath: "images/CatacombsOfTerrorTreasureCard/BlessedGem.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData ChaliceOfVigour => new(
            "Chalice of Vigour",
            "This chalice is one of the legendary artifacts created by the Priest King Alcadizzar. Much sought after by Witch Hunters, the chalice is filled with a golden liquid which never dims or dries up.",
            "Once per adventure, the Warriors may inhale the pungent vapours that rise from the bubbling golden liquid. For the duration of the next combat, on a roll of a 6 to hit, the Warriors will cause an extra 1D3 Wounds against their enemies. Use once per adventure.",
            treasureTableDiceResult: "614",
            ruleUsages: [RuleUsage.OncePerDungeon],
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 300,
            imagePath: "images/CatacombsOfTerrorTreasureCard/ChaliceOfVigour.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData HelmOfAlcadizzar => new(
            "Helm of Alcadizzar",
            "This glittering helmet was worn by Alcadizzar as he rode into battle against the Undead hordes. It is said that the helm had the magical ability to store the light of the sun, and the Undead would flee in terror from the blazing figure of Alcadizzar as he galloped across the battlefield.",
            "The helm illuminates the dungeon just like the lantern. It adds +1 to the wearer's Toughness, and any Undead are at -1 to hit the wearer.",
            treasureTableDiceResult: "615",
            ruleUsages: null,
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Armour },
            costSell: 450,
            imagePath: "images/CatacombsOfTerrorTreasureCard/HelmOfAlcadizzar.png",
            inventorySlot: InventorySlot.Head
        );

        public static MagicItemData TheKingshieldOfTilea => new(
            "The Kingshield of Tilea",
            "King Esteban of Estalia won a famous battle against the Undead of Lahmia, and attributed his legendary invulnerability to the shield he bore. Its past is shrouded in mystery, but the kings of Tilea have always carried it into battle.",
            "The shield adds +1 to the wearer's Toughness, and once per adventure will negate the effect of a single attack or spell that would otherwise wound the bearer.",
            treasureTableDiceResult: "616",
            ruleUsages: [RuleUsage.UnlimitedUses],
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Armour },
            costSell: 200,
            imagePath: "images/CatacombsOfTerrorTreasureCard/TheKingshieldOfTilea.png",
            inventorySlot: InventorySlot.OffHand
        );

        public static MagicItemData OrbOfSigmar => new(
            "Orb of Sigmar",
            "The Grand Theologist Wilhelm used this sparkling orb in his battle against the Vampire Count Vlad von Carstein.",
            "When the power of the Orb is invoked, no Necromantic magic may be used by any model on the same board section for the next 1D6 turns. Use once per adventure.",
            treasureTableDiceResult: "621",
            ruleUsages: [RuleUsage.OncePerDungeon],
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 400,
            imagePath: "images/CatacombsOfTerrorTreasureCard/OrbOfSigmar.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData SilverStone => new(
            "Silver Stone",
            "The Silver Stone imbues a weapon it touches with magical powers.",
            "The stone may be used once to permanently enchant a single weapon. The affected weapon is now magical and causes an extra D6 wounds on a to hit roll of a 6. Use once and discard.",
            treasureTableDiceResult: "622",
            ruleUsages: [RuleUsage.OneUseOnly],
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 200,
            imagePath: "images/CatacombsOfTerrorTreasureCard/SilverStone.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData StoneIconOfGhamaluk => new(
            "Stone Icon of Ghamaluk",
            "Ghamaluk was a grand vizier of Araby, and created a series of stone icons specifically to combat the Undead hordes amassed against him. Many of these icons have passed into the hands of the famous Witch Hunter Gunter Grafftag of Sylvania.",
            "This icon has the power to heal the bearer back to his starting wounds once per adventure. Use once per adventure.",
            treasureTableDiceResult: "623",
            ruleUsages: [RuleUsage.OncePerDungeon],
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 200,
            imagePath: "images/CatacombsOfTerrorTreasureCard/StoneIconOfGhamaluk.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData TalismanOfAlcadizar => new(
            "Talisman of Alcadizar",
            "This talisman protected a great Priest King against the decaying magic of the evil Liche Lord Nagash himself.",
            "Any Warrior bearing this talisman is immune to the effects of a Necromantic spell on a dice roll of 5+ per spell. Other Warriors are affected as normal.",
            treasureTableDiceResult: "624",
            ruleUsages: [RuleUsage.Permanent],
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CatacombsOfTerrorTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 500,
            imagePath: "images/CatacombsOfTerrorTreasureCard/TalismanOfAlcadizar.png",
            inventorySlot: InventorySlot.Neck
        );

        public static MagicItemData Dummy => new(
            name: "xxx",
            flavor: "",
            rules: "",
            treasureTableDiceResult: "118",
            ruleUsages: [RuleUsage.OneUseOnly],
            new List<HeroCode> { HeroCode.All },
            treasureType: [TreasureType.CoreSetTreasureCard],
            magicItemType: [MagicItemType.Item],
            costSell: 400,
            imagePath: "images/magicitems/treasurecards/xxx.png",
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

