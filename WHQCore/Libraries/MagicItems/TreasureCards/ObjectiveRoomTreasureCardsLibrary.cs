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

