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

        public static MagicItemData Firebomb => new(
            "Firebomb",
            "On a dirt-encrusted shelf you find a large ball with a fuse in the top. From the rune inscribed on it, and its pungent smell, you realise it is a firebomb.",
            "The firebomb may be thrown at any time and affects a 2 squares by 2 squares area. Any model in the area takes 1D6 wounds with no deduction for toughness or armour.",
            treasureTableDiceResult: "135",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Weapon },
            costSell: 0,
            imagePath: "images/CoreSetTreasureCard/Firebomb.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData FlashPowder => new(
            "Flash Powder",
            "Hidden in a small alcove in the wall, overgrown by moss, you find a small bag of flash powder.",
            "The flash powder may be set off at any time to confuse the Warrior's enemies. After it has exploded, any Warriors who have not yet fought this turn get +1 Attack. Use once, then discard.",
            treasureTableDiceResult: "136",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 75,
            imagePath: "images/CoreSetTreasureCard/FlashPowder.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData FurCloak => new(
            "Fur Cloak",
            "You find a thick fur cloak. Rolled up and placed over one arm it offers some protection in place of a shield.",
            "The cloak acts as armour and provides a +1 modifier to your Warrior's Toughness. Each time it is used, roll 1D6. On a 4, 5 or 6 it remains effective and can be used again.",
            treasureTableDiceResult: "141",
            ruleUsages: new[] { RuleUsage.Reusable },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Armour },
            costSell: 75,
            imagePath: "images/CoreSetTreasureCard/FurCloak.png",
            inventorySlot: InventorySlot.Back
        );

        public static MagicItemData HealingSalve => new(
            "Healing Salve",
            "Amongst the debris in the room you find a black bottle containing a thick, yellow paste. It is a salve of healing.",
            "The healing salve can restore 2D6 Wounds to any single Warrior, or 1D6 Wounds on each of 2 different Warriors. Use once, then discard.",
            treasureTableDiceResult: "142",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 100,
            imagePath: "images/CoreSetTreasureCard/HealingSalve.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData HellMace => new(
            "Hell Mace",
            "Sparks fly from the iron-shod head of this mace as you wield it, bathing the area in light.",
            "While using the Hell Mace your Warrior gets +2 Attacks. Use once per adventure.",
            treasureTableDiceResult: "143",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Weapon },
            costSell: 250,
            imagePath: "images/CoreSetTreasureCard/HellMace.png",
            inventorySlot: InventorySlot.MainHand
        );

        public static MagicItemData IncenseOfHealing => new(
            "Incense of Healing",
            "When opened, the urn discharges a fragrant cloud of vapour that acts as a healing potion.",
            "Every Warrior on the same board section as the urn has 2D6 Wounds restored. Use once, then discard.",
            treasureTableDiceResult: "144",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 200,
            imagePath: "images/CoreSetTreasureCard/IncenseOfHealing.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData InvisibilityRing => new(
            "Invisibility Ring",
            "As you slip this ring onto your finger, you fade and vanish from sight.",
            "While wearing the Invisibility Ring your Warrior cannot be attacked. The ring contains enough power to keep your Warrior invisible for one turn. Use once per adventure.",
            treasureTableDiceResult: "145",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 175,
            imagePath: "images/CoreSetTreasureCard/InvisibilityRing.png",
            inventorySlot: InventorySlot.Fingers
        );

        public static MagicItemData LightningFireRing => new(
            "Lightning Fire Ring",
            "As you put it on, this ring shrinks to fit tightly around your finger, and a lightning rune starts to glow coldly on its upper surface.",
            "The Lightning Fire Ring can fire a bolt of lightning on command. Your Warrior may target any Monster that is in his line of sight. The bolt hits automatically and inflicts 5D6 Wounds, with no modifiers for armour. Use once per adventure.",
            treasureTableDiceResult: "146",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 500,
            imagePath: "images/CoreSetTreasureCard/LightningFireRing.png",
            inventorySlot: InventorySlot.Fingers
        );

        public static MagicItemData LuckyTalisman => new(
            "Lucky Talisman",
            "In the middle of a pile of rubbish in one corner of the room, you find a Lucky Talisman on a fine chain.",
            "Your Warrior may use the Lucky Talisman at any time. Any attack made while using the Lucky Talisman will automatically hit. Use once per adventure.",
            treasureTableDiceResult: "151",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 150,
            imagePath: "images/CoreSetTreasureCard/LuckyTalisman.png",
            inventorySlot: InventorySlot.Neck
        );

        public static MagicItemData MagicPotion => new(
            "Magic Potion",
            "This small glass bottle bears strange inscriptions in some long-forgotten magical language.",
            "When your Warrior drinks the Magic Potion, roll 1D6 to determine what it is:\n1: Poison – lose 2D6 Wounds.\n2: Poison – lose 1D6 Wounds.\n3: Rainbow Potion – your Warrior's flesh becomes rainbow striped.\n4: Healing Potion – cures 1D6 of your Warrior's Wounds.\n5: Healing Potion – cures 2D6 of your Warrior's Wounds.\n6: Healing Potion – restores your Warrior to full Wounds. Use once, then discard.",
            treasureTableDiceResult: "152",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 60,
            imagePath: "images/CoreSetTreasureCard/MagicPotion.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData OrbOfMight => new(
            "Orb of Might",
            "This black orb glistens dully as you pick it up.",
            "The Orb of Might is a source of Power for the Wizard. Roll 1D6 to determine how much Power is initially stored in it. Once the Wizard has used 1 or more points of the stored Power, place a D6 on top of this card to show the remaining points. Worth 50 Gold per unused Power Point. Use until empty, then discard.",
            treasureTableDiceResult: "153",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.W },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 50,
            imagePath: "images/CoreSetTreasureCard/OrbOfMight.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData QuakeScroll => new(
            "Quake Scroll",
            "This dusty scroll is inscribed with magic runes and sigils that contain words of power.",
            "This scroll can be used at any time, and causes a 2 square by 2 square area of any one board section to cave in. Use the Cave-in marker to mark the area affected. Any Warrior or Monster caught in the area suffers 2D6 damage. Use once, then discard.",
            treasureTableDiceResult: "154",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 200,
            imagePath: "images/CoreSetTreasureCard/QuakeScroll.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData ShieldOfDeliverance => new(
            "Shield of Deliverance",
            "This shield is of simple yet exquisite craftsmanship. It seems to be made of a substance stronger than steel, yet weighs little more than a sheet of parchment.",
            "The Shield of Deliverance can completely absorb the damage from any two blows. The first time the shield is hit, flip this card over; when it is hit a second time, discard this card. Use once, then discard.",
            treasureTableDiceResult: "155",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Armour },
            costSell: 500,
            imagePath: "images/CoreSetTreasureCard/ShieldOfDeliverance.png",
            inventorySlot: InventorySlot.OffHand
        );

        public static MagicItemData Spear => new(
            "Spear",
            "Leaning against a wall, you find a hefty-looking spear with a wickedly sharp head.",
            "The spear may be used at any time. To make the attack, roll 1D6. On a 3, 4, 5 or 6 your Warrior has hit the target and inflicted 3D6 Wounds. On a 1 or 2 he has missed. Use once per adventure.",
            treasureTableDiceResult: "156",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Weapon },
            costSell: 100,
            imagePath: "images/CoreSetTreasureCard/Spear.png",
            inventorySlot: InventorySlot.TwoHanded
        );

        public static MagicItemData TalonOfDeath => new(
            "Talon of Death",
            "This magical artifact sucks all of the light from the surrounding area, creating an aura of darkness around you.",
            "Once your Warrior has finished moving, he may use the Talon of Death to cause 1D6 Wounds against every Monster adjacent to him, with no modifiers for Toughness or armour. Roll for each Monster separately. Use once per adventure.",
            treasureTableDiceResult: "161",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 500,
            imagePath: "images/CoreSetTreasureCard/TalonOfDeath.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData TimeFreezingRing => new(
            "Time Freezing Ring",
            "As you put it on, this ring freezes like ice and bursts into a cold blue flame, yet still feels comfortable to wear.",
            "The Time Freezing Ring allows your Warrior to immediately take an extra Phase straight away. Use once per adventure.",
            treasureTableDiceResult: "162",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.CoreSetTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 200,
            imagePath: "images/CoreSetTreasureCard/TimeFreezingRing.png",
            inventorySlot: InventorySlot.Fingers
        );

        public static MagicItemData BorgratsCrown => new(
            "Borgrat's Crown",
            "The Warriors find a grubby looking circlet of rusted iron. Faded runes are inscribed on its pitted surface.",
            "This magical crown adds +1 to the wearer's Toughness. It can be worn at the same time as a helmet.",
            treasureTableDiceResult: "163",
            ruleUsages: new[] { RuleUsage.Permanent },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Armour },
            costSell: 500,
            imagePath: "images/LairOfTheOrcLordTreasureCard/BorgratsCrown.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData FungusBrew => new(
            "Fungus Brew",
            "The Warriors find a flask of the potion that turns Night Goblins into gibbering Fanatics.",
            "There is enough liquid in the flask for four doses. A Warrior can take a drink at any time during combat. Roll on the table below to see what happens:\n\n1–2: The brew makes the Warrior hallucinate! He immediately makes an attack against every model adjacent to him.\n3–4: The brew cures 1D6 Wounds.\n5–6: The brew cures 1D6 Wounds and allows the Warrior to completely ignore the next hit he takes.\n\nThe brew is worth 200 gold if none of it has been drunk, or 100 gold if some of it (but not all of it) has been consumed. Discard when all drunk.",
            treasureTableDiceResult: "164",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 0,
            imagePath: "images/LairOfTheOrcLordTreasureCard/FungusBrew.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData MagicArrers => new(
            "Magic Arrers",
            "You find 6 arrows carved with strange Goblin runes.",
            "The arrows are enchanted, but are somewhat unpredictable. When you use an arrow, roll on the table below instead of rolling to hit:\n\n1: The arrow automatically hits one of the Warriors, for D6+3 Wounds (determine who randomly).\n2–5: The arrow automatically hits the Monster and does 1D6+3 Wounds.\n6: The arrow automatically hits the Monster and does 2D6+3 Wounds.\n\nEach arrow can only be used once, and used arrows are worthless. Barbarian, Elf & Wizard only. Discard when all used. Worth 40g each.",
            treasureTableDiceResult: "165",
            ruleUsages: new[] { RuleUsage.DiscardAfterUse },
            new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Weapon },
            costSell: 40,
            imagePath: "images/LairOfTheOrcLordTreasureCard/MagicArrers.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData PlergitsStabba => new(
            "Plergit's Stabba",
            "The Warriors find a wickedly sharp and very thin bladed dagger designed for slipping between armour joints.",
            "The dagger can be used to make an extra attack on a Monster. Roll a D6:\n1–3: The attack hits causing 2D6+Strength Wounds modified for Toughness but not armour.\n4–6: The attack hits causing 3D6+Strength Wounds not modified for armour or Toughness.\n\nBarbarian, Elf & Dwarf only. Use once per adventure.",
            treasureTableDiceResult: "166",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.D },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Weapon },
            costSell: 400,
            imagePath: "images/LairOfTheOrcLordTreasureCard/PlergitsStabba.png",
            inventorySlot: InventorySlot.MainHand
        );

        public static MagicItemData PrittyStonez => new(
            "Pritty Stonez",
            "The Warriors find a small drawstring bag containing some ordinary-looking stones.",
            "When your Warrior looks through the 'stones' roll on the table below:\n\n1–3: Mixed with normal stones are 1D6 gold nuggets worth 25 gold each.\n4–6: Mixed with the normal stones are 1D6 gemstones worth 100 gold each.\n\nRecord, then discard.",
            treasureTableDiceResult: "211",
            ruleUsages: new[] { RuleUsage.OneUseOnly },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 0,
            imagePath: "images/LairOfTheOrcLordTreasureCard/PrittyStonez.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData RingOfLife => new(
            "Ring of Life",
            "The Warriors find a silver, jewel-encrusted ring. Within the central gemstone, a tiny flame burns brightly.",
            "The ring has the power to heal grievous wounds. It may only be used on a Warrior on zero Wounds. To use the ring, roll a dice. On a roll of 1 the flame flickers and dies, and has no effect. On any other score, the Warrior is healed back up to full Wounds. One use per adventure.",
            treasureTableDiceResult: "212",
            ruleUsages: new[] { RuleUsage.OncePerDungeon },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 350,
            imagePath: "images/LairOfTheOrcLordTreasureCard/RingOfLife.png",
            inventorySlot: InventorySlot.Fingers
        );

        public static MagicItemData ScrollOfTheChimera => new(
            "Scroll of the Chimera",
            "The Warriors find a dusty old scroll lying in a dark corner.",
            "The spell on this scroll gives a Warrior the appearance of a ferocious monster. The scroll may be read at any time, causing any Monsters to be so terrified of the affected Warrior that they will suffer a -2 penalty on their to hit rolls against him. The spell lasts until a 1 or 2 is rolled in the Power Phase. Dwarf, Wizard & Elf only. One use, then discard.",
            treasureTableDiceResult: "213",
            ruleUsages: new[] { RuleUsage.OneUseOnly },
            new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 300,
            imagePath: "images/LairOfTheOrcLordTreasureCard/ScrollOfTheChimera.png",
            inventorySlot: InventorySlot.Pouch
        );

        public static MagicItemData HammerOfHargon => new(
            "The Hammer of Hargon",
            "You find a sturdy Dwarf warhammer with an ornate icon carved on its head. Any Dwarf in the party recognizes this as the lost Hammer of Hargon.",
            "When using this hammer, you may roll as many dice for damage as you like. Add up the total, then add your Strength to the final score. However, if any of the dice come up with a 1 or 2, the hammer causes no damage at all. Dwarf, Wizard & Barbarian only.",
            treasureTableDiceResult: "214",
            ruleUsages: new[] { RuleUsage.Permanent },
            new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.B },
            treasureType: new[] { TreasureType.LairOfTheOrcLordTreasureCard },
            magicItemType: new[] { MagicItemType.Weapon },
            costSell: 500,
            imagePath: "images/LairOfTheOrcLordTreasureCard/HammerOfHargon.png",
            inventorySlot: InventorySlot.MainHand
        );

                public static MagicItemData AncientVaseOfLustria => new(
            "Ancient Vase of Lustria",
            "Lustria is a land of the unknown, the undiscovered continent, a realm of Giants and Daemons and powers beyond all telling. This vase is of strange design, unsuitable for use by Humans, Elves or Dwarfs. Its purpose can only be guessed at, as can its age; but its beauty and value is beyond question.",
            "This vase is worth 175 gold. Record then discard.",
            treasureTableDiceResult: "215",
            ruleUsages: new[] { RuleUsage.Permanent },
            new List<HeroCode> { HeroCode.All },
            treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
            magicItemType: new[] { MagicItemType.Item },
            costSell: 175,
            imagePath: "images/TreasurePackOneDungeonRoomCard/AncientVaseOfLustria",
            inventorySlot: InventorySlot.Pouch
            );

    public static MagicItemData ArmourOfFortune => new(
        "Armour of Fortune",
        "This armour gleams in a rainbow array of never ending carnage and war.",
        "This armour can absorb Wounds inflicted on the Warrior. Initially it is discharged, with no Wounds stored. Once put on, the armour cannot be removed for the rest of the adventure. It absorbs 30 Wounds, then explodes, taking the wearer to zero Wounds (and death if no healing is possible). Lasts until it explodes!",
        treasureTableDiceResult: "216",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Armour },
        costSell: 500,
        imagePath: "images/TreasurePackOneDungeonRoomCard/ArmourOfFortune",
        inventorySlot: InventorySlot.Torso
    ); 

    public static MagicItemData ArrowOfSlaying => new(
        "Arrow of Slaying",
        "A thick black light drips from the end of this arrow, chilling the air. The magical venom of this arrow can fell even the toughest Monster.",
        "If your Warrior hits a Monster with this arrow, roll 1D6. On a score of 1, 2, or 3 the arrow does normal damage. On a score of 4, 5 or 6 the Monster is immediately slain. Use once then discard.",
        treasureTableDiceResult: "221",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 500,
        imagePath: "images/TreasurePackOneDungeonRoomCard/ArrowOfSlaying",
        inventorySlot: InventorySlot.Pouch
    );

    public static MagicItemData AxeOfSlaughter => new(
        "Axe of Slaughter",
        "This axe was forged by the Dwarf Runesmith Garven Surehammer, who honed its blade to an impossible sharpness.",
        "This axe causes 1D6 extra Wounds every time it hits.",
        treasureTableDiceResult: "222",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 200,
        imagePath: "images/TreasurePackOneDungeonRoomCard/AxeOfSlaughter",
        inventorySlot: InventorySlot.MainHand
    ); 

    public static MagicItemData BandOfMagic => new(
        "Band of Magic",
        "This slander gold band glitters with a clear light.",
        "When your Warrior finds this ring, randomly select two Attack Spells (RPG: randomly select Attack spells appropriate to the Warrior's battle-level). These two spells are stored in the magic band. Each spell may be cast once automatically, whenever the wearer wishes. When both spells have been cast, the magic of the band has been used up and it is useless and worthless. Discard after use.",
        treasureTableDiceResult: "223",
        ruleUsages: new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Ring },
        costSell: 500,
        imagePath: "images/TreasurePackOneDungeonRoomCard/BandOfMagic",
        inventorySlot: InventorySlot.Fingers
    );

    public static MagicItemData BaneScrollOfTheUndead => new(
        "Bane Scroll of the Undead",
        "The Warriors find a dusty old scroll underneath a pile of rubbish.",
        "Reading aloud the words on this scroll will kill any single Undead creature worth up to 400 gold on a dice roll of 4, 5 or 6.",
        treasureTableDiceResult: "224",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.W, HeroCode.D, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 150,
        imagePath: "images/TreasurePackOneDungeonRoomCard/BaneScrollOfTheUndead",
        inventorySlot: InventorySlot.Pouch
    );

    public static MagicItemData BladeOfSeaGold => new(
        "Blade of Sea Gold",
        "Forged from gold taken from the depths of the sea when the world was young, this blade is covered in runes so ancient and worn that they can no longer be read.",
        "While your Warrior is using this sword each attack he makes ignores the first point of his opponent's armour.",
        treasureTableDiceResult: "225",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 150,
        imagePath: "images/TreasurePackOneDungeonRoomCard/BladeOfSeaGold",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BladeOfSlicing => new(
        "Blade of Slicing",
        "This sword moans softly as it is drawn from its scabbard, in eager anticipation of the blood it is about to spill.",
        rules: "While your Warrior is using the sword he causes +2 Wounds on each successful attack.",
        treasureTableDiceResult: "226",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 300,
        imagePath: "images/TreasurePackOneDungeonRoomCard/BladeOfSlicing",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BootsOfTzchak => new(
        "Boots of Tzchak",
        "The long dead sorcerer Baalga the all-seeing created these boots to enable his long suffering henchman Tzchak to walk long distances carrying immensely heavy loads.",
        "These boots allow the Warrior to ignore any armour-based movement penalties. Furthermore, the Warrior gains +1 to his Movement.",
        treasureTableDiceResult: "231",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Boots },
        costSell: 100,
        imagePath: "images/TreasurePackOneDungeonRoomCard/BootsOfTzchak",
        inventorySlot: InventorySlot.Legs
    );

    public static MagicItemData BowOfTorAlessi => new(
        "Bow of Tor Alessi",
        "This white bow was captured by the Dwarfs at the fall of the Elf city Tor Alessi. Its accuracy is beyond compare, and it was considered a prize worthy of the bloodshed and slaughter that won it.",
        "With this bow, a Warrior may fire BEFORE or during moving. This uses up his Attacks as usual.",
        treasureTableDiceResult: "232",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 250,
        imagePath: "images/TreasurePackOneDungeonRoomCard/BowOfTorAlessi",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData CloakOfLoren => new(
    name: "Cloak of Loren",
    flavor: "This cloak is made of a fine silk-like material that, although extremely light, is very, very strong.",
    rules: "Every time your warrior is hit while wearing the cloak, he can ignore the first wound caused by the blow. However, each time the cloak absorbs damage like this, roll a D6. On the score of a 1, the cloak rips and it is useless.",
    treasureTableDiceResult: "233",
    ruleUsages: new[] { RuleUsage.DiscardAfterUse },
    new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W },
    treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
    magicItemType: new[] { MagicItemType.Armour },
    costSell: 75,
    imagePath: "images/TreasurePackOneDungeonRoomCard/CloakOfLoren.png",
    inventorySlot: InventorySlot.Back);

    public static MagicItemData CloakOfDeception => new(
        name: "Cloak of Deception",
        flavor: "This cloak swirls around the Warrior as he moves, deceiving the eye as to his precise location.",
        rules: "While worn, all attacks against the Warrior are at -1 to hit. If an attacker rolls a 6 to hit, the cloak’s power is exhausted until the next adventure.",
        treasureTableDiceResult: "234",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Armour },
        costSell: 350,
        imagePath: "images/TreasurePackOneDungeonRoomCard/CloakOfDeception.png",
        inventorySlot: InventorySlot.Back);

    public static MagicItemData CloakOfStealth => new(
        name: "Cloak of Stealth",
        flavor: "This cloak is made of an odd material that is slippery to the touch.",
        rules: "While wearing, the Warrior may automatically break from pinning once per adventure.",
        treasureTableDiceResult: "235",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Armour },
        costSell: 100,
        imagePath: "images/TreasurePackOneDungeonRoomCard/CloakOfStealth.png",
        inventorySlot: InventorySlot.Back);

    public static MagicItemData CoughingSpellJewel => new(
        name: "Coughing Spell Jewel",
        flavor: "This jewel contains the power for the Coughing spell.",
        rules: "Pick any Monster on the same board section. On a roll of 6, the target collapses in a coughing spasm and is at -1 to hit for the rest of the turn.",
        treasureTableDiceResult: "236",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.B },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Amulet },
        costSell: 50,
        imagePath: "images/TreasurePackOneDungeonRoomCard/CoughingSpellJewel.png",
        inventorySlot: InventorySlot.Neck);

    public static MagicItemData DispelMagicScroll => new(
        name: "Dispel Magic Scroll",
        flavor: "The Warrior raises his hand and shouts words of warding, diffusing his opponent’s magic.",
        rules: "Cast against an incoming spell. On 4–6 the target spell is prevented.",
        treasureTableDiceResult: "241",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 100,
        imagePath: "images/TreasurePackOneDungeonRoomCard/DispelMagicScroll.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData DomeOfPower => new(
        name: "Dome of Power",
        flavor: "White power streams from the Warrior’s eyes, forming a protective dome.",
        rules: "Protects up to 4 linked squares. Models inside cannot act but are immune to all forms of attack.",
        treasureTableDiceResult: "242",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 250,
        imagePath: "images/TreasurePackOneDungeonRoomCard/DomeOfPower.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData FangedDeathHelm => new(
        name: "Fanged Death Helm",
        flavor: "This helm is fashioned into the likeness of the gaping maw of a ravenous beast.",
        rules: "Once per turn, the warrior wearing the Fanged Death Helm may exchange one of his attakcs for a bite attack. This attack hits automatically for 1D6 Wounds that cannot be reduced.",
        treasureTableDiceResult: "243",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Helmet },
        costSell: 250,
        imagePath: "images/TreasurePackOneDungeonRoomCard/FangedDeathHelm.png",
        inventorySlot: InventorySlot.Head);

    public static MagicItemData Firebombs => new(
        name: "Firebombs (1D6)",
        flavor: "The Warriors discover a box of firebombs marked with a skull.",
        rules: "Each firebomb affects a 2x2 square area, dealing 1D6 Wounds to all models inside, ignoring armour and Toughness. Each bomb can be used once.",
        treasureTableDiceResult: "244",
        ruleUsages: new[] { RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.W, HeroCode.D, HeroCode.B },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 75,
        imagePath: "images/TreasurePackOneDungeonRoomCard/Firebombs.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData GlorySpellScroll => new(
        name: "Glory! Spell Scroll",
        flavor: "The Warrior bearing the scroll sends out tendrils of force that fill allies with courage.",
        rules: "All Warriors gain +1 Attack this turn.",
        treasureTableDiceResult: "245",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 400,
        imagePath: "images/TreasurePackOneDungeonRoomCard/GlorySpellScroll.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData Glowstone => new(
        name: "Glowstone",
        flavor: "This small crystal orb holds the light of dawn, glowing like a lantern.",
        rules: "The carrier can explore like the leader with the lantern. If a 1 is rolled in the Power Phase, roll again: on 1–3, the glow dies.",
        treasureTableDiceResult: "246",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 400,
        imagePath: "images/TreasurePackOneDungeonRoomCard/Glowstone.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData Gold1D6x50 => new(
    name: "Gold (1D6x50)",
    flavor: "After a thorough search, one of the Warriors finds a leather bag hidden behind a stone.",
    rules: "The bag contains 1D6x50 gold.",
    treasureTableDiceResult: "246",
    ruleUsages: new[] { RuleUsage.None },
    new List<HeroCode> { HeroCode.All },
    treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
    magicItemType: new[] { MagicItemType.Item },
    costSell: 50,
    imagePath: "images/TreasurePackOneDungeonRoomCard/Gold1D6x50.png",
    inventorySlot: InventorySlot.Pouch);

    public static MagicItemData HiddenAlcove => new(
        name: "Hidden Alcove",
        flavor: "After a thorough search, one of the Warriors finds a secret panel opening to reveal a hidden alcove.",
        rules: "Roll as many dice as you like. If any show a 1, you find nothing and must take an Event card immediately. On 2–5, gain gold ×10. Each 6 gives you a Treasure card.",
        treasureTableDiceResult: "251",
        ruleUsages: new[] { RuleUsage.None },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackOneDungeonRoomCard/HiddenAlcove.png",
        inventorySlot: InventorySlot.None);

    public static MagicItemData HolyArtefact => new(
        name: "Holy Artefact",
        flavor: "You find a dusty religious artefact recognized as belonging to one of the temples of the Empire.",
        rules: "At the end of the adventure, roll a D6 to see if you find a temple. On a score of 4+, you find a temple and can sell the artefact for 1D6x100 gold. Roleplay: You may find a temple in any Settlement. If you return this artefact, the temple priests will reward you with. 1D6x100 gold. If you roll a 1 when seeing how much gold you receive, then k./you actually get nothing - it is not an artefact they recognize. You will have to try again in the next Set",
        treasureTableDiceResult: "252",
        ruleUsages: new[] { RuleUsage.None },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackOneDungeonRoomCard/HolyArtefact.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData LifebringerSpellScroll => new(
        name: "Lifebringer Spell Scroll",
        flavor: "Blazing fire leaps from the Warrior’s eyes, bathing allies in energy that heals their wounds.",
        rules: "Pick any number of Warriors. Roll 1D6 for each; each heals that many Wounds. If two or more dice are the same, the spell fails completely.",
        treasureTableDiceResult: "253",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 150,
        imagePath: "images/TreasurePackOneDungeonRoomCard/LifebringerSpellScroll.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData LifestealerTalisman => new(
        name: "Lifestealer Talisman",
        flavor: "The Warrior with this talisman can steal Wounds from a nearby Monster to heal himself.",
        rules: "The warrior with the talisman can steal wounds from a nearby monster to heal himself. One adjacent Monster suffers 1D6 Wounds with no modifiers. The Warrior gains the same number of Wounds up to his starting maximum.",
        treasureTableDiceResult: "254",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Amulet },
        costSell: 450,
        imagePath: "images/TreasurePackOneDungeonRoomCard/LifestealerTalisman.png",
        inventorySlot: InventorySlot.Neck);

    public static MagicItemData PearlNecklace => new(
        name: "Pearl Necklace",
        flavor: "The Warriors find a long pearl necklace hidden behind a stone in the wall.",
        rules: "Worth 1D6x10 gold. If selling in a Settlement, roll D6×10. On a roll of 1, the necklace is fake and cannot be sold here.",
        treasureTableDiceResult: "255",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackOneDungeonRoomCard/PearlNecklace.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData PitOfDespairScroll => new(
        name: "Pit of Despair Scroll",
        flavor: "White light pours from the Warrior’s mouth, creating a bottomless pit in the stone floor.",
        rules: "Place a pit marker in a 2x2 square. Roll a D6 for every model on the marker. On a 1 or 2, the model falls in the pit and is killed. On a 3-6 it scrambles out of the way - put\r\nit in any empty square on this ;\r\nor any adjacent board section.\r\nIf there are no empty squares E\r\navailable the model falls into\r\nthe pit anyway. Once the pit is\r\nNn place, no model may enter\r\nthe squares it covers.\r\n ",
        treasureTableDiceResult: "256",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 300,
        imagePath: "images/TreasurePackOneDungeonRoomCard/PitOfDespairScroll.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData PotionOfAlchemy => new(
        name: "Potion of Alchemy",
        flavor: "After a careful search, a small glass bottle of fizzing pink liquid is found.",
        rules: "This potion may be sold at an Alchemist’s Laboratory (Special Location). It is worth 1D6x40 gold.",
        treasureTableDiceResult: "261",
        ruleUsages: new[] { RuleUsage.None },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackOneDungeonRoomCard/PotionOfAlchemy.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData PotionOfFlight => new(
        name: "Potion of Flight",
        flavor: "The bubbling liquid burns the Warrior’s throat as he drinks it.",
        rules: "After drinking this potion, your warrior levitates a few inches above the ground while moving. The Warrior may pass over chasms and pits unhindered. Enemies attacking him are at -1 to hit. Lasts for one turn.",
        treasureTableDiceResult: "262",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 250,
        imagePath: "images/TreasurePackOneDungeonRoomCard/PotionOfFlight.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData PotionOfInstability => new(
        name: "Potion of Instability",
        flavor: "This potion shifts the dimensional position of your Warrior, making him ethereal and insubstantial.",
        rules: "When drunk, this postion shifts the dimensional position of your warrior, making him ethereal and insubstantial. The Warrior cannot be pinned, attack, cast magic, or be attacked for one turn.",
        treasureTableDiceResult: "263",
        ruleUsages: new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 200,
        imagePath: "images/TreasurePackOneDungeonRoomCard/PotionOfInstability.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData PotionOfWeaponMastery => new(
    name: "Potion of Weapon Mastery",
    flavor: "In a pile of broken crates you find a glass phial containing a warm amber liquid.",
    rules: "When drunk, the potion gives your warrior +2 to hit, and causes an extra 2D6 Wounds on attacks. Lasts for one turn.",
    treasureTableDiceResult: "264",
    ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
    new List<HeroCode> { HeroCode.All },
    treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
    magicItemType: new[] { MagicItemType.Item },
    costSell: 150,
    imagePath: "images/TreasurePackOneDungeonRoomCard/PotionOfWeaponMastery.png",
    inventorySlot: InventorySlot.Pouch);

    public static MagicItemData RelicBlade => new(
        name: "Relic Blade",
        flavor: "This holy blade is an artefact of great religious significance within the Empire and was reputed to have been used by the realm's mightiest heroes in numerous battles.",
        rules: "While your warrior is using this sword he gets +1 on his to hit roll.",
        treasureTableDiceResult: "265",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 400,
        imagePath: "images/TreasurePackOneDungeonRoomCard/RelicBlade.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData RingOfSureSeeing => new(
        name: "Ring of Sure Seeing",
        flavor: "This ring bears a large gem that glows faintly when danger approaches.",
        rules: "If you take an Event card that you don't like you may swap it for another. Shuffle all Event cards together (including used ones) to form a new deck. Draw the top card and continue as normal.",
        treasureTableDiceResult: "266",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Ring },
        costSell: 200,
        imagePath: "images/TreasurePackOneDungeonRoomCard/RingOfSureSeeing.png",
        inventorySlot: InventorySlot.Fingers);

    public static MagicItemData RunestoneOfSlaying => new(
        name: "Runestone of Slaying",
        flavor: "The warriors find an ancient item of Dwarf construction inscribed with a glowing rune.",
        rules: "This rune can be burned onto a single blade by touching the stone to the metal. For one attack, the weapon inflicts double damage (before adding Strength). Once per adventure.",
        treasureTableDiceResult: "311",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 300,
        imagePath: "images/TreasurePackOneDungeonRoomCard/RunestoneOfSlaying.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData SpellRing => new(
        name: "Spell Ring",
        flavor: "Any Wizard recognizes this as a potent magical ring capable of storing spells.",
        rules: "As soon as your warrior finds the ring, take one spell card at random. This is the spell that is stored in the ring. The bearer of the ring may cast the stored spell automatically at any time. After use, the ring is drained for the rest of the dungeon. RPG: Next adventure, draw a new card for the ring.",
        treasureTableDiceResult: "312",
        ruleUsages: new[] { RuleUsage.Reusable, RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Ring },
        costSell: 0,
        imagePath: "images/TreasurePackOneDungeonRoomCard/SpellRing.png",
        inventorySlot: InventorySlot.Fingers);

    public static MagicItemData Tankard => new(
        name: "Tankard",
        flavor: "A sturdy Dwarf tankard, specially designed for drinking Bugman’s beer.",
        rules: "Highly valued by Dwarfs. If a Dwarf finds this tankard, he will never sell it.",
        treasureTableDiceResult: "313",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 20,
        imagePath: "images/TreasurePackOneDungeonRoomCard/Tankard.png",
        inventorySlot: InventorySlot.None);

    public static MagicItemData UndeadBane => new(
        name: "Undead Bane",
        flavor: "A pot of thick, foul-smelling unguent that can be smeared on a weapon.",
        rules: "When applied, the weapon inflicts +1 Wound per battle level against all Undead. Effect lasts one turn. Enough for one weapon only.",
        treasureTableDiceResult: "314",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 50,
        imagePath: "images/TreasurePackOneDungeonRoomCard/UndeadBane.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData WallOfSteel => new(
        name: "Wall of Steel",
        flavor: "This cool blue steel blade flickers as if alive, creating a deadly shimmering blur.",
        rules: "When used in a corridor or doorway, no Monster may pass the Warrior unless they kill him first, regardless of flying or unpinnable traits.",
        treasureTableDiceResult: "315",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 200,
        imagePath: "images/TreasurePackOneDungeonRoomCard/WallOfSteel.png",
        inventorySlot: InventorySlot.MainHand);







    public static MagicItemData ArrowsOfPiercing => new(
    name: "Arrows of Piercing",
    flavor: "These arrows are barbed and black, fletched with raven feathers.",
    rules: "When used, these arrows ignore the target’s Toughness. Each arrow may only be used once.",
    treasureTableDiceResult: "316",
    ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
    new List<HeroCode> { HeroCode.All },
    treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
    magicItemType: new[] { MagicItemType.Bow },
    costSell: 0,
    imagePath: "images/TreasurePackTwoObjectiveRoomCard/ArrowsOfPiercing.png",
    inventorySlot: InventorySlot.TwoHanded);

    public static MagicItemData ArrowsOfSureFlight => new(
        name: "Arrows of Sure Flight",
        flavor: "These arrows are light and perfectly balanced, fletched with hawk feathers.",
        rules: "These arrows always hit their target and may be used instead of a normal bow attack. Each arrow may only be used once.",
        treasureTableDiceResult: "321",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Bow },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/ArrowsOfSureFlight.png",
        inventorySlot: InventorySlot.TwoHanded);

    public static MagicItemData Backpack => new(
        name: "Backpack",
        flavor: "A sturdy leather backpack with straps and buckles, used to carry more items into the dungeon.",
        rules: "A Warrior with a backpack may carry 6 extra items in addition to the normal limit.",
        treasureTableDiceResult: "322",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/Backpack.png",
        inventorySlot: InventorySlot.Back);

    public static MagicItemData BaubleOfAnurandel => new(
        name: "Bauble of Anurandel",
        flavor: "This small trinket shines with an inner light, reputedly a gift from the Elven prince Anurandel.",
        rules: "The Bauble of Anurandel allows the Warrior to re-roll any one dice roll per adventure.",
        treasureTableDiceResult: "323",
        ruleUsages: new[] { RuleUsage.OncePerDungeon, RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Amulet },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/BaubleOfAnurandel.png",
        inventorySlot: InventorySlot.Neck);

    public static MagicItemData BootsOfBattle => new(
        name: "Boots of Battle",
        flavor: "These steel-capped boots are said to echo with the war cries of ancient heroes.",
        rules: "The wearer may add +1 to all hit rolls they make.",
        treasureTableDiceResult: "324",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Boots },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/BootsOfBattle.png",
        inventorySlot: InventorySlot.Legs);

    public static MagicItemData BootsOfLeaping => new(
        name: "Boots of Leaping",
        flavor: "These enchanted boots are light as air, enabling great leaps.",
        rules: "The wearer may leap up to 3 squares instead of moving normally, even over pits and chasms.",
        treasureTableDiceResult: "325",
        ruleUsages: new[] { RuleUsage.Reusable, RuleUsage.RequiresAction },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Boots },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/BootsOfLeaping.png",
        inventorySlot: InventorySlot.Legs);

    public static MagicItemData BugmansXXXXXX => new(
        name: "Bugman’s XXXXXX",
        flavor: "This potent Dwarf ale is famed across the Old World.",
        rules: "When drunk, restore 1D6 Wounds immediately. The bottle contains only one draught.",
        treasureTableDiceResult: "326",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/BugmansXXXXXX.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData ChaosBane => new(
        name: "Chaos Bane",
        flavor: "This charm reeks of purity and order, radiating light against foul corruption.",
        rules: "While carried, all Chaos creatures within 2 squares suffer -1 to hit.",
        treasureTableDiceResult: "331",
        ruleUsages: new[] { RuleUsage.PassiveEffect, RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Amulet },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/ChaosBane.png",
        inventorySlot: InventorySlot.Neck);

    public static MagicItemData ConfuseSpellScroll => new(
        name: "Confuse Spell Scroll",
        flavor: "This fragile scroll is written in glowing ink of shifting colors.",
        rules: "This scroll may be read once. The target Monster is confused and may not act until the end of the next turn.",
        treasureTableDiceResult: "332",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/ConfuseSpellScroll.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData CrownOfMadness => new(
        name: "Crown of Madness",
        flavor: "A crown of jagged iron spikes, whispering insanity into the wearer’s mind.",
        rules: "The wearer may attempt to take control of one Monster each turn. Roll 1D6: on 5–6 the Monster obeys the wearer’s commands until the end of the turn.",
        treasureTableDiceResult: "333",
        ruleUsages: new[] { RuleUsage.OncePerTurn, RuleUsage.RequiresAction },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Helmet },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/CrownOfMadness.png",
        inventorySlot: InventorySlot.Head);

    public static MagicItemData CureSmallWoundsSpell => new(
        name: "Cure Small Wounds Spell",
        flavor: "A spell scroll written in silver ink on vellum, radiating gentle warmth.",
        rules: "The scroll may be read once. The target regains 1D6 Wounds immediately.",
        treasureTableDiceResult: "334",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/CureSmallWoundsSpell.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData ExoticFoodsOfTilea => new(
        name: "Exotic Foods of Tilea",
        flavor: "This hamper contains strange delicacies from distant Tilea.",
        rules: "The Warrior may eat these foods at any time to restore 1D6 Wounds. There is only enough for one meal.",
        treasureTableDiceResult: "335",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/ExoticFoodsOfTilea.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData FineClothes => new(
        name: "Fine Clothes",
        flavor: "An elegant set of nobleman’s attire, woven from silk and velvet.",
        rules: "Fine Clothes have no effect in the dungeon, but may be sold in a settlement for gold.",
        treasureTableDiceResult: "336",
        ruleUsages: new[] { RuleUsage.None },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 200,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/FineClothes.png",
        inventorySlot: InventorySlot.Torso);

    public static MagicItemData FineElfWine => new(
        name: "Fine Elf Wine",
        flavor: "A crystal bottle filled with sparkling Elven wine of rare vintage.",
        rules: "When drunk, restore 1D6 Wounds immediately. The bottle contains one draught.",
        treasureTableDiceResult: "341",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 300,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/FineElfWine.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData FleetOfFootScroll => new(
        name: "Fleet of Foot Scroll",
        flavor: "This spell scroll is inked with runes of speed that shimmer when read.",
        rules: "The scroll may be read once. For the rest of the turn, the Warrior may move double their normal distance.",
        treasureTableDiceResult: "342",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 0,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/FleetOfFootScroll.png",
        inventorySlot: InventorySlot.Pouch);
















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

