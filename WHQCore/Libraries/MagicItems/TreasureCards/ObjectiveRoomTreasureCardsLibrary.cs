using System.Reflection;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems.TreasureCards;

public static class ObjectiveRoomTreasureCardsLibrary
{
    public static MagicItemData PlaceHolder => new(
        "PlaceHolder",
        "",
        "",
        "000",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorObjectiveRoomCard],
        [MagicItemType.Item],
        200,
        "images/magicitems/treasurecards/PlacEHolder.png",
        InventorySlot.Pouch
    );

    public static MagicItemData SceptreOfZandri => new(
        "Sceptre of Zandri",
        "The Sceptre of Zandri protects its wielder from the baneful gaze of the Undead, making him harder to hit.",
        "The Sceptre may be wielded like a normal sword, and inflicts an extra D6 wounds against Undead. In addition, Undead are at -2 to hit a Warrior using the Sceptre. Permanent.",
        "111",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorObjectiveRoomCard],
        [MagicItemType.Weapon],
        1000,
        "images/CatacombsOfTerrorTreasureCard/SceptreOfZandri.png",
        InventorySlot.MainHand
    );

    public static MagicItemData ArmourOfDargan => new(
        "Armour of Dargan",
        "The glow from this deep red armour lights up the dungeon.",
        "The wearer gains +4 Toughness and Monsters attacking him are at -1 to hit unless using a magic weapon.",
        "112",
        [RuleUsage.Permanent, RuleUsage.PassiveEffect],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Armour],
        10000,
        "images/TreasurePackOneObjectiveRoomCard/ArmourOfDargan.png",
        InventorySlot.Torso);

    public static MagicItemData ArrowsOfLoren => new(
        "Arrows of Loren",
        "These arrows, cut from the greatest trees in Loren, fly truer than all others.",
        "Add +2 to BS when using them. Ignore 1 point of armour and cause an extra Wound. There are 3D6 arrows; each may only be used once. Worth 100 gold per arrow.",
        "113",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.E, HeroCode.B },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        100,
        "images/TreasurePackOneObjectiveRoomCard/ArrowsOfLoren.png",
        InventorySlot.Pouch);

    public static MagicItemData BattleStoneOfLeMarquis => new(
        "Battle Stone of Le Marquis",
        "The fabled creation of Michel d'un Doigt, Bretonnian Wizard, forged with dark ingredients.",
        "One of the Warrior’s attacks (not death-blows) automatically hits the target. Use once per adventure.",
        "114",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackOneObjectiveRoomCard/BattleStoneOfLeMarquis.png",
        InventorySlot.Pouch);

    public static MagicItemData BloodSword => new(
        "Blood Sword",
        "This longsword drips blood perpetually onto the dungeon floor.",
        "On top of any other attacks the warrior using this sword makes roll 1D6 for each model in a square adjacent to him. On the score of a 6, the sword lashes out and strikes the model of its own volition which takes wounds as per any other hit.",
        "115",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        800,
        "images/TreasurePackOneObjectiveRoomCard/BloodSword.png",
        InventorySlot.MainHand);

    public static MagicItemData BootsOfFlight => new(
        "Boots of Flight",
        "These Elegant boots float an inch above the ground, shimmering with magic.",
        "The Warrior may pass over chasms and pits unhindered, and enemies attacking him are at -1 to hit. Lasts one adventure.",
        "116",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Boots],
        750,
        "images/TreasurePackOneObjectiveRoomCard/BootsOfFlight.png",
        InventorySlot.Legs);

    public static MagicItemData BaneSword => new(
        "Bane Sword",
        "This blade snarls and growls, eager to spill the blood of its hated foe.",
        "When found, draw a random Event card to determine the Monster type it hates. Against that foe, it inflicts double damage. RPG: Roll on the approriate monster table for the wielder's battle level. Affects all models from that race.",
        "121",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        500,
        "images/TreasurePackOneObjectiveRoomCard/BaneSword.png",
        InventorySlot.MainHand);

    public static MagicItemData ElfHelm => new(
        "Elf Helm",
        "An enchanted helm of Elves that turns aside fatal blows.",
        "While worn, an elf helm adds +1 to toughness. In addition, if the wearer chooses to do so, roll 1D6 on the following table: 1. Absorbs all damage from a blow, but is destroyed in the process. 2-4: Resolve the blow as normal. 6: The blow glances off the Elf helm, causing no damage at all.",
        "122",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.E },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Helmet],
        750,
        "images/TreasurePackOneObjectiveRoomCard/ElfHelm.png",
        InventorySlot.Head);

    public static MagicItemData HammerOfSpite => new(
        "Hammer of Spite",
        "This hammer seeks a hated foe to be slain at all costs.",
        "When a Monster is placed, choose it as the hated foe. The Warrior may ambush it immediately and gains +1 Attack per turn until it dies. If slain, gain double gold.",
        "123",
        [RuleUsage.Permanent, RuleUsage.RequiresAction],
        new List<HeroCode> { HeroCode.D, HeroCode.B },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        600,
        "images/TreasurePackOneObjectiveRoomCard/HammerOfSpite.png",
        InventorySlot.MainHand);

    public static MagicItemData HellfireSword => new(
        "Hellfire Sword",
        "The Hellfire Sword burns both friend and foe when its fury is unleashed.",
        "On a natural 6 to hit, target and all adjacent models (including wielder) take an extra 1D6+Battle level Wounds with no deductions.",
        "124",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        1500,
        "images/TreasurePackOneObjectiveRoomCard/HellfireSword.png",
        InventorySlot.MainHand);

    public static MagicItemData HornOfVengeance => new(
        "Horn of Vengeance",
        "As the horn is blown, a howling wind hurls Monsters to the ground.",
        "Roll D6 for every Monster on the board section. On score equal to or above its Toughness (or 6 always), the Monster is hurled down, takes 1D6 Wounds ignoring armour, and is prone for one turn.",
        "125",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.D, HeroCode.B },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Item],
        1000,
        "images/TreasurePackOneObjectiveRoomCard/HornOfVengeance.png",
        InventorySlot.Pouch);

    public static MagicItemData PowerStoneOfLeMarquis => new(
        "Power Stone of Le Marquis",
        "Another of Michel d’un Doigt’s grim creations, made with bone and sorcery.",
        "This is the fabled power stone of the marquis. Your warrior can add +1D6 to Strength for one turn.",
        "126",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackOneObjectiveRoomCard/PowerStoneOfLeMarquis.png",
        InventorySlot.Pouch);

    public static MagicItemData ShieldSpellScroll => new(
        "Shield Spell Scroll",
        "The Warrior shouts words of power, surrounded by a glowing shield of energy.",
        "For this turn, the Warrior is immune to all attacks except natural 6s or magical attacks. He may move and fight normally.",
        "131",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackOneObjectiveRoomCard/ShieldSpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData SwordOfVengeance => new(
        "Sword of Vengeance",
        "This blade shines with pure light and never dulls.",
        "Ignores Monster’s Toughness and all but magical armour. The wielder may re-roll one miss per turn.",
        "132",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.W },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        1000,
        "images/TreasurePackOneObjectiveRoomCard/SwordOfVengeance.png",
        InventorySlot.MainHand);

    public static MagicItemData WarningstoneOfAsuryan => new(
        "Warningstone of Asuryan",
        "This sky-blue jewel imparts lightning-fast reactions from the god Asuryan himself.",
        "When ambushed, roll a dice. On a 6, the wearer warns the party and prevents the Ambush attack. Once per event that generates monsters.",
        "133",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.E, HeroCode.B, HeroCode.W },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Amulet],
        1100,
        "images/TreasurePackOneObjectiveRoomCard/WarningstoneOfAsuryan.png",
        InventorySlot.Neck);

    public static MagicItemData TheHammerOfSigmar => new(
        "The Hammer of Sigmar",
        "Gifted to Sigmar by King Kurgan Ironbeard, this is the most revered weapon of the Empire.",
        "Ignores all but magical armour when rolling for damage. On a natural 6 to hit, it inflicts 4× normal damage. Only one may exist in the party.",
        "134",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackOneObjectiveRoomCard],
        [MagicItemType.Weapon],
        2000,
        "images/TreasurePackOneObjectiveRoomCard/TheHammerOfSigmar.png",
        InventorySlot.MainHand);

    public static MagicItemData ArmourOfMeteoricIron => new(
        "Armour of Meteoric Iron",
        "This armour looks pitted and dull, but glows with a dim radiance betraying its true nature.",
        "The wearer gains +3 Toughness with no movement penalties. Once worn it fuses to the flesh and cannot be removed. It must be donned immediately or left behind.",
        "135",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Armour],
        1000,
        "images/TreasurePackTwoObjectiveRoomCard/ArmourOfMeteoricIron.png",
        InventorySlot.Torso);

    public static MagicItemData AxeOfSlaying => new(
        "Axe of Slaying",
        "This axe was once wielded by the Dwarf Giant Slayer Umgrul Grunnson at the final battle of Karaz Azgal.",
        "Automatically hits. In addition, Instead of normal damage, roll 1D6: on 1 cause 1D6+Strength Wounds, on 2 cause 2D6+Strength, and so on. Use for one turn per adventure.",
        "136",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Axe],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/AxeOfSlaying.png",
        InventorySlot.MainHand);

    public static MagicItemData BladeOfLeapingGold => new(
        "Blade of Leaping Gold",
        "A superbly balanced blade that arcs in swift golden strikes.",
        "While wielded, the Warrior gains +3 Attacks.",
        "141",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Weapon],
        1000,
        "images/TreasurePackTwoObjectiveRoomCard/BladeOfLeapingGold.png",
        InventorySlot.MainHand);

    public static MagicItemData CrownOfThoughts => new(
        "Crown of Thoughts",
        "This battered crown is a powerful magical artefact.",
        "When Monsters ambush, roll 1D6. On 1–3 ambushed as normal, 4–5 wearer avoids ambush, 6 wearer also gains an extra Attack before Monsters strike. Other Warriors are ambushed as usual.",
        "142",
        [RuleUsage.Permanent, RuleUsage.PassiveEffect],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Helmet],
        800,
        "images/TreasurePackTwoObjectiveRoomCard/CrownOfThoughts.png",
        InventorySlot.Head);

    public static MagicItemData DragonStoneOfLeMarquis => new(
        "Dragon Stone of Le Marquis",
        "One of the dark artefacts of Michel d'un Doigt, Bretonnian wizard. He laboured long to create a series of enchanged artifacts to be used by the chivalric knights of that realm. Unfortunately, the essential ingredient in the creation of each artifact was the powdered bone from a human finger. Michel created nine in al...",
        "For one turn, the Warrior adds +1D6 to Toughness.",
        "143",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/DragonStoneOfLeMarquis.png",
        InventorySlot.Pouch);

    public static MagicItemData ElfShield => new(
        "Elf Shield",
        "A finely crafted shield glittering with unearthly sheen.",
        "Each turn ignore the first blow unless the hit roll was a natural 6, in which case the shield has no effect.",
        "144",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.E },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Shield],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/ElfShield.png",
        InventorySlot.OffHand);

    public static MagicItemData FirestormIcon => new(
        "Firestorm Icon",
        "A red shard crystal blazing with fire at its core, which flares up to a blazing wall of fire at the wielder's command.",
        "Target a 2×2 area visible to the Warrior. All Monsters there suffer 6D6 Wounds with no modifiers (roll once for all the monsters). Use once per adventure.",
        "145",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Item],
        2000,
        "images/TreasurePackTwoObjectiveRoomCard/FirestormIcon.png",
        InventorySlot.Pouch);

    public static MagicItemData GauntletsOfSoulRending => new(
        "Gauntlets of Soul Rending",
        "These cold steel gauntles have been steeped in powerful magic, and are able to tear the life essence from their victim.",
        "Wearer gains an extra attack each turn (at -1 to hit, normal damage). RPG: First Monster killed each adventure may add +1 to Starting Wounds on 4–6.",
        "146",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Item],
        800,
        "images/TreasurePackTwoObjectiveRoomCard/GauntletsOfSoulRending.png",
        InventorySlot.Hands);

    public static MagicItemData HornOfDefiance => new(
        "Horn of Defiance",
        "The warriors find a bronze horn in a dark corner...",
        "When blown, all Warriors may roll 1D6 to parry incoming blows. On 6, the blow is negated. Lasts until combat ends or Wizard rolls a 1 in Power Phase.",
        "151",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Item],
        750,
        "images/TreasurePackTwoObjectiveRoomCard/HornOfDefiance.png",
        InventorySlot.Pouch);

    public static MagicItemData LifestoneOfAshraaz => new(
        "Lifestone of Ashraaz",
        "A mystical stone from the insane sorcerer Ashraaz of Araby.",
        "The bearer may regain 1D3 Wounds each turn, as long as he has 1 or more Wounds remaining.",
        "152",
        [RuleUsage.OncePerTurn, RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Item],
        1500,
        "images/TreasurePackTwoObjectiveRoomCard/LifestoneOfAshraaz.png",
        InventorySlot.Pouch);

    public static MagicItemData LifeStoneOfLeMarquis => new(
        "Life Stone of Le Marquis",
        "Another of Michel d’un Doigt’s grim relics, infused with sorcery and bone.",
        "A powerful enchanted stone. When your warrior is reduced to 0 wounds, this magical stone deflects the killing blow and it causes no damage. Use once per adventure.",
        "153",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/LifeStoneOfLeMarquis.png",
        InventorySlot.Pouch);

    public static MagicItemData RingOfRegeneration => new(
        "Ring of Regeneration",
        "A stone band that heals even grievous wounds.",
        "At the end of any turn in which the wearer was hit by one or more foes, roll a dice if the warrior still has wounds remaining. On a 6 regain 2D6 Wounds. If your warrior has no wounds remaining, then on a 6 1D6 wounds are restored instead.",
        "154",
        [RuleUsage.OncePerTurn],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Ring],
        650,
        "images/TreasurePackTwoObjectiveRoomCard/RingOfRegeneration.png",
        InventorySlot.Fingers);

    public static MagicItemData RingOfTheWarp => new(
        "Ring of the Warp",
        "A black ring shimmering with unholy light, slipping from finger to finger.",
        "Each turn, instead of moving, the wearer may teleport. Roll a dice to determine distance. Must move to an empty square. If none, the wearer loses the turn.",
        "155",
        [RuleUsage.OncePerTurn, RuleUsage.RequiresAction],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Ring],
        1000,
        "images/TreasurePackTwoObjectiveRoomCard/RingOfTheWarp.png",
        InventorySlot.Fingers);

    public static MagicItemData SurefireBow => new(
        "Surefire Bow",
        "An elegant bow engraved with a rune of Surefire. Ancient stories tell of a bow that never misses.",
        "The bow has strength 4 and adds +2 to the wielder's to hit roll.",
        "156",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Bow],
        900,
        "images/TreasurePackTwoObjectiveRoomCard/SurefireBow.png",
        InventorySlot.TwoHanded);

    public static MagicItemData SwordOfHoeth => new(
        "Sword of Hoeth",
        "A High Elf sword, lightning fast, forged in Hoeth itself. Once mastered, the wielder is all but unstoppable in battle.",
        "Just before using the sword roll a dice: on 5–6 gain double Attacks; on 2–4 attack as normal; on 1 the Warrior falls prone and may do nothing further that turn.",
        "161",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackTwoObjectiveRoomCard],
        [MagicItemType.Weapon],
        750,
        "images/TreasurePackTwoObjectiveRoomCard/SwordOfHoeth.png",
        InventorySlot.MainHand);


    public static MagicItemData AxeOfBlood => new(
        "Axe of Blood",
        "A hefty axe that faintly screams for blood, and skulls...",
        "Whenever Monsters appear, roll a dice to see how the Warrior with the axe reacts this turn. 1: Insane, he attacks the nearest Warrior, ignoring pinning. He is at -1 to all his to hit rolls, but at +1 Strength and +1 Attacks. Roll again next turn. 2: The Warrior attacks the nearest Monster, with -1 to all his to hit rolls, but +1 Strength & Attacks. Roll on this table next turn, adding +1 to your dice roll. 3: The Warrior regains his self control, and may move and fight as usual, at +1 Strength and +1 Attacks.",
        "162",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Axe },
        800,
        "images/TreasurePackThreeObjectiveRoomCard/AxeOfBlood.png",
        InventorySlot.MainHand
    );

    public static MagicItemData BraceletOfSaphery => new(
        "Bracelet of Saphery",
        "This slender, glittering bracelet is said to come from Saphery, created by the Elven Mages who dwelt there in ages past.",
        "When you find the bracelet, randomly select one spell. This spell is stored in the bracelet, and may be cast once automatically during the adventure. RPG: Before each adventure, randomly select one spell equivalent in power yo your Warrior's battle level. Once per adventure, this spell may be automatically cast.",
        "163",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Armour },
        750,
        "images/TreasurePackThreeObjectiveRoomCard/BraceletOfSaphery.png",
        InventorySlot.Hands
    );

    public static MagicItemData ChaliceOfBattle => new(
        "Chalice of Battle",
        "When the Warrior drinks from this black chalice, his head is filled with visions of war and conflict.",
        "When drinking from the chalice, the Warrior gains the following benefits for one turn: +1 Attacks, +1 to all to hit rolls, +1 Strength dice for resolving damage.",
        "164",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Item },
        1000,
        "images/TreasurePackThreeObjectiveRoomCard/ChaliceOfBattle.png",
        InventorySlot.Pouch
    );

    public static MagicItemData DragonSword => new(
        "Dragon Sword",
        "This blade is fashioned from the venom fang of a Great Fire Dragon and is ancient beyond all telling.",
        "This sword causes double damage on a successful natural to hit roll of 5 or 6. However, the sword is partially sentient and refuses to be drawn from its scabbard by unworthy Warriors. At the start of each turn, roll a D6. On a roll of 1-3 the sword refuses to leave its scabbard. RPG: It will not let itself be used by Warriors of battle-level 3 or below.",
        "165",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Weapon },
        1200,
        "images/TreasurePackThreeObjectiveRoomCard/DragonSword.png",
        InventorySlot.MainHand
    );

    public static MagicItemData BowOfLoren => new(
        "Bow of Loren",
        "This slender bow was fashioned by the Wood Elves of Loren.",
        "This bow causes 1D6 +3 Wounds (RPG: 1D6 Wounds per battle-level of the firer). If this is sufficient to kill the target outright, and there is a Monster directly behind it in the direction the bow was fired, the arrow continues, hitting that Monster too. This process continues until there are no more Monsters in the direct line of fire, or one of them survives.",
        "166",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.E },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Bow },
        2000,
        "images/TreasurePackThreeObjectiveRoomCard/BowOfLoren.png",
        InventorySlot.TwoHanded
    );


    public static MagicItemData HelmOfPossession => new(
        "Helm of Possession",
        "From within the depths of this ugly helm, the Warrior's eyes stare out with an unworldly intensity.",
        "The wearer gains +1 Toughness. In addition, once per turn, the Warrior wearing the helm may attempt to hypnotise any one model that is within his line of sight. Roll a dice. On a score of 6, the model is hypnotised for the duration of the turn. Whilst hypnotised, the model loses 1D6 Attacks.",
        "211",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Helmet },
        1000,
        "images/TreasurePackThreeObjectiveRoomCard/HelmOfPossession.png",
        InventorySlot.Head
    );

    public static MagicItemData PistolAndShot => new(
        "Pistol & Shot",
        "After a thorough search, one of the Warriors finds an engraved wooden box, which contains a pistol and shot.",
        "The pistol is a missile weapon with Strength 6. It has a range of 6 squares. It takes one turn to reload after it has been fired. It has enough shot and gunpowder for one adventure. RPG: The pistol can be re-loaded by visiting the gunsmith as usual.",
        "212",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.D, HeroCode.W },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Weapon },
        1000,
        "images/TreasurePackThreeObjectiveRoomCard/PistolAndShot.png",
        InventorySlot.MainHand
    );

    public static MagicItemData PreciousIcon => new(
        "Precious Icon",
        "A revered and carefully wrought icon, crafted long ago and imbued with holy significance.",
        "While carrying this icon, the Warrior gains +1 Luck point per adventure. This point is restored at the start of each new adventure.",
        "213",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Item },
        0,
        "images/TreasurePackThreeObjectiveRoomCard/PreciousIcon.png",
        InventorySlot.Neck
    );

    public static MagicItemData RingOfSeeking => new(
        "Ring of Seeking",
        "This glittering ring is fashioned from some material that looks like quicksilver. Once placed on the finger, the ring shifts and changes as a shining, liquid-metal band.",
        "This ring allows your Warrior to attempt to avoid a trap he has just activated. Roll a 1D6. On a score of 1, 2 or 3 the ring's magic fails to work and the trap goes off as normal. On a score of 4, 5 or 6 the trap is magically disarmed and fails to work.",
        "214",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Ring },
        500,
        "images/TreasurePackThreeObjectiveRoomCard/RingOfSeeking.png",
        InventorySlot.Fingers
    );

    public static MagicItemData SpeedStoneOfLeMarquis => new(
        "Speed Stone of Le Marquis",
        "Michel d'un Doigt (one finger) was a powerful Wizard from Bretonnia. He laboured long to create a series of enchanted artifacts to be used by the chivalric knights of that realm. Unfortunately, the essential ingredient of each was powdered bone from a human finger. Michel created 9 in all...",
        "For one turn only, your Warrior can add +2 to his Movement and automatically break from pinning.",
        "215",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Item },
        500,
        "images/TreasurePackThreeObjectiveRoomCard/SpeedStoneOfLeMarquis.png",
        InventorySlot.Pouch
    );

    public static MagicItemData SwordOfHeroes => new(
        "Sword of Heroes",
        "This sword shines with the undimming fire of righteousness - smiting down evil wherever it may be found.",
        "The Sword of Heroes causes double damage when used against Monsters with a Toughness of 6 or more.",
        "216",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Weapon },
        900,
        "images/TreasurePackThreeObjectiveRoomCard/SwordOfHeroes.png",
        InventorySlot.MainHand
    );

    public static MagicItemData TalismanOfJet => new(
        "Talisman of Jet",
        "This glittering black jewel feels warm to the touch.",
        "This talisman allows a Wizard to exchange one of the spells he has learned for a new one. Roll a D6. On a score of 2 or more you may exchange the spell you don't want for another of the same type. Select the new spell at random. RPG: Roll a D6 at the start of the game if you wish to exchange one of your spells for another. On a score of 1 the talisman's power is exhausted and it crumbles to dust. On a score of 2+ you may exchange one of your spells for one of the same casting number.",
        "221",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.W },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Amulet },
        600,
        "images/TreasurePackThreeObjectiveRoomCard/TalismanOfJet.png",
        InventorySlot.Neck
    );

    public static MagicItemData WandOfDiabolum => new(
        "Wand of Diabolum",
        "This wand is pure white, shot through with streaks of diabolum, a bright red substance capable of harnessing magical energy.",
        "WWhile using this want, all of your spells have their casting number reduced by one.",
        "222",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.W },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Item },
        600,
        "images/TreasurePackThreeObjectiveRoomCard/WandOfDiabolum.png",
        InventorySlot.OffHand
    );

    public static MagicItemData WandOfJade => new(
        "Wand of Jade",
        "This wand has strange icons engraved upon its surface.",
        "This wand increases the effect of any spell that requires you to roll dice for its effects, such as Heal Wounds, by adding +2 to the total. The wand does not increase the spell's chance of success. For example: in the case of the Finger of Life spell, the spell still succeeds on a roll of 4, 5 or 6, but now heals 6, 7 or 8 Wounds (depending on the success roll). When found, the wand has 2D6 charges: each use of the wand expends 1 charge.",
        "223",
        new[] { RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.W },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Item },
        600,
        "images/TreasurePackThreeObjectiveRoomCard/WandOfJade.png",
        InventorySlot.OffHand
    );

    public static MagicItemData WarpJumpSpellJewel => new(
        "Warp Jump Spell Jewel",
        "When they use this arcane jewel, the Warriors vanish with a thundercrack.",
        "If a Warrior that jumps is carrying the only light source, the remaining Warriors are 'Lost in the Dark' and must roll on the Escaping Table from the Adventure Book. This also happens if Warriors Warp Jump without a light source. The jewel can be used once per adventure.",
        "224",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeObjectiveRoomCard },
        new[] { MagicItemType.Item },
        750,
        "images/TreasurePackThreeObjectiveRoomCard/WarpJumpSpellJewel.png",
        InventorySlot.Pouch
    );


    public static MagicItemData? GetMagicItemByName(string name)
    {
        var type = typeof(ObjectiveRoomTreasureCardsLibrary);
        var props = type.GetProperties(BindingFlags.Public | BindingFlags.Static);

        foreach (var prop in props)
            if (prop.PropertyType == typeof(MagicItemData))
            {
                var item = (MagicItemData)prop.GetValue(null);
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return item;
            }

        return null;
    }
}