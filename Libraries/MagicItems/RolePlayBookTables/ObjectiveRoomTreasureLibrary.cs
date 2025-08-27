using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems.RolePlayBookTables;

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
        imagePath: "images/objectiveroomtreasure/ringofseeking.png",
        inventorySlot: InventorySlot.Fingers
    );

    public static MagicItemData ChaliceOfSorcery => new(
        "Chalice of Sorcery",
        "This dull metal chalice sits in a small alcove in the wall, covered in verdigris and cobwebs. Rubbing the grime of years from its pitted surface, the Wizard recognises it as a Chalice of Sorcery.",
        "The Chalice of Sorcery acts as a source of Power that allows the Wizard to carry on casting spells when his own Power has run out. The Wizard can try to draw as many points of Power out of the Chalice as he likes. For every point of Power the Wizard draws to cast spells with, roll a D6. All the extra Power must be drawn at once so all the dice are rolled at the same time. For each dice that scores a 1 the Wizard loses 1D6 Wounds, with no modifiers for Toughness or armour.",
        treasureTableDiceResult: "12",
        ruleUsages: [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 700,
        imagePath: "images/objectiveroomtreasure/chaliceofsorcery.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData EnchantedJadeAmulet => new(
        "Enchanted Jade Amulet",
        "The amulet of enchanted jade looks like a stone washed up on a beach, worn smooth by the action of the sea.",
        "The Amulet of Enchanted Jade allows your Warrior to attempt to regenerate (1 x his Battle-level) wounds per turn, up to his Starting Wounds score. Each turn that your Warrior uses the amulet roll 1D6 on the following table:\n1 The amulet crumbles to dust, causing 1D6 Wounds on your Warrior, with no modifier for Toughness or armour.\n2 The amulet has no effect this turn.\n3-6 The amulet works as usual.\nThe amulet automatically fails to work while the Warrior wearing it is on zero Wounds. One use per turn.",
        treasureTableDiceResult: "13",
        ruleUsages: [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 600,
        imagePath: "images/objectiveroomtreasure/enchantedjadeamulet.png",
        inventorySlot: InventorySlot.Neck
    );

    public static MagicItemData BookOfArcaneKnowledge => new(
        "Book of Arcane Knowledge",
        "This book has a cracked and aged leather cover, with a rusted metal spine and lock. Upon opening it, the pages rustle with a life of their own.",
        "The Book of Arcane Knowledge contains spells that the Wizard may cast. As soon as the book is found roll 4D6. These dice are used to buy spells for the book in the same way that the Wizard gains spells when he goes up a Battle-level, as described under 'New Spells' in the Wizards' Training section. Each spell in the book may be cast once automatically at no Power cost. Once a spell has been cast that page of the book crumbles to dust.",
        treasureTableDiceResult: "14",
        ruleUsages: [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/bookofarcaneknowledge.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData BroochOfPower => new(
        "Brooch of Power",
        "This brooch glows too brightly to look at, as if it contained the energy of a fallen star.",
        "At the end of each turn the Wizard may use the brooch to store any unused Power he has left over, up to a maximum of (6 + his Battle-level). This stored Power may then be used at any time to augment his spellcasting. In addition, the bright aura cast by the brooch distracts any Monsters attacking the Wizard, adding +1 to his Toughness.",
        treasureTableDiceResult: "15",
        ruleUsages: [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/broochofpower.png",
        inventorySlot: InventorySlot.Neck
    );

    public static MagicItemData WandOfJade => new(
        "Wand of Jade",
        "This wand is the size of a walking stick and is made from a single piece of fine jade. Strange icons engraved upon its surface glow with power.",
        "This wand increases the effect of any spell that requires you to roll one or more dice for its effects, such as Heal wounds or Lightning Bolt, by adding +2 to the total. Note that the wand does not increase the spell's chance of success in any way. For example, if the Wizard uses this wand to increase the effects of the Finger of Life spell it still succeeds on a roll of 4, 5 or 6, but now heals 6, 7 or 8 Wounds (depending on the success of the roll). When found, the wand has 2D6 charges. Each use of the wand expends 1 charge.",
        treasureTableDiceResult: "16",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 600,
        imagePath: "images/objectiveroomtreasure/wandofjade.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData Dawnstone => new(
        "Dawnstone",
        "This crystal-like stone is mounted in a black iron brooch and radiates a pale light like that of the early morning.",
        "The Dawnstone may be used to restore any one Warrior to full wounds immediately, even if he is at zero wounds or dead. One use, then discard.",
        treasureTableDiceResult: "21",
        ruleUsages: [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/dawnstone.png",
        inventorySlot: InventorySlot.Neck
    );

    public static MagicItemData RuneOfDeath => new(
        "Rune of Death",
        "This stone has a Dwarf rune embossed upon its surface and is warm to the touch.",
        "When pressed into contact with any bladed weapon, the Runestone burns a Rune of Death into the blade and then vanishes. The Rune of Death itself is permanent. If the to hit roll with this weapon is a natural 6, the Rune of Death causes an extra 2D6 Wounds on the target.",
        treasureTableDiceResult: "22",
        ruleUsages: [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/runeofdeath.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData CrownOfSorcery => new(
        "Crown of Sorcery",
        "As soon as he puts this crown on, the wearer is plunged into the alien and dark world of magical power familiar to Wizards.",
        "The Crown of Sorcery allows any Warrior who is otherwise nonmagical to cast spells and use items of Wizard-only treasure. The Warrior wearing the crown can still wear armour. As soon as your Warrior finds the crown take two Spell cards from each deck at random: these are the spells he may cast. Each turn your Warrior gets the same amount of raw Power as a Battle-level 1 Wizard (roll 1D6+1 in the Power Phase), and may use it to cast one or more of his spells according to the normal rules. However, each time your Warrior casts one of his spells roll 1D6. If the score is 1 that spell fails and your Warrior is immobilised by the backlash of magical Power and can do nothing for the rest of the turn. While he is immobilised any attacks made against him hit on anything but a 1.",
        treasureTableDiceResult: "23",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Helmet],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/crownofsorcery.png",
        inventorySlot: InventorySlot.Head
    );

    public static MagicItemData TalismanOfObsidian => new(
    "Talisman of Obsidian",
    "This black talisman throbs dully with the rhythm of a pulsing wound and the air around it hangs heavy.",
    "This talisman negates the powers of any Wizard or other spellcaster adjacent to the wearer. Any spells cast by such models fail on a 1D6 roll of 4, 5 or 6 and the Power used to cast the spell is redirected to heal 1D6 of the wearer's Wounds. If the wearer attempts to cast a spell himself roll 1D6. On a score of 1 the spell fails.",
    treasureTableDiceResult: "24",
    ruleUsages: [RuleUsage.Reusable],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
    magicItemType: [MagicItemType.Item],
    costSell: 500,
    imagePath: "images/objectiveroomtreasure/talismanofobsidian.png",
        inventorySlot: InventorySlot.Neck
);

    public static MagicItemData TabletOfAdain => new(
        "Tablet of Adain",
        "This stone tablet weighs surprisingly little and is covered in indecipherable hatching and markings.",
        "When used by a Wizard, the Tablet of Adain allows you to re-roll any or all of his 'spell determining dice' when he goes up a Battle level. You may only re-roll each dice once and must take the result of the second roll, even if it is worse.",
        treasureTableDiceResult: "25",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/tabletofadain.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData ArmourOfTaakan => new(
        "Armour of Taakan",
        "This matt black suit of full armour - with dull bronze battle runes engraved on the breastplate, arms and helm - is said to be endowed with a life of its own, striking at the enemy no matter what its wearer intends.",
        "While wearing the Armour of Taakan your Warrior gets the benefits of Heavy Armour and Warhelm (+5 Toughness and -1 Movement). Every time an enemy wounds your Warrior the armour immediately retaliates and forces its wearer to strike back straight away. Your Warrior must make a single attack against the enemy that just hit him, in addition to his normal attacks this turn. Note that, if successful, this attack does not cause a deathblow.",
        treasureTableDiceResult: "26",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Armour],
        costSell: 1500,
        imagePath: "images/objectiveroomtreasure/armouroftaakan.png",
        inventorySlot: InventorySlot.Torso
    );

    public static MagicItemData WandOfDiabolum => new(
        "Wand of Diabolum",
        "This wand is pure white, shot through with streaks of diabolum, a bright red substance capable of harnessing magical energy.",
        "While using this wand all your Wizard's spells have their casting number reduced by -1.",
        treasureTableDiceResult: "31",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/wandofdiabolum.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData RingOfCheshnakk => new(
        "Ring of Cheshnakk",
        "Cheshnakk was a great wizard from Araby whose expertise was the creation of exquisite flying carpets. The pinnacle of his achievements, however, was forging the Rings of Cheshnakk.",
        "On command, one of these rings can transport its wearer back to his home, be that a castle, a forest clearing or a humble cottage. While wearing this ring your Warrior may at any time leave the dungeon and be transported to his home and safety. He is out of this adventure and meets the Warriors at the next Settlement.",
        treasureTableDiceResult: "32",
        ruleUsages: [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/ringofcheshnakk.png",
        inventorySlot: InventorySlot.Fingers
    );

    public static MagicItemData HammerOfSigmar => new(
        "Hammer of Sigmar",
        "This is perhaps the most ancient and revered of all the magic weapons in the Empire, forged by Dwarf Runesmiths to cement an ancient alliance between Dwarfs and Men.",
        "The Hammer of Sigmar ignores all except magic armour when rolling for damage. In addition, if the to hit score for the attack is a natural 6 it causes 4 x normal damage. There can only ever be one Hammer of Sigmar in the party.",
        treasureTableDiceResult: "33",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 2000,
        imagePath: "images/objectiveroomtreasure/hammerofsigmar.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BladeOfLeapingGold => new(
        "Blade of Leaping Gold",
        "This blade is superbly balanced and moves in a swift golden arc with almost no effort on the wielder's part, slicing through the enemy ranks with ease.",
        "While wielding this weapon your Warrior gets +3 Attacks.",
        treasureTableDiceResult: "34",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/bladeofleapinggold.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData Frostblade => new(
        "Frostblade",
        "This pale metallic blue weapon exudes a freezing aura and its blade glitters like ice.",
        "While wielding the Frostblade your Warrior may only make 1 Attack per turn. If your Warrior makes a successful attack with the Frostblade that causes at least 1 Wound (after taking into account Toughness, armour, any special abilities such as Ignore Blow, etc.) the target is automatically slain. A blow from a Frostblade can cause a deathblow. The Frostblade may only be used once per adventure.",
        treasureTableDiceResult: "35",
        ruleUsages: [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 750,
        imagePath: "images/objectiveroomtreasure/frostblade.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData RendingSword => new(
    "Rending Sword",
    "The serrated points along the cutting edge of this blade grind and gnash together like teeth, tearing through armour, flesh and bone.",
    "This sword causes an extra 2D6 Wounds upon a successful hit. In addition, the blow ignores 2 points of armour if the to hit roll was a natural 5 or 6.",
    treasureTableDiceResult: "36",
    ruleUsages: [RuleUsage.Reusable],
    new List<HeroCode> { HeroCode.All },
    treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
    magicItemType: [MagicItemType.Weapon],
    costSell: 1200,
    imagePath: "images/objectiveroomtreasure/rendingsword.png",
        inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData SwordOfDestruction => new(
        "Sword of Destruction",
        "This sword resonates with a deep hum and flickers with lightning.",
        "When drawn from its scabbard, this sword nullifies all magic within 1 square of the wielder. As long as the sword remains drawn, the wielder and any models in adjacent squares cannot use or count the benefits of any magic items or spells. In addition, the sword causes +1 Wound and gives the bearer the Magic Dispel 6+ special ability.",
        treasureTableDiceResult: "41",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 750,
        imagePath: "images/objectiveroomtreasure/swordofdestruction.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BaneSword => new(
        "Bane Sword",
        "As soon as it is drawn in the presence of its hated foe this blade snarls and growls, eager to spill blood.",
        "Make a D66 roll on the Monster Table that is the same level as your Warrior's Battle-level. The sword does 2 x normal damage against all Monsters of that race.",
        treasureTableDiceResult: "42",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/banesword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData DragonSword => new(
        "Dragon Sword",
        "This blade is fashioned from the venom fang of a Great Fire Dragon and is ancient beyond all telling.",
        "This sword causes double damage on a successful natural to hit roll of 5 or 6. However, the sword is partially sentient and refuses to be drawn from its scabbard by a Warrior of Battle-level 3 or below.",
        treasureTableDiceResult: "43",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 1200,
        imagePath: "images/objectiveroomtreasure/dragonsword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData HellfireSword => new(
        "Hellfire Sword",
        "Flames leap and burn along the length of this other-worldly sword. As it swings through the air, it leaves a trail of spitting magma in its wake.",
        "If your Warrior hits his opponent with a natural to hit roll of 6, as well as causing normal damage the target and all adjacent models (including your Warrior) burst into flames and take an extra 1D6 Wounds for each of your Warrior's Battle-levels, with no modifiers for Toughness or armour.",
        treasureTableDiceResult: "44",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 1500,
        imagePath: "images/objectiveroomtreasure/hellfiresword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData GromrilBlade => new(
        "Gromril Blade",
        "This mighty two-handed axe is a Dwarf artefact, able to cut through all but the most powerful armour.",
        "This axe ignores all except magical armour and does double damage on a successful hit. However, the axe is partially sentient and refuses to be drawn by a Warrior of Battle-level 2 or below. The Gromril Blade may not be used with a shield.",
        treasureTableDiceResult: "45",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Axe],
        costSell: 1200,
        imagePath: "images/objectiveroomtreasure/gromrilblade.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData HydraSword => new(
        "Hydra Sword",
        "Steeped in the blood of a hydra as it was forged, this blade has taken on some of the properties of these terrible beasts.",
        "On each successful hit, this blade does an extra 6D6 Wounds. The Hydra Sword may be used once per adventure.",
        treasureTableDiceResult: "46",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 850,
        imagePath: "images/objectiveroomtreasure/hydrasword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData SwordOfVengeance => new(
    "Sword of Vengeance",
    "The blade shines with a pure light and never dulls.",
    "This sword ignores the Monster's Toughness and all except magical armour when determining damage. In addition, the wielder can re-roll one miss per turn.",
    treasureTableDiceResult: "51",
    ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.B, HeroCode.W },
    treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
    magicItemType: [MagicItemType.Weapon],
    costSell: 1000,
    imagePath: "images/objectiveroomtreasure/swordofvengeance.png",
        inventorySlot: InventorySlot.MainHand
);

    public static MagicItemData AxeOfSlaying => new(
        "Axe of Slaying",
        "This axe was once wielded by the Dwarf Giantslayer Umgrul Grunnson at the final battle of Karak Azgal.",
        "This axe automatically hits its target. Instead of a normal damage roll, roll 1D6: if 1 the axe causes 1D6+Strength Wounds, if 2 then 2D6+Strength, etc. Use for one turn per adventure.",
        treasureTableDiceResult: "52",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Axe],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/axeofslaying.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData SwordOfHeroes => new(
        "Sword of Heroes",
        "This sword shines with an undimming fire - the fire of righteousness smiting down evil wherever it may be found.",
        "This sword causes an extra 3D6 Wounds when used against Monsters with a Toughness of 6 or more.",
        treasureTableDiceResult: "53",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 900,
        imagePath: "images/objectiveroomtreasure/swordofheroes.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BladeOfLeapingBronze => new(
        "Blade of Leaping Bronze",
        "As soon as it is drawn this blade strikes with incredible speed.",
        "This sword gives its wielder +2 Attacks.",
        treasureTableDiceResult: "54",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Weapon],
        costSell: 450,
        imagePath: "images/objectiveroomtreasure/bladeofleapingbronze.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static MagicItemData BowOfLoren => new(
        "Bow Of Loren",
        "This slender bow was fashioned by the Wood Elves of Loren.",
        "This bow inflicts 1D6 Wounds per Battle-level of the wielder. If this is sufficient to kill the target outright, and there is a Monster directly behind it in the line of fire, the arrow continues hitting that Monster too, until none remain or one survives.",
        treasureTableDiceResult: "55",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Bow],
        costSell: 2000,
        imagePath: "images/objectiveroomtreasure/bofloren.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData SurefireBow => new(
        "Surefire Bow",
        "This elegant bow has a single rune of Surefire. Ancient stories tell of a bow that never misses.",
        "This bow has Strength 4 and adds +2 to the wielder's to hit roll.",
        treasureTableDiceResult: "56",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Bow],
        costSell: 900,
        imagePath: "images/objectiveroomtreasure/surefirebow.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static MagicItemData EnchantedShield => new(
        "Enchanted Shield",
        "The surface of this shield gleams as brightly as a mirror. Clouds roll across its surface, and shards of light cut the air around it.",
        "This shield gives its bearer +3 Toughness, but may not be used with any other armour, except a helmet, until the wearer is Battle level 4 or above. A Warrior may not wield a two-handed weapon while using it.",
        treasureTableDiceResult: "61",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Shield],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/enchantedshield.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData ArmourOfMeteoricIron => new(
        "Armour of Meteoric Iron",
        "This armour's appearance is pitted and dull, but it glows with a dim radiance that betrays its true nature.",
        "This armour gives its wearer +3 Toughness, with no deductions for movement. Once worn it fuses to the flesh and cannot be removed. Must be worn immediately or left where found.",
        treasureTableDiceResult: "62",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Armour],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/armourofmeteoriciron.png",
        inventorySlot: InventorySlot.Torso
    );

    public static MagicItemData ShieldOfPtolos => new(
        "Shield of Ptolos",
        "This shield throws a shimmering haze around its bearer, making him a difficult target in battle.",
        "This shield gives the bearer +2 Toughness. The first time the bearer's counter is pulled for missile fire, you may put it back and draw again. If it comes up a second time, he is hit as normal.",
        treasureTableDiceResult: "63",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Shield],
        costSell: 250,
        imagePath: "images/objectiveroomtreasure/shieldofptolos.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData ArmourOfDargan => new(
        "Armour of Dargan",
        "The glow from this deep red armour lights up the dungeon.",
        "This armour makes the wearer harder to hit: he gets +4 Toughness and any Monster attacking him is at -1 on its to hit roll unless using a magical weapon.",
        treasureTableDiceResult: "64",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Armour],
        costSell: 1000,
        imagePath: "images/objectiveroomtreasure/armourofdargan.png",
        inventorySlot: InventorySlot.Torso
    );

    public static MagicItemData SpelleaterRune => new(
        "Spelleater Rune",
        "This rune contains powerful spells of negation. Magic in the immediate vicinity arcs as the rune tries to pull it in and absorb it.",
        "When pressed into contact with any bladed weapon, the rune burns a copy of itself into the blade and then vanishes. Any spells cast against the bearer of this magical blade now fail on a 1D6 roll of 5 or 6.",
        treasureTableDiceResult: "65",
        ruleUsages: [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 500,
        imagePath: "images/objectiveroomtreasure/spelleaterrune.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static MagicItemData StaffOfCommand => new(
        "Staff of Command",
        "This staff had runes of command burned into it many centuries ago.",
        "Once per Event the Wizard may use this staff to attempt to control any Monster on the board. Roll 1D6. On a score of 1-4 the magic fails. On a score of 5-6 the Wizard may choose one Monster and make it do whatever he wants, as long as the action does not cause it to harm itself. At the end of the turn, the possessed Monster returns to normal.",
        treasureTableDiceResult: "66",
        ruleUsages: [RuleUsage.None],
        new List<HeroCode> { HeroCode.W },
        treasureType: [TreasureType.DungeonTreasureMagicWeaponsAndArmor],
        magicItemType: [MagicItemType.Item],
        costSell: 900,
        imagePath: "images/objectiveroomtreasure/staffofcommand.png",
        inventorySlot: InventorySlot.OffHand
    );


    public static MagicItemData? GetObjectiveRoomTreasureByName(string name)
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
