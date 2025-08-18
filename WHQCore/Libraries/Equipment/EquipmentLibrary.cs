using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.Equipment;

public static class EquipmentLibrary
{
    public static EquipmentData Lantern => new(
        "Lantern",
        "Illuminates the boardsection you're on and the next over boardsection. If any other hero moves outside of illuminated board sections, they will have to roll on the 'Lost in the deep' table",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        ruleUsages: [RuleUsage.PassiveEffect],
        trader: new List<Trader> { Trader.NoTraderAvailable },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/Lantern.png",
        inventorySlot: InventorySlot.Waist
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
        imagePath: "images/equipment/DwarfGreatAxe.png",
        inventorySlot: InventorySlot.TwoHanded
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
        },
        inventorySlot: InventorySlot.Torso
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
        imagePath: "images/equipment/ElfBow.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData HealingPotion => new(
        "Healing Potion",
        "Brings one warrior back up to full wounds. One use only. Discard after use.",
        new List<HeroCode> { HeroCode.All },
        ruleUsages: [RuleUsage.DiscardAfterUse],
        trader: new List<Trader> { Trader.NoTraderAvailable },
        costBuy: 0,
        costSell: 0,
        stock: 0,
        imagePath: "images/equipment/healingPotion.png",
        inventorySlot: InventorySlot.Pouch
    );

    // Gunsmith items
    public static EquipmentData BraceOfPistols => new(
        "Brace of Pistols (2)",
        "Needs gunpowder and shot; Strength 6; each pistol may make 1 shot every other turn (takes one turn to reload); range 6 squares.",
        new List<HeroCode> { HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Gunsmith },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 3000,
        costSell: 600,
        stock: 10,
        imagePath: "images/equipment/BraceOfPistols.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData Musket => new(
        "Musket",
        "Needs gunpowder and shot; Strength 8; fired at -2 Ballistic Skill; 1 shot every other turn (takes one turn to reload): if the shot kills a Monster, it carries on into any Monster standing directly behind, at -1 Strength for each additional Monster killed.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Gunsmith },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 2000,
        costSell: 700,
        stock: 11,
        imagePath: "images/equipment/Musket.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData Shot => new(
        "Shot",
        "Enough shot for Pistol/Musket to last all adventure.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Gunsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 100,
        costSell: 0,
        stock: 4,
        imagePath: "images/equipment/Shot.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData Gunpowder => new(
        "Gunpowder",
        "Enough gunpowder for Pistol or Musket to last all adventure.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Gunsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 100,
        costSell: 0,
        stock: 4,
        imagePath: "images/equipment/Gunpowder.png",
        inventorySlot: InventorySlot.Pouch
    );

    // General Store items
    public static EquipmentData Rope => new(
        "Rope",
        "Use to escape pit; after each use roll 1D6, on 1 or 2 the rope breaks and is discarded.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 30,
        costSell: 5,
        stock: 5,
        imagePath: "images/equipment/Rope.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData Bandages => new(
        "Bandages",
        "Each bandage restores 3 Wounds. One use then discard. At the end of each adventure roll 1D6 for each bandage. On a score of 1, 2 or 3 the bandage has perished and is of no further use.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 50,
        costSell: 0,
        stock: 7,
        imagePath: "images/equipment/Bandages.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData Provisions => new(
        "Provisions",
        "Each set of provisions restores 2 Wounds. At the end of each adventure unused provisions must be discarded, as they have spoiled.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 50,
        costSell: 0,
        stock: 5,
        imagePath: "images/equipment/Provisions.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData DoorSpikes => new(
        "Door Spikes",
        "Each spike keeps a door shut for one turn. To use spike your Warrior must be adjacent to the door. Once spiked, a door cannot be opened unless it is broken down. To break down a door, a Monster must be adjacent to the door. Roll a dice and add the Monster's Strength. On a score of 9 or more the Monster breaks down the door.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 100,
        costSell: 10,
        stock: 7,
        imagePath: "images/equipment/DoorSpikes.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData CasksOfBeer => new(
        "Casks of Beer",
        "-1 to Weapon Skill; -1 Initiative, +1 Strength (Dwarf +2 Strength); +1 on Fear rolls: effects lasts 1 turn; if Wizard drinks he can't cast spells for 2 turns.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 50,
        costSell: 0,
        stock: 5,
        imagePath: "images/equipment/CasksOfBeer.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData FineRobes => new(
        "Fine Robes",
        "-",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 50,
        costSell: 20,
        stock: 6,
        imagePath: "images/equipment/FineRobes.png",
        inventorySlot: InventorySlot.Torso
    );

    public static EquipmentData Boots => new(
        "Boots",
        "-",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 20,
        costSell: 10,
        stock: 4,
        imagePath: "images/equipment/Boots.png",
        inventorySlot: InventorySlot.Legs
    );

    public static EquipmentData TranceStone => new(
        "Trance Stone",
        "If your Warrior does nothing, including move, for one turn, and there are no Monsters on the board, he enters a trance and regains 1 Wound.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.GeneralStore },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 300,
        costSell: 75,
        stock: 7,
        imagePath: "images/equipment/TranceStone.png",
        inventorySlot: InventorySlot.Pouch
    );

    // Weaponsmith items
    public static EquipmentData Dagger => new(
        "Dagger",
        "Strength 1; hand-to-hand or missile weapon; may be retrieved once all Monsters in the room are dead.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 75,
        costSell: 20,
        stock: 4,
        imagePath: "images/equipment/Dagger.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Knife => new(
        "Knife",
        "Strength 1; may be concealed inside Warrior's boot.",
        new List<HeroCode> { HeroCode.B, HeroCode.W },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 40,
        costSell: 5,
        stock: 2,
        imagePath: "images/equipment/Knife.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Sword => new(
        "Sword",
        "Normal damage (1D6 + Warrior's Strength).",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 200,
        costSell: 15,
        stock: 5,
        imagePath: "images/equipment/Sword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Longsword => new(
        "Longsword",
        "+1 Strength; -1 on all to hit rolls.",
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 400,
        costSell: 20,
        stock: 7,
        imagePath: "images/equipment/Longsword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData GreatSword => new(
        "Great Sword",
        "+4 Strength; -1 Initiative; -1 Attacks; cannot use shield at the same time.",
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 700,
        costSell: 35,
        stock: 8,
        imagePath: "images/equipment/GreatSword.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData Broadsword => new(
        "Broadsword",
        "+3 Strength; -1 on all to hit rolls.",
        new List<HeroCode> { HeroCode.B },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 500,
        costSell: 25,
        stock: 7,
        imagePath: "images/equipment/Broadsword.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Axe => new(
        "Axe",
        "Normal damage (as sword).",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 150,
        costSell: 15,
        stock: 4,
        imagePath: "images/equipment/Axe.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData BattleAxe => new(
        "Battle-axe",
        "+2 Strength; cannot use shield at the same time.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 500,
        costSell: 35,
        stock: 8,
        imagePath: "images/equipment/BattleAxe.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData ThrowingAxe => new(
        "Throwing Axe",
        "+1 Strength; missile or hand weapon. If thrown, may be retrieved once all the Monsters in the room are dead.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 300,
        costSell: 35,
        stock: 7,
        imagePath: "images/equipment/ThrowingAxe.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Spear => new(
        "Spear",
        "Missile or hand-to-hand weapon. +1 Initiative in 1st round of combat; may attack in ranks. No modifier on basic damage caused by wielder. If missile weapon, needs a 4+ to hit, Strength as thrower.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 200,
        costSell: 20,
        stock: 8,
        imagePath: "images/equipment/Spear.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Mace => new(
        "Mace",
        "-1 on all to hit rolls, but if to hit roll is an unmodified 6 roll extra 1D6 for Wounds.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 250,
        costSell: 20,
        stock: 7,
        imagePath: "images/equipment/Mace.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Warhammer => new(
        "Warhammer",
        "If to hit roll is a natural 6, roll extra 1D6 for Wounds.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 400,
        costSell: 100,
        stock: 10,
        imagePath: "images/equipment/Warhammer.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData ThrowingStarsBag => new(
        "Throwing Stars (Bag)",
        "Strength 1; missile weapon, thrown at -1 Ballistic Skill; ignore armour when rolling for damage; bag contains enough stars to last all adventure. The Warrior can throw as many stars per turn as he has Attacks.",
        new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 100,
        costSell: 35,
        stock: 6,
        imagePath: "images/equipment/ThrowingStarsBag.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static EquipmentData Flail => new(
        "Flail",
        "+2 Strength; -2 on all to hit rolls.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 250,
        costSell: 100,
        stock: 9,
        imagePath: "images/equipment/Flail.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData KnuckleDuster => new(
        "Knuckle Duster",
        "Strength 4; -2 on all to hit rolls.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 100,
        costSell: 25,
        stock: 8,
        imagePath: "images/equipment/KnuckleDuster.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData Halberd => new(
        "Halberd",
        "+1 Strength; -2 Initiative; cannot use shield at the same time; attack in 2 ranks.",
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new List<Trader> { Trader.Weaponsmith },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 250,
        costSell: 75,
        stock: 7,
        imagePath: "images/equipment/Halberd.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    // Fletcher items
    public static EquipmentData ShortBow => new(
        "Short Bow",
        "Strength 1; as many shots per turn as Warrior has Attacks.",
        new List<HeroCode> { HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 150,
        costSell: 20,
        stock: 5,
        imagePath: "images/equipment/ShortBow.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData Longbow => new(
        "Longbow",
        "Strength 4: one shot per turn.",
        new List<HeroCode> { HeroCode.D },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 300,
        costSell: 40,
        stock: 8,
        imagePath: "images/equipment/Longbow.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData Arrows => new(
        "Arrows",
        "Enough arrows for Short Bow or Longbow to last all dungeon.",
        new List<HeroCode> { HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 20,
        costSell: 0,
        stock: 3,
        imagePath: "images/equipment/Arrows.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData FireArrows => new(
        "1D6 Fire Arrows",
        "If arrow hits target it may set it alight: roll 1D6, on a score of 4, 5 or 6 the target is set alight and takes an extra 1D6 Wounds, with no modifier for Toughness or armour, each turn until the damage roll comes up a natural 1 or 2 and the fire goes out, causing no more Wounds. Contains 1D6 arrows.",
        new List<HeroCode> { HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 100,
        costSell: 0,
        stock: 8,
        imagePath: "images/equipment/FireArrows.png",
        inventorySlot: InventorySlot.Pouch
    );

    public static EquipmentData Crossbow => new(
        "Crossbow",
        "Strength 5; one shot per turn.",
        new List<HeroCode> { HeroCode.D, HeroCode.W },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 1000,
        costSell: 200,
        stock: 9,
        imagePath: "images/equipment/Crossbow.png",
        inventorySlot: InventorySlot.TwoHanded
    );

    public static EquipmentData PistolCrossbow => new(
        "Pistol Crossbow",
        "Strength 3; 3 shots every other turn (takes one turn to reload); range 5 squares.",
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.RequiresAction },
        costBuy: 1500,
        costSell: 250,
        stock: 10,
        imagePath: "images/equipment/PistolCrossbow.png",
        inventorySlot: InventorySlot.MainHand
    );

    public static EquipmentData SecondPistolCrossbow => new(
    "Pistol Crossbow",
    "Strength 3; 3 shots every other turn (takes one turn to reload); range 5 squares.",
    new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
    new List<Trader> { Trader.Fletcher },
    new List<RuleUsage> { RuleUsage.RequiresAction },
    costBuy: 1500,
    costSell: 250,
    stock: 11,
    imagePath: "images/equipment/PistolCrossbow.png",
    inventorySlot: InventorySlot.OffHand
);

    public static EquipmentData Quarrels => new(
        "Quarrels",
        "Enough quarrels for Crossbow or Pistol Crossbow to last all dungeon.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Fletcher },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 30,
        costSell: 0,
        stock: 3,
        imagePath: "images/equipment/Quarrels.png",
    inventorySlot: InventorySlot.Pouch
    );


    // Armorer items
    public static EquipmentData LeatherArmour => new(
        "Leather Armour",
        "+1 Toughness; destroyed by the first blow that scores a natural 6 for Wounds or if the Warrior wearing it is reduced to 0 Wounds.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 40,
        costSell: 20,
        stock: 5,
        imagePath: "images/equipment/LeatherArmour.png",
    inventorySlot: InventorySlot.Torso
    );

    public static EquipmentData Furs => new(
        "Furs",
        "+1 Toughness: may be worn in addition to chainmail or light armour, in which case it causes -1 Movement and -1 on all to hit rolls.",
        new List<HeroCode> { HeroCode.B },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 300,
        costSell: 75,
        stock: 4,
        imagePath: "images/equipment/Furs.png",
    inventorySlot: InventorySlot.Back
    );

    public static EquipmentData ChainmailArmour => new(
        "Chainmail Armour",
        "+2 Toughness; -1 Movement.",
        new List<HeroCode> { HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 500,
        costSell: 150,
        stock: 5,
        imagePath: "images/equipment/ChainmailArmour.png",
    inventorySlot: InventorySlot.Torso
    );

    public static EquipmentData LightArmour => new(
        "Light Armour",
        "+2 Toughness.",
        new List<HeroCode> { HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 1000,
        costSell: 150,
        stock: 7,
        imagePath: "images/equipment/LightArmour.png",
    inventorySlot: InventorySlot.Torso
    );

    public static EquipmentData HeavyArmour => new(
        "Heavy Armour",
        "+3 Toughness; -1 Movement (except Dwarf).",
        new List<HeroCode> { HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 4000,
        costSell: 1100,
        stock: 8,
        imagePath: "images/equipment/HeavyArmour.png",
    inventorySlot: InventorySlot.Torso
    );

    public static EquipmentData PlateArmour => new(
        "Plate Armour",
        "+4 Toughness; -1 Movement.",
        new List<HeroCode> { HeroCode.D },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 7000,
        costSell: 2500,
        stock: 10,
        imagePath: "images/equipment/PlateArmour.png",
    inventorySlot: InventorySlot.Torso
    );

    public static EquipmentData Shield => new(
        "Shield",
        "+1 Toughness; while using a shield, a Warrior cannot use a bow or a 2-handed weapon. Note that shields are only effective against hand-to-hand and missile weapon attacks, and not against fire or magic.",
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 300,
        costSell: 75,
        stock: 4,
        imagePath: "images/equipment/Shield.png",
        inventorySlot: InventorySlot.OffHand
    );

    public static EquipmentData GreatShield => new(
        "Great Shield",
        "+2 Toughness; -1 Movement; -1 on all to hit rolls; while using a great shield, a Warrior cannot use a bow or a 2-handed weapon. Note that shields are only effective against hand-to-hand and missile weapon attacks, and not against fire or magic.",
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 550,
        costSell: 150,
        stock: 9,
        imagePath: "images/equipment/GreatShield.png",
    inventorySlot: InventorySlot.OffHand
    );

    public static EquipmentData LeatherHelm => new(
        "Leather Helm",
        "+1 Toughness; destroyed by the first blow that scores a natural 6 for Wounds or if the Warrior wearing it is reduced to 0 Wounds.",
        new List<HeroCode> { HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 100,
        costSell: 12,
        stock: 4,
        imagePath: "images/equipment/LeatherHelm.png",
    inventorySlot: InventorySlot.Head
    );

    public static EquipmentData OpenHelmet => new(
        "Open Helmet",
        "+1 Toughness.",
        new List<HeroCode> { HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 500,
        costSell: 150,
        stock: 7,
        imagePath: "images/equipment/OpenHelmet.png",
    inventorySlot: InventorySlot.Head
    );

    public static EquipmentData Warhelm => new(
        "Warhelm",
        "+2 Toughness.",
        new List<HeroCode> { HeroCode.D, HeroCode.E },
        new List<Trader> { Trader.Armourer },
        new List<RuleUsage> { RuleUsage.PassiveEffect },
        costBuy: 1000,
        costSell: 350,
        stock: 9,
        imagePath: "images/equipment/Warhelm.png",
    inventorySlot: InventorySlot.Head
    );

    public static List<EquipmentData> GetAllEquipment()
    {
        var type = typeof(EquipmentLibrary);
        var props = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

        var list = new List<EquipmentData>();
        foreach (var prop in props)
        {
            if (prop.PropertyType == typeof(EquipmentData))
            {
                var eq = (EquipmentData)prop.GetValue(null);
                list.Add(eq);
            }
        }
        return list;
    }

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