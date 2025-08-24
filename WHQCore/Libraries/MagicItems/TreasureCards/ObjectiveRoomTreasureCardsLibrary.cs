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

    public static MagicItemData ArmourOfDargan => new(
    name: "Armour of Dargan",
    flavor: "The glow from this deep red armour lights up the dungeon.",
    rules: "The wearer gains +4 Toughness and Monsters attacking him are at -1 to hit unless using a magic weapon.",
    treasureTableDiceResult: "112",
    ruleUsages: new[] { RuleUsage.Permanent, RuleUsage.PassiveEffect },
    new List<HeroCode> { HeroCode.All },
    treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
    magicItemType: new[] { MagicItemType.Armour },
    costSell: 10000,
    imagePath: "images/TreasurePackOneObjectiveRoomCard/ArmourOfDargan.png",
    inventorySlot: InventorySlot.Torso);

    public static MagicItemData ArrowsOfLoren => new(
        name: "Arrows of Loren",
        flavor: "These arrows, cut from the greatest trees in Loren, fly truer than all others.",
        rules: "Add +2 to BS when using them. Ignore 1 point of armour and cause an extra Wound. There are 3D6 arrows; each may only be used once. Worth 100 gold per arrow.",
        treasureTableDiceResult: "113",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.E, HeroCode.B },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 100,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/ArrowsOfLoren.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData BattleStoneOfLeMarquis => new(
        name: "Battle Stone of Le Marquis",
        flavor: "The fabled creation of Michel d'un Doigt, Bretonnian Wizard, forged with dark ingredients.",
        rules: "One of the Warrior’s attacks (not death-blows) automatically hits the target. Use once per adventure.",
        treasureTableDiceResult: "114",
        ruleUsages: new[] { RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 500,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/BattleStoneOfLeMarquis.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData BloodSword => new(
        name: "Blood Sword",
        flavor: "This longsword drips blood perpetually onto the dungeon floor.",
        rules: "On top of any other attacks the warrior using this sword makes roll 1D6 for each model in a square adjacent to him. On the score of a 6, the sword lashes out and strikes the model of its own volition which takes wounds as per any other hit.",
        treasureTableDiceResult: "115",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 800,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/BloodSword.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData BootsOfFlight => new(
        name: "Boots of Flight",
        flavor: "These Elegant boots float an inch above the ground, shimmering with magic.",
        rules: "The Warrior may pass over chasms and pits unhindered, and enemies attacking him are at -1 to hit. Lasts one adventure.",
        treasureTableDiceResult: "116",
        ruleUsages: new[] { RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Boots },
        costSell: 750,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/BootsOfFlight.png",
        inventorySlot: InventorySlot.Legs);

    public static MagicItemData BaneSword => new(
        name: "Bane Sword",
        flavor: "This blade snarls and growls, eager to spill the blood of its hated foe.",
        rules: "When found, draw a random Event card to determine the Monster type it hates. Against that foe, it inflicts double damage. RPG: Roll on the approriate monster table for the wielder's battle level. Affects all models from that race.",
        treasureTableDiceResult: "121",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 500,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/BaneSword.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData ElfHelm => new(
        name: "Elf Helm",
        flavor: "An enchanted helm of Elves that turns aside fatal blows.",
        rules: "While worn, an elf helm adds +1 to toughness. In addition, if the wearer chooses to do so, roll 1D6 on the following table: 1. Absorbs all damage from a blow, but is destroyed in the process. 2-4: Resolve the blow as normal. 6: The blow glances off the Elf helm, causing no damage at all.",
        treasureTableDiceResult: "122",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Helmet },
        costSell: 750,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/ElfHelm.png",
        inventorySlot: InventorySlot.Head);

    public static MagicItemData HammerOfSpite => new(
        name: "Hammer of Spite",
        flavor: "This hammer seeks a hated foe to be slain at all costs.",
        rules: "When a Monster is placed, choose it as the hated foe. The Warrior may ambush it immediately and gains +1 Attack per turn until it dies. If slain, gain double gold.",
        treasureTableDiceResult: "123",
        ruleUsages: new[] { RuleUsage.Permanent, RuleUsage.RequiresAction },
        new List<HeroCode> { HeroCode.D, HeroCode.B },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 600,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/HammerOfSpite.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData HellfireSword => new(
        name: "Hellfire Sword",
        flavor: "The Hellfire Sword burns both friend and foe when its fury is unleashed.",
        rules: "On a natural 6 to hit, target and all adjacent models (including wielder) take an extra 1D6+Battle level Wounds with no deductions.",
        treasureTableDiceResult: "124",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 1500,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/HellfireSword.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData HornOfVengeance => new(
        name: "Horn of Vengeance",
        flavor: "As the horn is blown, a howling wind hurls Monsters to the ground.",
        rules: "Roll D6 for every Monster on the board section. On score equal to or above its Toughness (or 6 always), the Monster is hurled down, takes 1D6 Wounds ignoring armour, and is prone for one turn.",
        treasureTableDiceResult: "125",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.D, HeroCode.B },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 1000,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/HornOfVengeance.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData PowerStoneOfLeMarquis => new(
        name: "Power Stone of Le Marquis",
        flavor: "Another of Michel d’un Doigt’s grim creations, made with bone and sorcery.",
        rules: "This is the fabled power stone of the marquis. Your warrior can add +1D6 to Strength for one turn.",
        treasureTableDiceResult: "126",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 500,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/PowerStoneOfLeMarquis.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData ShieldSpellScroll => new(
        name: "Shield Spell Scroll",
        flavor: "The Warrior shouts words of power, surrounded by a glowing shield of energy.",
        rules: "For this turn, the Warrior is immune to all attacks except natural 6s or magical attacks. He may move and fight normally.",
        treasureTableDiceResult: "131",
        ruleUsages: new[] { RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 500,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/ShieldSpellScroll.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData SwordOfVengeance => new(
        name: "Sword of Vengeance",
        flavor: "This blade shines with pure light and never dulls.",
        rules: "Ignores Monster’s Toughness and all but magical armour. The wielder may re-roll one miss per turn.",
        treasureTableDiceResult: "132",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 1000,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/SwordOfVengeance.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData WarningstoneOfAsuryan => new(
        name: "Warningstone of Asuryan",
        flavor: "This sky-blue jewel imparts lightning-fast reactions from the god Asuryan himself.",
        rules: "When ambushed, roll a dice. On a 6, the wearer warns the party and prevents the Ambush attack. Once per event that generates monsters.",
        treasureTableDiceResult: "133",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.E, HeroCode.B, HeroCode.W },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Amulet },
        costSell: 1100,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/WarningstoneOfAsuryan.png",
        inventorySlot: InventorySlot.Neck);

    public static MagicItemData TheHammerOfSigmar => new(
        name: "The Hammer of Sigmar",
        flavor: "Gifted to Sigmar by King Kurgan Ironbeard, this is the most revered weapon of the Empire.",
        rules: "Ignores all but magical armour when rolling for damage. On a natural 6 to hit, it inflicts 4× normal damage. Only one may exist in the party.",
        treasureTableDiceResult: "134",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackOneObjectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 2000,
        imagePath: "images/TreasurePackOneObjectiveRoomCard/TheHammerOfSigmar.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData ArmourOfMeteoricIron => new(
    name: "Armour of Meteoric Iron",
    flavor: "This armour looks pitted and dull, but glows with a dim radiance betraying its true nature.",
    rules: "The wearer gains +3 Toughness with no movement penalties. Once worn it fuses to the flesh and cannot be removed. It must be donned immediately or left behind.",
    treasureTableDiceResult: "135",
    ruleUsages: new[] { RuleUsage.Permanent },
    new List<HeroCode> { HeroCode.All },
    treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
    magicItemType: new[] { MagicItemType.Armour },
    costSell: 1000,
    imagePath: "images/TreasurePackTwoObjectiveRoomCard/ArmourOfMeteoricIron.png",
    inventorySlot: InventorySlot.Torso);

    public static MagicItemData AxeOfSlaying => new(
        name: "Axe of Slaying",
        flavor: "This axe was once wielded by the Dwarf Giant Slayer Umgrul Grunnson at the final battle of Karaz Azgal.",
        rules: "Automatically hits. In addition, Instead of normal damage, roll 1D6: on 1 cause 1D6+Strength Wounds, on 2 cause 2D6+Strength, and so on. Use for one turn per adventure.",
        treasureTableDiceResult: "136",
        ruleUsages: new[] { RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Axe },
        costSell: 500,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/AxeOfSlaying.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData BladeOfLeapingGold => new(
        name: "Blade of Leaping Gold",
        flavor: "A superbly balanced blade that arcs in swift golden strikes.",
        rules: "While wielded, the Warrior gains +3 Attacks.",
        treasureTableDiceResult: "141",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 1000,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/BladeOfLeapingGold.png",
        inventorySlot: InventorySlot.MainHand);

    public static MagicItemData CrownOfThoughts => new(
        name: "Crown of Thoughts",
        flavor: "This battered crown is a powerful magical artefact.",
        rules: "When Monsters ambush, roll 1D6. On 1–3 ambushed as normal, 4–5 wearer avoids ambush, 6 wearer also gains an extra Attack before Monsters strike. Other Warriors are ambushed as usual.",
        treasureTableDiceResult: "142",
        ruleUsages: new[] { RuleUsage.Permanent, RuleUsage.PassiveEffect },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Helmet },
        costSell: 800,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/CrownOfThoughts.png",
        inventorySlot: InventorySlot.Head);

    public static MagicItemData DragonStoneOfLeMarquis => new(
        name: "Dragon Stone of Le Marquis",
        flavor: "One of the dark artefacts of Michel d'un Doigt, Bretonnian wizard. He laboured long to create a series of enchanged artifacts to be used by the chivalric knights of that realm. Unfortunately, the essential ingredient in the creation of each artifact was the powdered bone from a human finger. Michel created nine in al...",
        rules: "For one turn, the Warrior adds +1D6 to Toughness.",
        treasureTableDiceResult: "143",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 500,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/DragonStoneOfLeMarquis.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData ElfShield => new(
        name: "Elf Shield",
        flavor: "A finely crafted shield glittering with unearthly sheen.",
        rules: "Each turn ignore the first blow unless the hit roll was a natural 6, in which case the shield has no effect.",
        treasureTableDiceResult: "144",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Shield },
        costSell: 500,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/ElfShield.png",
        inventorySlot: InventorySlot.OffHand);

    public static MagicItemData FirestormIcon => new(
        name: "Firestorm Icon",
        flavor: "A red shard crystal blazing with fire at its core, which flares up to a blazing wall of fire at the wielder's command.",
        rules: "Target a 2×2 area visible to the Warrior. All Monsters there suffer 6D6 Wounds with no modifiers (roll once for all the monsters). Use once per adventure.",
        treasureTableDiceResult: "145",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 2000,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/FirestormIcon.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData GauntletsOfSoulRending => new(
        name: "Gauntlets of Soul Rending",
        flavor: "These cold steel gauntles have been steeped in powerful magic, and are able to tear the life essence from their victim.",
        rules: "Wearer gains an extra attack each turn (at -1 to hit, normal damage). RPG: First Monster killed each adventure may add +1 to Starting Wounds on 4–6.",
        treasureTableDiceResult: "146",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 800,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/GauntletsOfSoulRending.png",
        inventorySlot: InventorySlot.Hands);

    public static MagicItemData HornOfDefiance => new(
        name: "Horn of Defiance",
        flavor: "The warriors find a bronze horn in a dark corner...",
        rules: "When blown, all Warriors may roll 1D6 to parry incoming blows. On 6, the blow is negated. Lasts until combat ends or Wizard rolls a 1 in Power Phase.",
        treasureTableDiceResult: "151",
        ruleUsages: new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 750,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/HornOfDefiance.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData LifestoneOfAshraaz => new(
        name: "Lifestone of Ashraaz",
        flavor: "A mystical stone from the insane sorcerer Ashraaz of Araby.",
        rules: "The bearer may regain 1D3 Wounds each turn, as long as he has 1 or more Wounds remaining.",
        treasureTableDiceResult: "152",
        ruleUsages: new[] { RuleUsage.OncePerTurn, RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 1500,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/LifestoneOfAshraaz.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData LifeStoneOfLeMarquis => new(
        name: "Life Stone of Le Marquis",
        flavor: "Another of Michel d’un Doigt’s grim relics, infused with sorcery and bone.",
        rules: "A powerful enchanted stone. When your warrior is reduced to 0 wounds, this magical stone deflects the killing blow and it causes no damage. Use once per adventure.",
        treasureTableDiceResult: "153",
        ruleUsages: new[] { RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Item },
        costSell: 500,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/LifeStoneOfLeMarquis.png",
        inventorySlot: InventorySlot.Pouch);

    public static MagicItemData RingOfRegeneration => new(
        name: "Ring of Regeneration",
        flavor: "A stone band that heals even grievous wounds.",
        rules: "At the end of any turn in which the wearer was hit by one or more foes, roll a dice if the warrior still has wounds remaining. On a 6 regain 2D6 Wounds. If your warrior has no wounds remaining, then on a 6 1D6 wounds are restored instead.",
        treasureTableDiceResult: "154",
        ruleUsages: new[] { RuleUsage.OncePerTurn },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Ring },
        costSell: 650,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/RingOfRegeneration.png",
        inventorySlot: InventorySlot.Fingers);

    public static MagicItemData RingOfTheWarp => new(
        name: "Ring of the Warp",
        flavor: "A black ring shimmering with unholy light, slipping from finger to finger.",
        rules: "Each turn, instead of moving, the wearer may teleport. Roll a dice to determine distance. Must move to an empty square. If none, the wearer loses the turn.",
        treasureTableDiceResult: "155",
        ruleUsages: new[] { RuleUsage.OncePerTurn, RuleUsage.RequiresAction },
        new List<HeroCode> { HeroCode.All },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Ring },
        costSell: 1000,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/RingOfTheWarp.png",
        inventorySlot: InventorySlot.Fingers);

    public static MagicItemData SurefireBow => new(
        name: "Surefire Bow",
        flavor: "An elegant bow engraved with a rune of Surefire. Ancient stories tell of a bow that never misses.",
        rules: "The bow has strength 4 and adds +2 to the wielder's to hit roll.",
        treasureTableDiceResult: "156",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Bow },
        costSell: 900,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/SurefireBow.png",
        inventorySlot: InventorySlot.TwoHanded);

    public static MagicItemData SwordOfHoeth => new(
        name: "Sword of Hoeth",
        flavor: "A High Elf sword, lightning fast, forged in Hoeth itself. Once mastered, the wielder is all but unstoppable in battle.",
        rules: "Just before using the sword roll a dice: on 5–6 gain double Attacks; on 2–4 attack as normal; on 1 the Warrior falls prone and may do nothing further that turn.",
        treasureTableDiceResult: "161",
        ruleUsages: new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.W, HeroCode.E },
        treasureType: new[] { TreasureType.TreasurePackTwoObectiveRoomCard },
        magicItemType: new[] { MagicItemType.Weapon },
        costSell: 750,
        imagePath: "images/TreasurePackTwoObjectiveRoomCard/SwordOfHoeth.png",
        inventorySlot: InventorySlot.MainHand);





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

