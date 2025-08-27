using System.Reflection;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Libraries.MagicItems.TreasureCards;

public static class DungeonRoomTreasureCardsLibrary
{
    public static MagicItemData BlessedWater => new(
        "Blessed Water",
        "The blessed water can be used to heal or exorcise evil spirits and banish undead.",
        "A warrior can drink some blessed water in which case he immediately heals 1D6 wounds. Everytime a warrior drinks some blessed water roll a D6. On a 1, the water has run out and discard this treasure. The blessed water can also be thrown just like a missile weapon and all the normal rules apply. It will only effect the undead or daemons, and on a succesful hit causes 2D6 wounds with no deduction for toughness and armor. This card this card after thrown.",
        "111",
        [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Item],
        150,
        "images/magicitems/treasurecards/BlessedWater.png",
        InventorySlot.Pouch
    );

    public static MagicItemData FreezingDeathSpellJewel => new(
        "Freezing Death Spell Jewel",
        "This jewel is carved of ice that never melts, and it's freezing to the touch. When it's power is invoked, it releases a lethal blast of icy shards at the wizard's foes.",
        "This jewel may be used once per turn to cast the Freezing Death spell. The bearer must make his normal BS roll to hit as with normal missile attack. If he hits the monster, then he rolls 1D6 to see how many dice of wounds he causes. e.g: if he rolls a 2, he causes 2D6 wounds, not just 2 wounds.",
        "112",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Item],
        400,
        "images/magicitems/treasurecards/FreezingDeathSpellJewel.png",
        InventorySlot.Pouch
    );

    public static MagicItemData GlobeOfDetection => new(
        "Globe of Detection",
        "The Globe of Detection allows the warrior's vision to pierce the solid rock of the dungeon walls.",
        "A warrior with the globe of detection can easily find hidden passages. When the warrior rolls on the Hidden Passage table, he may add +1 to his roll. However, if the warrior rolls a 1, then that result stants and the warriors will suffer a 'Collapse!' result.",
        "113",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Item],
        100,
        "images/magicitems/treasurecards/GlobeOfDetection.png",
        InventorySlot.Pouch
    );

    public static MagicItemData GemOfPassage => new(
        "Gem of Passage",
        "The gem of passage was wrought many centuries ago by the Dwarfs. It aided them in building their underground empire and can be used to control the very rocks that make up the ceiling and floor of the dungeon.",
        "When a warrior invokes its power, the Gem of Passage opens a hole in one of the walls. Place another doorway on the board section the warrior occupies. Beyond this doorway will be 1D6+3 more dungeon cards which the warriors can explore as normal.",
        "114",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Item],
        250,
        "images/magicitems/treasurecards/GemOfPassage.png",
        InventorySlot.Pouch
    );

    public static MagicItemData Grimstone => new(
        "Grimstone",
        "The age-pitted surface of this ancient stone hides the power to drain the life energy of others and transfer it to its wearer.",
        "Upon invoking the grimstone, choose any other warrior in the party. Your warrior now has the same number of wounds as that warrior, while he has the numer of woounds your warrior had. In effect, their suffered wounds are swapped. The grimstone may not take any warrior above their starting wounds.",
        "115",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Item],
        400,
        "images/magicitems/treasurecards/Grimstone.png",
        InventorySlot.Pouch
    );

    public static MagicItemData MoradrielsBoots => new(
        "Moradriel's Boots",
        "Moradriel was a skilled elf mage who created many powerful magic items, most of which have been lost or destroyed down the long years. As soon as these boots are put on, the whole world seems to slow down.",
        "While wearing these boots, your warrior's movement charactaristic is 1D6+1. Roll each turn to see how far your warrior can move.",
        "116",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.E },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Boots],
        400,
        "images/magicitems/treasurecards/MoradrielsBoots.png",
        InventorySlot.Pouch
    );

    public static MagicItemData ReaperSword => new(
        "ReaperSword",
        "This mighty sword is sharper than a razor. Its keen blade glistens in the light of the lantern, and even in the shadows it shimmers with an eerie inner light.",
        "While your warrior is using this sword he gets +2 Strength.",
        "121",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Weapon],
        400,
        "images/magicitems/treasurecards/ReaperSword.png",
        InventorySlot.MainHand
    );

    public static MagicItemData Soulstone => new(
        "Soulstone",
        "The soulstone captures the departing soul of the bearer, should he be slain. Someone with the correct knowledge can then restore the soul to its body, resurrecting the unfortunate person.",
        "If the warrior with the soulstone is killed, by whatever means, he can be resurrected once the adventure is over. He loses any gold and treasure he may have accumulated during that adventure and is unchanged from the warrior he was when he set off down the dungeon.",
        "122",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.WhiteDwarfDungeonRoomTreasureCard],
        [MagicItemType.Item],
        400,
        "images/magicitems/treasurecards/Soulstone.png",
        InventorySlot.Pouch
    );

    public static MagicItemData AmuletOfPower => new(
        "Amulet Of Power",
        "This ornate amulet throbs dully and a thick, black liquid apears to flow within its core.",
        "At the start of each of your warrior's phase, you may roll a D6. On a 2 to 6, your warrior's strength is increased by +2 for the rest of the turn. On a 1, the amulet explodes causing 1D6 wounds with no modifiers for toughness or armour. Use until destroyed, then discard.",
        "123",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Amulet],
        350,
        "images/magicitems/treasurecards/AmuletOfPower.png",
        InventorySlot.Neck
    );

    public static MagicItemData ArrowsOfDeath => new(
        "Arrows of Death",
        "You find a pouch containing a number of jet-black arrows. Their shafts are encrusted with golden runes and their tips glow with a pale green light.",
        "These enchanted arrows are magically sharpened. While using the arrows of Death, your warrior inflicts +3 wounds on his opponent with his missile attacks. The arrows of Death can only be used by a warrior with a bow equipped. 1D6 arrows; 1 use each. Each arrow has 100g value.",
        "124",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        100,
        "images/magicitems/treasurecards/xxx.png",
        InventorySlot.Pouch
    );

    public static MagicItemData ChaliceOfFate => new(
        "Chalice of Fate",
        "The chalice of fate has the power to warp time, to change fate and alter reality.",
        "The chalice allows you to re-roll when determening the wizard's power during the power phase. You may only re-roll once, and you must accept the second roll, even if the score is worse.",
        "125",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        200,
        "images/magicitems/treasurecards/ChaliceOfFate.png",
        InventorySlot.Pouch
    );

    public static MagicItemData Deathstone => new(
        "Deathstone",
        "The Deathstone is a small black crystal that seems to soak up the light from the lantern, converting it into raw power.",
        "The Deathstone acts as a source of power for the wizard. When casting a spell, he may use the deathstone to increase his chance of success. Roll 1D6. On a 3 to 6, the spell may be cast at a cost of zero Power instead of its normal cost. On a 1 or 2, the spell fails and the wizards power for that turn is lost.",
        "126",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        150,
        "images/magicitems/treasurecards/Deathstone.png",
        InventorySlot.Pouch
    );

    public static MagicItemData DragonShield => new(
        "Dragon Shield",
        "This shield is fashioned from the deep-red, sulphorous scales of a great fire dragon.",
        "While wearing the Dragon Shield, your warrior is invulnerable to any one, single attack, whatever its origin.",
        "131",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Armour],
        300,
        "images/magicitems/treasurecards/Dragonshield.png",
        InventorySlot.OffHand
    );

    public static MagicItemData EnchantedShield => new(
        "Enchanted Shield",
        "The surface of this shield gleams as brightly as a mirror. Clouds roll across its surface, and shards of light cut the air around it as you move.",
        "Each time your warrior is hit, he may use this shield to try and absorb the blow. Roll 1D6. On a 5 or 6, the shield absords all the damage. On a 1, the shield explodes, and your warrior takes 1D6 wounds with no modifiers for toughness or armour.",
        "132",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Armour],
        300,
        "images/magicitems/treasurecards/EnchantedShield.png",
        InventorySlot.OffHand
    );

    public static MagicItemData FingerOfDoomScroll => new(
        "Finger of Doom scroll",
        "It's a dusty scroll, on which magical sigils are traced in a spidery scrawl.",
        "Maybe used by the wizard as any other spell with a casting number of 6. When cast, the finger of doom inflicts 6 wounds on asingle monster with no modifiers for toughness or armor.",
        "133",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        450,
        "images/magicitems/treasurecards/FingerOfDoomScroll.png",
        InventorySlot.OffHand
    );

    public static MagicItemData Firebomb => new(
        "Firebomb",
        "On a dirt-encrusted shelf you find a large ball with a fuse in the top. From the rune inscribed on it, and its pungent smell, you realise it is a firebomb.",
        "The firebomb may be thrown at any time and affects a 2 squares by 2 squares area. Any model in the area takes 1D6 wounds with no deduction for toughness or armour.",
        "135",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Weapon],
        0,
        "images/CoreSetTreasureCard/Firebomb.png",
        InventorySlot.Pouch
    );

    public static MagicItemData FlashPowder => new(
        "Flash Powder",
        "Hidden in a small alcove in the wall, overgrown by moss, you find a small bag of flash powder.",
        "The flash powder may be set off at any time to confuse the Warrior's enemies. After it has exploded, any Warriors who have not yet fought this turn get +1 Attack. Use once, then discard.",
        "136",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        75,
        "images/CoreSetTreasureCard/FlashPowder.png",
        InventorySlot.Pouch
    );

    public static MagicItemData FurCloak => new(
        "Fur Cloak",
        "You find a thick fur cloak. Rolled up and placed over one arm it offers some protection in place of a shield.",
        "The cloak acts as armour and provides a +1 modifier to your Warrior's Toughness. Each time it is used, roll 1D6. On a 4, 5 or 6 it remains effective and can be used again.",
        "141",
        [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Armour],
        75,
        "images/CoreSetTreasureCard/FurCloak.png",
        InventorySlot.Back
    );

    public static MagicItemData HealingSalve => new(
        "Healing Salve",
        "Amongst the debris in the room you find a black bottle containing a thick, yellow paste. It is a salve of healing.",
        "The healing salve can restore 2D6 Wounds to any single Warrior, or 1D6 Wounds on each of 2 different Warriors. Use once, then discard.",
        "142",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        100,
        "images/CoreSetTreasureCard/HealingSalve.png",
        InventorySlot.Pouch
    );

    public static MagicItemData HellMace => new(
        "Hell Mace",
        "Sparks fly from the iron-shod head of this mace as you wield it, bathing the area in light.",
        "While using the Hell Mace your Warrior gets +2 Attacks. Use once per adventure.",
        "143",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Weapon],
        250,
        "images/CoreSetTreasureCard/HellMace.png",
        InventorySlot.MainHand
    );

    public static MagicItemData IncenseOfHealing => new(
        "Incense of Healing",
        "When opened, the urn discharges a fragrant cloud of vapour that acts as a healing potion.",
        "Every Warrior on the same board section as the urn has 2D6 Wounds restored. Use once, then discard.",
        "144",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        200,
        "images/CoreSetTreasureCard/IncenseOfHealing.png",
        InventorySlot.Pouch
    );

    public static MagicItemData InvisibilityRing => new(
        "Invisibility Ring",
        "As you slip this ring onto your finger, you fade and vanish from sight.",
        "While wearing the Invisibility Ring your Warrior cannot be attacked. The ring contains enough power to keep your Warrior invisible for one turn. Use once per adventure.",
        "145",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        175,
        "images/CoreSetTreasureCard/InvisibilityRing.png",
        InventorySlot.Fingers
    );

    public static MagicItemData LightningFireRing => new(
        "Lightning Fire Ring",
        "As you put it on, this ring shrinks to fit tightly around your finger, and a lightning rune starts to glow coldly on its upper surface.",
        "The Lightning Fire Ring can fire a bolt of lightning on command. Your Warrior may target any Monster that is in his line of sight. The bolt hits automatically and inflicts 5D6 Wounds, with no modifiers for armour. Use once per adventure.",
        "146",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        500,
        "images/CoreSetTreasureCard/LightningFireRing.png",
        InventorySlot.Fingers
    );

    public static MagicItemData LuckyTalisman => new(
        "Lucky Talisman",
        "In the middle of a pile of rubbish in one corner of the room, you find a Lucky Talisman on a fine chain.",
        "Your Warrior may use the Lucky Talisman at any time. Any attack made while using the Lucky Talisman will automatically hit. Use once per adventure.",
        "151",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        150,
        "images/CoreSetTreasureCard/LuckyTalisman.png",
        InventorySlot.Neck
    );

    public static MagicItemData MagicPotion => new(
        "Magic Potion",
        "This small glass bottle bears strange inscriptions in some long-forgotten magical language.",
        "When your Warrior drinks the Magic Potion, roll 1D6 to determine what it is:\n1: Poison – lose 2D6 Wounds.\n2: Poison – lose 1D6 Wounds.\n3: Rainbow Potion – your Warrior's flesh becomes rainbow striped.\n4: Healing Potion – cures 1D6 of your Warrior's Wounds.\n5: Healing Potion – cures 2D6 of your Warrior's Wounds.\n6: Healing Potion – restores your Warrior to full Wounds. Use once, then discard.",
        "152",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        60,
        "images/CoreSetTreasureCard/MagicPotion.png",
        InventorySlot.Pouch
    );

    public static MagicItemData OrbOfMight => new(
        "Orb of Might",
        "This black orb glistens dully as you pick it up.",
        "The Orb of Might is a source of Power for the Wizard. Roll 1D6 to determine how much Power is initially stored in it. Once the Wizard has used 1 or more points of the stored Power, place a D6 on top of this card to show the remaining points. Worth 50 Gold per unused Power Point. Use until empty, then discard.",
        "153",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        50,
        "images/CoreSetTreasureCard/OrbOfMight.png",
        InventorySlot.Pouch
    );

    public static MagicItemData QuakeScroll => new(
        "Quake Scroll",
        "This dusty scroll is inscribed with magic runes and sigils that contain words of power.",
        "This scroll can be used at any time, and causes a 2 square by 2 square area of any one board section to cave in. Use the Cave-in marker to mark the area affected. Any Warrior or Monster caught in the area suffers 2D6 damage. Use once, then discard.",
        "154",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        200,
        "images/CoreSetTreasureCard/QuakeScroll.png",
        InventorySlot.Pouch
    );

    public static MagicItemData ShieldOfDeliverance => new(
        "Shield of Deliverance",
        "This shield is of simple yet exquisite craftsmanship. It seems to be made of a substance stronger than steel, yet weighs little more than a sheet of parchment.",
        "The Shield of Deliverance can completely absorb the damage from any two blows. The first time the shield is hit, flip this card over; when it is hit a second time, discard this card. Use once, then discard.",
        "155",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Armour],
        500,
        "images/CoreSetTreasureCard/ShieldOfDeliverance.png",
        InventorySlot.OffHand
    );

    public static MagicItemData Spear => new(
        "Spear",
        "Leaning against a wall, you find a hefty-looking spear with a wickedly sharp head.",
        "The spear may be used at any time. To make the attack, roll 1D6. On a 3, 4, 5 or 6 your Warrior has hit the target and inflicted 3D6 Wounds. On a 1 or 2 he has missed. Use once per adventure.",
        "156",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Weapon],
        100,
        "images/CoreSetTreasureCard/Spear.png",
        InventorySlot.TwoHanded
    );

    public static MagicItemData TalonOfDeath => new(
        "Talon of Death",
        "This magical artifact sucks all of the light from the surrounding area, creating an aura of darkness around you.",
        "Once your Warrior has finished moving, he may use the Talon of Death to cause 1D6 Wounds against every Monster adjacent to him, with no modifiers for Toughness or armour. Roll for each Monster separately. Use once per adventure.",
        "161",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        500,
        "images/CoreSetTreasureCard/TalonOfDeath.png",
        InventorySlot.Pouch
    );

    public static MagicItemData TimeFreezingRing => new(
        "Time Freezing Ring",
        "As you put it on, this ring freezes like ice and bursts into a cold blue flame, yet still feels comfortable to wear.",
        "The Time Freezing Ring allows your Warrior to immediately take an extra Phase straight away. Use once per adventure.",
        "162",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CoreSetTreasureCard],
        [MagicItemType.Item],
        200,
        "images/CoreSetTreasureCard/TimeFreezingRing.png",
        InventorySlot.Fingers
    );

    public static MagicItemData BorgratsCrown => new(
        "Borgrat's Crown",
        "The Warriors find a grubby looking circlet of rusted iron. Faded runes are inscribed on its pitted surface.",
        "This magical crown adds +1 to the wearer's Toughness. It can be worn at the same time as a helmet.",
        "163",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Armour],
        500,
        "images/LairOfTheOrcLordTreasureCard/BorgratsCrown.png",
        InventorySlot.Pouch
    );

    public static MagicItemData FungusBrew => new(
        "Fungus Brew",
        "The Warriors find a flask of the potion that turns Night Goblins into gibbering Fanatics.",
        "There is enough liquid in the flask for four doses. A Warrior can take a drink at any time during combat. Roll on the table below to see what happens:\n\n1–2: The brew makes the Warrior hallucinate! He immediately makes an attack against every model adjacent to him.\n3–4: The brew cures 1D6 Wounds.\n5–6: The brew cures 1D6 Wounds and allows the Warrior to completely ignore the next hit he takes.\n\nThe brew is worth 200 gold if none of it has been drunk, or 100 gold if some of it (but not all of it) has been consumed. Discard when all drunk.",
        "164",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Item],
        0,
        "images/LairOfTheOrcLordTreasureCard/FungusBrew.png",
        InventorySlot.Pouch
    );

    public static MagicItemData MagicArrers => new(
        "Magic Arrers",
        "You find 6 arrows carved with strange Goblin runes.",
        "The arrows are enchanted, but are somewhat unpredictable. When you use an arrow, roll on the table below instead of rolling to hit:\n\n1: The arrow automatically hits one of the Warriors, for D6+3 Wounds (determine who randomly).\n2–5: The arrow automatically hits the Monster and does 1D6+3 Wounds.\n6: The arrow automatically hits the Monster and does 2D6+3 Wounds.\n\nEach arrow can only be used once, and used arrows are worthless. Barbarian, Elf & Wizard only. Discard when all used. Worth 40g each.",
        "165",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Weapon],
        40,
        "images/LairOfTheOrcLordTreasureCard/MagicArrers.png",
        InventorySlot.Pouch
    );

    public static MagicItemData PlergitsStabba => new(
        "Plergit's Stabba",
        "The Warriors find a wickedly sharp and very thin bladed dagger designed for slipping between armour joints.",
        "The dagger can be used to make an extra attack on a Monster. Roll a D6:\n1–3: The attack hits causing 2D6+Strength Wounds modified for Toughness but not armour.\n4–6: The attack hits causing 3D6+Strength Wounds not modified for armour or Toughness.\n\nBarbarian, Elf & Dwarf only. Use once per adventure.",
        "166",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.D },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Weapon],
        400,
        "images/LairOfTheOrcLordTreasureCard/PlergitsStabba.png",
        InventorySlot.MainHand
    );

    public static MagicItemData PrittyStonez => new(
        "Pritty Stonez",
        "The Warriors find a small drawstring bag containing some ordinary-looking stones.",
        "When your Warrior looks through the 'stones' roll on the table below:\n\n1–3: Mixed with normal stones are 1D6 gold nuggets worth 25 gold each.\n4–6: Mixed with the normal stones are 1D6 gemstones worth 100 gold each.\n\nRecord, then discard.",
        "211",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Item],
        0,
        "images/LairOfTheOrcLordTreasureCard/PrittyStonez.png",
        InventorySlot.Pouch
    );

    public static MagicItemData RingOfLife => new(
        "Ring of Life",
        "The Warriors find a silver, jewel-encrusted ring. Within the central gemstone, a tiny flame burns brightly.",
        "The ring has the power to heal grievous wounds. It may only be used on a Warrior on zero Wounds. To use the ring, roll a dice. On a roll of 1 the flame flickers and dies, and has no effect. On any other score, the Warrior is healed back up to full Wounds. One use per adventure.",
        "212",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Item],
        350,
        "images/LairOfTheOrcLordTreasureCard/RingOfLife.png",
        InventorySlot.Fingers
    );

    public static MagicItemData ScrollOfTheChimera => new(
        "Scroll of the Chimera",
        "The Warriors find a dusty old scroll lying in a dark corner.",
        "The spell on this scroll gives a Warrior the appearance of a ferocious monster. The scroll may be read at any time, causing any Monsters to be so terrified of the affected Warrior that they will suffer a -2 penalty on their to hit rolls against him. The spell lasts until a 1 or 2 is rolled in the Power Phase. Dwarf, Wizard & Elf only. One use, then discard.",
        "213",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Item],
        300,
        "images/LairOfTheOrcLordTreasureCard/ScrollOfTheChimera.png",
        InventorySlot.Pouch
    );

    public static MagicItemData HammerOfHargon => new(
        "The Hammer of Hargon",
        "You find a sturdy Dwarf warhammer with an ornate icon carved on its head. Any Dwarf in the party recognizes this as the lost Hammer of Hargon.",
        "When using this hammer, you may roll as many dice for damage as you like. Add up the total, then add your Strength to the final score. However, if any of the dice come up with a 1 or 2, the hammer causes no damage at all. Dwarf, Wizard & Barbarian only.",
        "214",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.B },
        [TreasureType.LairOfTheOrcLordTreasureCard],
        [MagicItemType.Weapon],
        500,
        "images/LairOfTheOrcLordTreasureCard/HammerOfHargon.png",
        InventorySlot.MainHand
    );

    public static MagicItemData AncientVaseOfLustria => new(
        "Ancient Vase of Lustria",
        "Lustria is a land of the unknown, the undiscovered continent, a realm of Giants and Daemons and powers beyond all telling. This vase is of strange design, unsuitable for use by Humans, Elves or Dwarfs. Its purpose can only be guessed at, as can its age; but its beauty and value is beyond question.",
        "This vase is worth 175 gold. Record then discard.",
        "215",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        175,
        "images/TreasurePackOneDungeonRoomCard/AncientVaseOfLustria",
        InventorySlot.Pouch
    );

    public static MagicItemData ArmourOfFortune => new(
        "Armour of Fortune",
        "This armour gleams in a rainbow array of never ending carnage and war.",
        "This armour can absorb Wounds inflicted on the Warrior. Initially it is discharged, with no Wounds stored. Once put on, the armour cannot be removed for the rest of the adventure. It absorbs 30 Wounds, then explodes, taking the wearer to zero Wounds (and death if no healing is possible). Lasts until it explodes!",
        "216",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Armour],
        500,
        "images/TreasurePackOneDungeonRoomCard/ArmourOfFortune",
        InventorySlot.Torso
    );

    public static MagicItemData ArrowOfSlaying => new(
        "Arrow of Slaying",
        "A thick black light drips from the end of this arrow, chilling the air. The magical venom of this arrow can fell even the toughest Monster.",
        "If your Warrior hits a Monster with this arrow, roll 1D6. On a score of 1, 2, or 3 the arrow does normal damage. On a score of 4, 5 or 6 the Monster is immediately slain. Use once then discard.",
        "221",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        500,
        "images/TreasurePackOneDungeonRoomCard/ArrowOfSlaying",
        InventorySlot.Pouch
    );

    public static MagicItemData AxeOfSlaughter => new(
        "Axe of Slaughter",
        "This axe was forged by the Dwarf Runesmith Garven Surehammer, who honed its blade to an impossible sharpness.",
        "This axe causes 1D6 extra Wounds every time it hits.",
        "222",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.D },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        200,
        "images/TreasurePackOneDungeonRoomCard/AxeOfSlaughter",
        InventorySlot.MainHand
    );

    public static MagicItemData BandOfMagic => new(
        "Band of Magic",
        "This slander gold band glitters with a clear light.",
        "When your Warrior finds this ring, randomly select two Attack Spells (RPG: randomly select Attack spells appropriate to the Warrior's battle-level). These two spells are stored in the magic band. Each spell may be cast once automatically, whenever the wearer wishes. When both spells have been cast, the magic of the band has been used up and it is useless and worthless. Discard after use.",
        "223",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Ring],
        500,
        "images/TreasurePackOneDungeonRoomCard/BandOfMagic",
        InventorySlot.Fingers
    );

    public static MagicItemData BaneScrollOfTheUndead => new(
        "Bane Scroll of the Undead",
        "The Warriors find a dusty old scroll underneath a pile of rubbish.",
        "Reading aloud the words on this scroll will kill any single Undead creature worth up to 400 gold on a dice roll of 4, 5 or 6.",
        "224",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.W, HeroCode.D, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackOneDungeonRoomCard/BaneScrollOfTheUndead",
        InventorySlot.Pouch
    );

    public static MagicItemData BladeOfSeaGold => new(
        "Blade of Sea Gold",
        "Forged from gold taken from the depths of the sea when the world was young, this blade is covered in runes so ancient and worn that they can no longer be read.",
        "While your Warrior is using this sword each attack he makes ignores the first point of his opponent's armour.",
        "225",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        150,
        "images/TreasurePackOneDungeonRoomCard/BladeOfSeaGold",
        InventorySlot.MainHand
    );

    public static MagicItemData BladeOfSlicing => new(
        "Blade of Slicing",
        "This sword moans softly as it is drawn from its scabbard, in eager anticipation of the blood it is about to spill.",
        "While your Warrior is using the sword he causes +2 Wounds on each successful attack.",
        "226",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        300,
        "images/TreasurePackOneDungeonRoomCard/BladeOfSlicing",
        InventorySlot.MainHand
    );

    public static MagicItemData BootsOfTzchak => new(
        "Boots of Tzchak",
        "The long dead sorcerer Baalga the all-seeing created these boots to enable his long suffering henchman Tzchak to walk long distances carrying immensely heavy loads.",
        "These boots allow the Warrior to ignore any armour-based movement penalties. Furthermore, the Warrior gains +1 to his Movement.",
        "231",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Boots],
        100,
        "images/TreasurePackOneDungeonRoomCard/BootsOfTzchak",
        InventorySlot.Legs
    );

    public static MagicItemData BowOfTorAlessi => new(
        "Bow of Tor Alessi",
        "This white bow was captured by the Dwarfs at the fall of the Elf city Tor Alessi. Its accuracy is beyond compare, and it was considered a prize worthy of the bloodshed and slaughter that won it.",
        "With this bow, a Warrior may fire BEFORE or during moving. This uses up his Attacks as usual.",
        "232",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        250,
        "images/TreasurePackOneDungeonRoomCard/BowOfTorAlessi",
        InventorySlot.TwoHanded
    );

    public static MagicItemData CloakOfLoren => new(
        "Cloak of Loren",
        "This cloak is made of a fine silk-like material that, although extremely light, is very, very strong.",
        "Every time your warrior is hit while wearing the cloak, he can ignore the first wound caused by the blow. However, each time the cloak absorbs damage like this, roll a D6. On the score of a 1, the cloak rips and it is useless.",
        "233",
        [RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Armour],
        75,
        "images/TreasurePackOneDungeonRoomCard/CloakOfLoren.png",
        InventorySlot.Back);

    public static MagicItemData CloakOfDeception => new(
        "Cloak of Deception",
        "This cloak swirls around the Warrior as he moves, deceiving the eye as to his precise location.",
        "While worn, all attacks against the Warrior are at -1 to hit. If an attacker rolls a 6 to hit, the cloak’s power is exhausted until the next adventure.",
        "234",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Armour],
        350,
        "images/TreasurePackOneDungeonRoomCard/CloakOfDeception.png",
        InventorySlot.Back);

    public static MagicItemData CloakOfStealth => new(
        "Cloak of Stealth",
        "This cloak is made of an odd material that is slippery to the touch.",
        "While wearing, the Warrior may automatically break from pinning once per adventure.",
        "235",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Armour],
        100,
        "images/TreasurePackOneDungeonRoomCard/CloakOfStealth.png",
        InventorySlot.Back);

    public static MagicItemData CoughingSpellJewel => new(
        "Coughing Spell Jewel",
        "This jewel contains the power for the Coughing spell.",
        "Pick any Monster on the same board section. On a roll of 6, the target collapses in a coughing spasm and is at -1 to hit for the rest of the turn.",
        "236",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.B },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Amulet],
        50,
        "images/TreasurePackOneDungeonRoomCard/CoughingSpellJewel.png",
        InventorySlot.Neck);

    public static MagicItemData DispelMagicScroll => new(
        "Dispel Magic Scroll",
        "The Warrior raises his hand and shouts words of warding, diffusing his opponent’s magic.",
        "Cast against an incoming spell. On 4–6 the target spell is prevented.",
        "241",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        100,
        "images/TreasurePackOneDungeonRoomCard/DispelMagicScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData DomeOfPower => new(
        "Dome of Power",
        "White power streams from the Warrior’s eyes, forming a protective dome.",
        "Protects up to 4 linked squares. Models inside cannot act but are immune to all forms of attack.",
        "242",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        250,
        "images/TreasurePackOneDungeonRoomCard/DomeOfPower.png",
        InventorySlot.Pouch);

    public static MagicItemData FangedDeathHelm => new(
        "Fanged Death Helm",
        "This helm is fashioned into the likeness of the gaping maw of a ravenous beast.",
        "Once per turn, the warrior wearing the Fanged Death Helm may exchange one of his attakcs for a bite attack. This attack hits automatically for 1D6 Wounds that cannot be reduced.",
        "243",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Helmet],
        250,
        "images/TreasurePackOneDungeonRoomCard/FangedDeathHelm.png",
        InventorySlot.Head);

    public static MagicItemData Firebombs => new(
        "Firebombs (1D6)",
        "The Warriors discover a box of firebombs marked with a skull.",
        "Each firebomb affects a 2x2 square area, dealing 1D6 Wounds to all models inside, ignoring armour and Toughness. Each bomb can be used once.",
        "244",
        [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.W, HeroCode.D, HeroCode.B },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        75,
        "images/TreasurePackOneDungeonRoomCard/Firebombs.png",
        InventorySlot.Pouch);

    public static MagicItemData GlorySpellScroll => new(
        "Glory! Spell Scroll",
        "The Warrior bearing the scroll sends out tendrils of force that fill allies with courage.",
        "All Warriors gain +1 Attack this turn.",
        "245",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        400,
        "images/TreasurePackOneDungeonRoomCard/GlorySpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData Glowstone => new(
        "Glowstone",
        "This small crystal orb holds the light of dawn, glowing like a lantern.",
        "The carrier can explore like the leader with the lantern. If a 1 is rolled in the Power Phase, roll again: on 1–3, the glow dies.",
        "246",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        400,
        "images/TreasurePackOneDungeonRoomCard/Glowstone.png",
        InventorySlot.Pouch);

    public static MagicItemData Gold1D6x50 => new(
        "Gold (1D6x50)",
        "After a thorough search, one of the Warriors finds a leather bag hidden behind a stone.",
        "The bag contains 1D6x50 gold.",
        "246",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        50,
        "images/TreasurePackOneDungeonRoomCard/Gold1D6x50.png",
        InventorySlot.Pouch);

    public static MagicItemData HiddenAlcove => new(
        "Hidden Alcove",
        "After a thorough search, one of the Warriors finds a secret panel opening to reveal a hidden alcove.",
        "Roll as many dice as you like. If any show a 1, you find nothing and must take an Event card immediately. On 2–5, gain gold ×10. Each 6 gives you a Treasure card.",
        "251",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        0,
        "images/TreasurePackOneDungeonRoomCard/HiddenAlcove.png",
        InventorySlot.None);

    public static MagicItemData HolyArtefact => new(
        "Holy Artefact",
        "You find a dusty religious artefact recognized as belonging to one of the temples of the Empire.",
        "At the end of the adventure, roll a D6 to see if you find a temple. On a score of 4+, you find a temple and can sell the artefact for 1D6x100 gold. Roleplay: You may find a temple in any Settlement. If you return this artefact, the temple priests will reward you with. 1D6x100 gold. If you roll a 1 when seeing how much gold you receive, then k./you actually get nothing - it is not an artefact they recognize. You will have to try again in the next Set",
        "252",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        0,
        "images/TreasurePackOneDungeonRoomCard/HolyArtefact.png",
        InventorySlot.Pouch);

    public static MagicItemData LifebringerSpellScroll => new(
        "Lifebringer Spell Scroll",
        "Blazing fire leaps from the Warrior’s eyes, bathing allies in energy that heals their wounds.",
        "Pick any number of Warriors. Roll 1D6 for each; each heals that many Wounds. If two or more dice are the same, the spell fails completely.",
        "253",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackOneDungeonRoomCard/LifebringerSpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData LifestealerTalisman => new(
        "Lifestealer Talisman",
        "The Warrior with this talisman can steal Wounds from a nearby Monster to heal himself.",
        "The warrior with the talisman can steal wounds from a nearby monster to heal himself. One adjacent Monster suffers 1D6 Wounds with no modifiers. The Warrior gains the same number of Wounds up to his starting maximum.",
        "254",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Amulet],
        450,
        "images/TreasurePackOneDungeonRoomCard/LifestealerTalisman.png",
        InventorySlot.Neck);

    public static MagicItemData PearlNecklace => new(
        "Pearl Necklace",
        "The Warriors find a long pearl necklace hidden behind a stone in the wall.",
        "Worth 1D6x10 gold. If selling in a Settlement, roll D6×10. On a roll of 1, the necklace is fake and cannot be sold here.",
        "255",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        0,
        "images/TreasurePackOneDungeonRoomCard/PearlNecklace.png",
        InventorySlot.Pouch);

    public static MagicItemData PitOfDespairScroll => new(
        "Pit of Despair Scroll",
        "White light pours from the Warrior’s mouth, creating a bottomless pit in the stone floor.",
        "Place a pit marker in a 2x2 square. Roll a D6 for every model on the marker. On a 1 or 2, the model falls in the pit and is killed. On a 3-6 it scrambles out of the way - put\r\nit in any empty square on this ;\r\nor any adjacent board section.\r\nIf there are no empty squares E\r\navailable the model falls into\r\nthe pit anyway. Once the pit is\r\nNn place, no model may enter\r\nthe squares it covers.\r\n ",
        "256",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        300,
        "images/TreasurePackOneDungeonRoomCard/PitOfDespairScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfAlchemy => new(
        "Potion of Alchemy",
        "After a careful search, a small glass bottle of fizzing pink liquid is found.",
        "This potion may be sold at an Alchemist’s Laboratory (Special Location). It is worth 1D6x40 gold.",
        "261",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        0,
        "images/TreasurePackOneDungeonRoomCard/PotionOfAlchemy.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfFlight => new(
        "Potion of Flight",
        "The bubbling liquid burns the Warrior’s throat as he drinks it.",
        "After drinking this potion, your warrior levitates a few inches above the ground while moving. The Warrior may pass over chasms and pits unhindered. Enemies attacking him are at -1 to hit. Lasts for one turn.",
        "262",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        250,
        "images/TreasurePackOneDungeonRoomCard/PotionOfFlight.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfInstability => new(
        "Potion of Instability",
        "This potion shifts the dimensional position of your Warrior, making him ethereal and insubstantial.",
        "When drunk, this postion shifts the dimensional position of your warrior, making him ethereal and insubstantial. The Warrior cannot be pinned, attack, cast magic, or be attacked for one turn.",
        "263",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        200,
        "images/TreasurePackOneDungeonRoomCard/PotionOfInstability.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfWeaponMastery => new(
        "Potion of Weapon Mastery",
        "In a pile of broken crates you find a glass phial containing a warm amber liquid.",
        "When drunk, the potion gives your warrior +2 to hit, and causes an extra 2D6 Wounds on attacks. Lasts for one turn.",
        "264",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackOneDungeonRoomCard/PotionOfWeaponMastery.png",
        InventorySlot.Pouch);

    public static MagicItemData RelicBlade => new(
        "Relic Blade",
        "This holy blade is an artefact of great religious significance within the Empire and was reputed to have been used by the realm's mightiest heroes in numerous battles.",
        "While your warrior is using this sword he gets +1 on his to hit roll.",
        "265",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        400,
        "images/TreasurePackOneDungeonRoomCard/RelicBlade.png",
        InventorySlot.MainHand);

    public static MagicItemData RingOfSureSeeing => new(
        "Ring of Sure Seeing",
        "This ring bears a large gem that glows faintly when danger approaches.",
        "If you take an Event card that you don't like you may swap it for another. Shuffle all Event cards together (including used ones) to form a new deck. Draw the top card and continue as normal.",
        "266",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Ring],
        200,
        "images/TreasurePackOneDungeonRoomCard/RingOfSureSeeing.png",
        InventorySlot.Fingers);

    public static MagicItemData RunestoneOfSlaying => new(
        "Runestone of Slaying",
        "The warriors find an ancient item of Dwarf construction inscribed with a glowing rune.",
        "This rune can be burned onto a single blade by touching the stone to the metal. For one attack, the weapon inflicts double damage (before adding Strength). Once per adventure.",
        "311",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        300,
        "images/TreasurePackOneDungeonRoomCard/RunestoneOfSlaying.png",
        InventorySlot.Pouch);

    public static MagicItemData SpellRing => new(
        "Spell Ring",
        "Any Wizard recognizes this as a potent magical ring capable of storing spells.",
        "As soon as your warrior finds the ring, take one spell card at random. This is the spell that is stored in the ring. The bearer of the ring may cast the stored spell automatically at any time. After use, the ring is drained for the rest of the dungeon. RPG: Next adventure, draw a new card for the ring.",
        "312",
        [RuleUsage.Reusable, RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Ring],
        0,
        "images/TreasurePackOneDungeonRoomCard/SpellRing.png",
        InventorySlot.Fingers);

    public static MagicItemData Tankard => new(
        "Tankard",
        "A sturdy Dwarf tankard, specially designed for drinking Bugman’s beer.",
        "Highly valued by Dwarfs. If a Dwarf finds this tankard, he will never sell it.",
        "313",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.D },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        20,
        "images/TreasurePackOneDungeonRoomCard/Tankard.png",
        InventorySlot.None);

    public static MagicItemData UndeadBane => new(
        "Undead Bane",
        "A pot of thick, foul-smelling unguent that can be smeared on a weapon.",
        "When applied, the weapon inflicts +1 Wound per battle level against all Undead. Effect lasts one turn. Enough for one weapon only.",
        "314",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Item],
        50,
        "images/TreasurePackOneDungeonRoomCard/UndeadBane.png",
        InventorySlot.Pouch);

    public static MagicItemData WallOfSteel => new(
        "Wall of Steel",
        "This cool blue steel blade flickers as if alive, creating a deadly shimmering blur.",
        "When used in a corridor or doorway, no Monster may pass the Warrior unless they kill him first, regardless of flying or unpinnable traits.",
        "315",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackOneDungeonRoomCard],
        [MagicItemType.Weapon],
        200,
        "images/TreasurePackOneDungeonRoomCard/WallOfSteel.png",
        InventorySlot.MainHand);


    public static MagicItemData ArrowsOfPiercing => new(
        "Arrows of Piercing",
        "These arrows are made of a curious steel-blue material, strangely light but very strong.",
        "These arrows may be fired from any bow. They are magical and ignore all non-magical armour. Once fired, they are lost. You have D6 arrows.",
        "316",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        300,
        "images/TreasurePackTwoObjectiveRoomCard/ArrowsOfPiercing.png",
        InventorySlot.Pouch);

    public static MagicItemData ArrowsOfSureFlight => new(
        "Arrows of Sure Flight",
        "The shafts of these arrows are straight and true, and their fletching is flawless.",
        "These arrows never miss. If fired, they automatically hit their target. You have 2D6 arrows.",
        "321",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.E },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        100,
        "images/TreasurePackTwoObjectiveRoomCard/ArrowsOfSureFlight.png",
        InventorySlot.Pouch);

    public static MagicItemData Backpack => new(
        "Backpack",
        "A sturdy leather backpack with brass fittings, still in good condition.",
        "The backpack allows your Warrior to carry up to 3 extra Treasure cards. Once the backpack is full, discard it.",
        "322",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackTwoObjectiveRoomCard/Backpack.png",
        InventorySlot.Back);

    public static MagicItemData BaubleOfAnurandel => new(
        "Bauble of Anurandel",
        "A tiny glowing gem, shimmering with an inner light.",
        "The Bauble of Anurandel allows its bearer to automatically dispel one spell of their choice, once per adventure.",
        "323",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Amulet],
        200,
        "images/TreasurePackTwoObjectiveRoomCard/BaubleOfAnurandel.png",
        InventorySlot.Neck);

    public static MagicItemData BootsOfBattle => new(
        "Boots of Battle",
        "Heavy boots, worn and scratched, but still strong.",
        "These boots give the wearer +1 Attack. This bonus lasts as long as the boots are worn.",
        "324",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Boots],
        250,
        "images/TreasurePackTwoObjectiveRoomCard/BootsOfBattle.png",
        InventorySlot.Legs);

    public static MagicItemData BootsOfLeaping => new(
        "Boots of Leaping",
        "A pair of supple leather boots, strangely springy to the touch.",
        "While wearing these boots, your Warrior may leap over one square per turn as part of his normal movement. He may not leap over walls or Monsters larger than man-sized.",
        "325",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Boots],
        400,
        "images/TreasurePackTwoObjectiveRoomCard/BootsOfLeaping.png",
        InventorySlot.Legs);

    public static MagicItemData BugmansXXXXXX => new(
        "Bugman's XXXXXX",
        "A squat bottle filled with Dwarfen ale, brewed by the master himself.",
        "When drunk, this ale restores 2D6 Wounds to your Warrior. After use, the bottle is empty and discarded.",
        "326",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        200,
        "images/TreasurePackTwoObjectiveRoomCard/BugmansXXXXXX.png",
        InventorySlot.Pouch);

    public static MagicItemData ChaosBane => new(
        "Chaos Bane",
        "A small charm carved with unholy runes, reeking of sorcery.",
        "This charm may be used once per adventure. When invoked, it forces all Daemonic Monsters on the board to flee immediately.",
        "331",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        200,
        "images/TreasurePackTwoObjectiveRoomCard/ChaosBane.png",
        InventorySlot.Pouch);

    public static MagicItemData ConfuseSpellScroll => new(
        "Confuse Spell Scroll",
        "Ancient words scrawled across parchment, glowing faintly with sorcerous power.",
        "When read, target any Monster on the board. That Monster may not attack this turn, though it may defend itself normally. DISCARD AFTER USE.",
        "332",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        75,
        "images/TreasurePackTwoObjectiveRoomCard/ConfuseSpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData CrownOfMadness => new(
        "Crown of Madness",
        "A twisted iron crown set with black gems that whisper as you draw near.",
        "Once per adventure, the bearer may place the crown upon his head. Pick any one Monster. That Monster immediately attacks its own side for one turn. Then the crown crumbles to dust. DISCARD AFTER USE.",
        "333",
        [RuleUsage.OncePerDungeon, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.B, HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Helmet],
        250,
        "images/TreasurePackTwoObjectiveRoomCard/CrownOfMadness.png",
        InventorySlot.Head);

    public static MagicItemData CureSmallWoundsSpell => new(
        "Cure Small Wounds Spell",
        "A scroll inked in silver, radiating warmth and healing light.",
        "This scroll heals 1D6 Wounds on any Warrior, including the caster. DISCARD AFTER USE.",
        "334",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        15,
        "images/TreasurePackTwoObjectiveRoomCard/CureSmallWoundsSpell.png",
        InventorySlot.Pouch);

    public static MagicItemData ExoticFoodsOfTilea => new(
        "Exotic Foods of Tilea",
        "A hamper of brightly wrapped delicacies from distant Tilea.",
        "These goods can be sold in town for 1D6×50 gold. RECORD THEN DISCARD.",
        "335",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        50,
        "images/TreasurePackTwoObjectiveRoomCard/ExoticFoodsOfTilea.png",
        InventorySlot.Pouch);

    public static MagicItemData FineClothes => new(
        "Fine Clothes",
        "An ornate set of nobleman’s clothes, adorned with lace and jewels.",
        "1D6 items are found and each is worth 25. Record then discard.",
        "336",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        25,
        "images/TreasurePackTwoObjectiveRoomCard/FineClothes.png",
        InventorySlot.None);

    public static MagicItemData FineElfWine => new(
        "Fine Elf Wine",
        "A delicate glass bottle filled with crystalline liquid of finest Elven vintage.",
        "When drunk, this wine restores 1D6 Wounds. DISCARD AFTER USE.",
        "341",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        100,
        "images/TreasurePackTwoObjectiveRoomCard/FineElfWine.png",
        InventorySlot.Pouch);

    public static MagicItemData FleetOfFootScroll => new(
        "Fleet of Foot Scroll",
        "This scroll glows with a restless, darting light as if eager to be used.",
        "The scroll grants the targeted Warrior +2 Movement this turn. DISCARD AFTER USE.",
        "342",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        25,
        "images/TreasurePackTwoObjectiveRoomCard/FleetOfFootScroll.png",
        InventorySlot.Pouch);


    public static MagicItemData PotionOfBattle => new(
        "Potion of Battle",
        "In a corner you find a small bottle full of a sparkling yellow liquid.",
        "When drunk, the potion gives your Warrior +1 Attack for one turn.",
        "343",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        75,
        "images/TreasurePackTwoObjectiveRoomCard/PotionOfBattle.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfHealing => new(
        "Potion of Healing (1D6 Wounds)",
        "This green bottle contains a sweet smelling liquid with a treacly consistency.",
        "Upon drinking this potion your Warrior regains 1D6 Wounds.",
        "344",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        100,
        "images/TreasurePackTwoObjectiveRoomCard/PotionOfHealing.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfPain => new(
        "Potion of Pain",
        "Amongst the debris and detritus you find a large bottle full of bubbling orange liquid.",
        "When drunk, this potion allows your warrior to ignore wounds from a single blow that might otherwise kill him. In addition, it heals 2D6 of the warrior's wounds.",
        "345",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        300,
        "images/TreasurePackTwoObjectiveRoomCard/PotionOfPain.png",
        InventorySlot.Pouch);

    public static MagicItemData PotionOfStrength => new(
        "Potion of Strength",
        "An intoxicating liquid flows from this bottle, bringing a sense of power and might to whoever drinks it.",
        "After drinking this potion your Warrior gets +1D6 Strength. The effects of the potion last for one turn.",
        "346",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackTwoObjectiveRoomCard/PotionOfStrength.png",
        InventorySlot.Pouch);

    public static MagicItemData QuargHorn => new(
        "Quarg Horn",
        "The Warriors find a very unusual baroque-looking horn, covered with thin gold leaf.",
        "This horn can only be used during the Hunting Settlement Event. Alone in the forest, the Warrior blows the horn. Roll a D6: 1–5 nothing happens; on 6 a fabulous beast bounds out—the Warrior has captured a Quarg and can sell it for 1000G (but no-one will buy the horn). ROLEPLAYING GAME ONLY.",
        "351",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        0,
        "images/TreasurePackTwoObjectiveRoomCard/QuargHorn.png",
        InventorySlot.Pouch);

    public static MagicItemData RingOfPower => new(
        "Ring of Power",
        "This simple band of stone slips easily onto your finger, contracting until it is a perfect fit.",
        "While wearing this ring, one of your Warrior’s characteristics is increased by +1. Choose which characteristic is affected the first time your Warrior puts on the ring.",
        "352",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Ring],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/RingOfPower.png",
        InventorySlot.Fingers);

    public static MagicItemData SpicesFromAraby => new(
        "Spices from Araby",
        "The Warriors find an earthenware pot full of rich spices, and their pungent tang fills the air.",
        "The spices are worth 1D3×100 gold. RECORD THEN DISCARD.",
        "353",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        0,
        "images/TreasurePackTwoObjectiveRoomCard/SpicesFromAraby.png",
        InventorySlot.Pouch);

    public static MagicItemData StoneOfBravery => new(
        "Stone of Bravery",
        "This stone gives great confidence to the bearer, such that fear seems but a dream.",
        "This valuable semi-precious stone is worth 250 gold. (RPG: The bearer gains +1 to Fear rolls and +1 to Terror rolls.)",
        "354",
        [RuleUsage.None],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        250,
        "images/TreasurePackTwoObjectiveRoomCard/StoneOfBravery.png",
        InventorySlot.Pouch);

    public static MagicItemData StoneOfTransmutation => new(
        "Stone of Transmutation",
        "This small stone hangs from a delicate copper chain.",
        "The item may be used to transmute a single Monster into stone, killing it. To determine whether the stone works roll a D6 and add 1 (RPG: roll a D6 and add your battle-level). If the total is greater than the target Monster’s current Wounds it becomes a statue. If the total is equal to or less than the target Monster’s current Wounds the spell fails. USE ONCE, THEN DISCARD.",
        "355",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Amulet],
        0,
        "images/TreasurePackTwoObjectiveRoomCard/StoneOfTransmutation.png",
        InventorySlot.Neck);

    public static MagicItemData StrengthSpellScroll => new(
        "Strength Spell Scroll",
        "The scroll bears the words for the Strength spell. When cast, the targeted Warrior feels renewed energy surging through his aching muscles.",
        "When the scroll is used, pick any Warrior on the board. This turn he is at +1 Strength.",
        "356",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        50,
        "images/TreasurePackTwoObjectiveRoomCard/StrengthSpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData SwordsOfDoomScroll => new(
        "Swords of Doom Scroll",
        "Instead of wielding one sword, a great many blades suddenly start to whirl and slash the air before the Warrior bearing the scroll.",
        "This turn the Warrior bearing the scroll gets 2 extra Attacks. After it has been used, the scroll crumbles into dust and is destroyed. DISCARD AFTER USE.",
        "361",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        200,
        "images/TreasurePackTwoObjectiveRoomCard/SwordsOfDoomScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData HornOfShielding => new(
        "Horn of Shielding",
        "You find a large rusty warhorn hanging from the wall.",
        "When blown, the mystical power of the horn puts up a magical shield around each Warrior, cloaking them in a near impenetrable cowl of raw magic. The Warriors can only be hit by Monsters scoring a 6 to hit. The horn may be blown once per adventure, and its effect lasts for one turn. USE ONCE PER ADVENTURE.",
        "362",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/HornOfShielding.png",
        InventorySlot.Pouch);

    public static MagicItemData HaloOfVengeanceScroll => new(
        "Halo of Vengeance Scroll",
        "The Warrior bearing the scroll casts a glowing halo around himself.",
        "The spell surrounds the Warrior with a protective shield. At the start of each turn roll 1D6. This turn that many Attacks can be absorbed by the halo and may be ignored. The halo remains until the Warrior moves or you roll a 1 on the dice roll to see how many Attacks are absorbed. After one use, the scroll dissolves into a puddle of slime. ONE USE, THEN DISCARD.",
        "363",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        350,
        "images/TreasurePackTwoObjectiveRoomCard/HaloOfVengeanceScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData HealingHandsJewel => new(
        "Healing Hands Jewel",
        "This jewel contains the power for the Healing Hands spell. When used, the Warriors feel a soothing calmness descend upon them.",
        "When the power of this jewel is used, every Warrior on the board has 1 Wound healed. USE ONCE PER ADVENTURE.",
        "364",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        250,
        "images/TreasurePackTwoObjectiveRoomCard/HealingHandsJewel.png",
        InventorySlot.Pouch);

    public static MagicItemData LightOfCourage => new(
        "Light of Courage",
        "This phial is filled with a glowing white liquid, which lights the way in the darkness as the lantern does.",
        "The warrior may move around and explore just as if he carried the lantern. The power of the phial will be exhausted after one adventure, or if the warrior carrying the phial is knocked to zero wounds.",
        "365",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        300,
        "images/TreasurePackTwoObjectiveRoomCard/LightOfCourage.png",
        InventorySlot.Pouch);

    public static MagicItemData ObsidianBlade => new(
        "Obsidian Blade",
        "This sword is made from the solidified blackness of the void, explaining its ability to destroy any armour it touches.",
        "After your Warrior has made an attack using this sword which actually wounded his opponent, roll a D6. On a score of 1–4 the sword has no extra effect. On a score of 5 or 6 the sword ignores and destroys the target’s armour.",
        "366",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Weapon],
        450,
        "images/TreasurePackTwoObjectiveRoomCard/ObsidianBlade.png",
        InventorySlot.MainHand);

    public static MagicItemData OgreSlayer => new(
        "Ogre Slayer",
        "This brutal, broad-bladed axe is a powerful weapon, almost certainly of Dwarf origin.",
        "While using this axe your Warrior gets +2 Strength (+3 if he is a Dwarf).",
        "411",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Axe],
        400,
        "images/TreasurePackTwoObjectiveRoomCard/OgreSlayer.png",
        InventorySlot.MainHand);

    public static MagicItemData InvisibilitySpellScroll => new(
        "Invisibility Spell Scroll",
        "With a shimmer of light, the Warrior’s outline slowly fades until he is completely invisible.",
        "While invisible the Warrior cannot be pinned. No to-hit rolls may be made against him in hand-to-hand combat (he is not there!) and any missile shot will automatically miss. However, he may still be hit by a blow that would normally need a 6 to hit, and spells affect him as normal. At the start of each turn the Warrior must roll a D6. On a 1 the spell is broken; on 2–6 it remains in force. The spell expires automatically at the end of the turn in which it is used. DISCARD AFTER USE.",
        "412",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackTwoObjectiveRoomCard/InvisibilitySpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData IronSkinSpellScroll => new(
        "Iron Skin Spell Scroll",
        "By the power of raw magic, the Warrior’s flesh turns to iron.",
        "Roll a D6 and add that many points to the Warrior’s Toughness for the turn. Any damage in excess of this temporary Toughness is lost and does not carry over or reduce his normal Toughness. A Warrior’s Toughness may never be increased by more than +6 in this fashion. DISCARD AFTER USE.",
        "413",
        [RuleUsage.OneUseOnly, RuleUsage.DiscardAfterUse],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        100,
        "images/TreasurePackTwoObjectiveRoomCard/IronSkinSpellScroll.png",
        InventorySlot.Pouch);

    public static MagicItemData IconOfCombat => new(
        "Icon of Combat",
        "The redstone icon is chillingly cold to the touch.",
        "When used, this icon allows your Warrior to shove a Monster out of his way. Roll a 1D6 and add your Warrior’s Strength. If the total is less than or equal to the Monster’s Strength it is too big to move and your Warrior fails. If the total is greater than the Monster’s Strength it is pushed back into any one of the three squares behind it that is unoccupied. Having pushed his foe back, your Warrior moves into the square that was occupied by the Monster and may now make his normal attack. ONE USE PER ADVENTURE.",
        "414",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackTwoObjectiveRoomCard/IconOfCombat.png",
        InventorySlot.Pouch);


    public static MagicItemData GobletOfVitality => new(
        "Goblet of Vitality",
        "This goblet is suffused in a brilliant golden aura, which expans to fill the area, flooding it with bright light.",
        "Each warrior on the board section regains 3 wounds.",
        "415",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        200,
        "images/TreasurePackTwoObjectiveRoomCard/IconOfCombat.png",
        InventorySlot.Pouch);

    public static MagicItemData IconOfDetermination => new(
        "Icon of Determination",
        "This small jeweled icon gleams with a cold light",
        "This small icon may be placed upon a shield melding itself ith the surface. When used, this icon allows your warrior yo catch the impact of a single blow on his shield, deflecting all the damage that may have been caused.",
        "416",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.B },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        300,
        "images/TreasurePackTwoObjectiveRoomCard/IconOfCombat.png",
        InventorySlot.Pouch);

    public static MagicItemData OgreStrengthScroll => new(
        "Ogre Strength Scroll",
        "Calling on the forces of magic the warrior bearing the scroll uses the power to increase the target's strength fourfold.",
        "Pick any warrior on the board. This turn the chosen warrior is at +2 strength for the purpose of resolving damage.",
        "421",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        150,
        "images/TreasurePackTwoObjectiveRoomCard/IconOfCombat.png",
        InventorySlot.Pouch);

    public static MagicItemData OrbOfPower => new(
        "Orb of Power",
        "You find a glittering Silver orb, which exudes a distinctive magical aura.",
        "This orb comes charged with 1D6 points of Power. These points of power are used to augment the Wizard's spellcasting ability as normal. Once used, the orb is useless and worthless. RPG: The wizard can recharge the orb at the Pond of Power, just like the wizard's staff.",
        "421",
        [RuleUsage.Reusable],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.TreasurePackTwoDungeonRoomCard],
        [MagicItemType.Item],
        500,
        "images/TreasurePackTwoObjectiveRoomCard/IconOfCombat.png",
        InventorySlot.Pouch);

    public static MagicItemData AbandonedBackpack => new(
        "Abandoned Backpack",
        "After searching the area, one of the Warriors finds a scruffy looking backpack of the kind often used by adventurers.",
        "In the backpack there are 1D3 items of treasure. Take this many Treasure cards immediately to see what the Warriors have discovered. The Warrior who gets this card can keep all 1D3 items for himself, and they count as one item for the purposes of divvying out treasure.",
        "422",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackTwoDungeonRoomCard },
        new[] { MagicItemType.Item },
        0,
        "images/TreasurePackTwoObjectiveRoomCard/AbandonedBackpack.png",
        InventorySlot.None
    );


    public static MagicItemData AmuletOfFury => new(
        "Amulet of Fury",
        "At the heart of this crystal amulet magical fire rages.",
        "This amulet allows a Warrior who is not a Wizard to cast a spell. If your Warrior gets the amulet take a spell card at random. He may cast that spell once per turn, rolling equal to or over its casting number on 1D6 to do so. After successful use, the amulet disintegrates!",
        "423",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Amulet },
        200,
        "images/TreasurePackThreeDungeonRoomCard/AmuletOfFury.png",
        InventorySlot.Neck
    );

    public static MagicItemData AmuletOfVindication => new(
        "Amulet of Vindication",
        "This antiquated porcelain amulet is covered in a layer of cracked and peeling black leather.",
        "This amulet allows the Warrior to cancel out hostile magic. When a spell is cast against the bearer of the amulet, roll a D6. On a roll of 6 the spell is cancelled out and has no effect. (RPG: This amulet gives the Warrior a magic resistance of 6+. This works in the same way as the Magical Resistance ability that some Monsters possess.) The amulet may be used every time a spell is cast at the Warrior.",
        "424",
        new[] { RuleUsage.UnlimitedUses },
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Amulet },
        500,
        "images/TreasurePackThreeDungeonRoomCard/AmuletOfVindication.png",
        InventorySlot.Neck
    );

    public static MagicItemData BagOfGold1D6x25 => new(
        "Bag of Gold (1d6x25)",
        "Opening the bag, he finds it contains a number of gold pieces.",
        "The leather bag contains 1D6x25 gold.",
        "425",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        25,
        "images/TreasurePackThreeDungeonRoomCard/BagOfGold1D6x25.png",
        InventorySlot.None
    );

    public static MagicItemData BlessedSword => new(
        "Blessed Sword",
        "Cooled in the waters of the Temple of Ulric, this sword is a powerful weapon of purity.",
        "While your Warrior is using this sword he only misses his opponent if his to hit roll is a 1 or a 2.",
        "426",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Weapon },
        300,
        "images/TreasurePackThreeDungeonRoomCard/BlessedSword.png",
        InventorySlot.MainHand
    );

    public static MagicItemData BloodPulseSpellScroll => new(
        "Blood Pulse Spell Scroll",
        "A dull throbbing fills the room as it becomes suffused with a red glow.",
        "The Warrior bearing the scroll immediately regains 1D6 Wounds.",
        "431",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D, HeroCode.E, HeroCode.W },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        75,
        "images/TreasurePackThreeDungeonRoomCard/BloodPulseSpellScroll.png",
        InventorySlot.Pouch
    );

    public static MagicItemData BoneBlade => new(
        "Bone Blade",
        "This magical blade is made from a bleached white substance that looks like bone, but is as sharp as steel.",
        "Your Warrior may use this sword once per adventure. If his attack hits, the sword causes 2D6+ his Strength Wounds. (RPG: For one turn per adventure, the Warrior may trade in all his normal attacks and use this sword to make a single attack that causes normal damage + (1D6 x his battle-level) extra Wounds.)",
        "432",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Weapon },
        400,
        "images/TreasurePackThreeDungeonRoomCard/BoneBlade.png",
        InventorySlot.MainHand
    );

    public static MagicItemData BowOfTiranoc => new(
        "Bow of Tiranoc",
        "This mighty bow was crafted by the Elves of Tiranoc from a single Starwood branch. When the land of Tiranoc was engulfed by the sea, the bow was carried to the Old World, a fabled treasure of a kingdom destroyed.",
        "This bow is very powerful and causes an extra 3 Wounds every time it strikes.",
        "433",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Bow },
        300,
        "images/TreasurePackThreeDungeonRoomCard/BowOfTiranoc.png",
        InventorySlot.TwoHanded
    );

    public static MagicItemData DestroyMagicScroll1 => new(
        "Destroy Magic Scroll",
        "This piece of crisp white parchment rustles and crackles, silver lettering shifting across the page as you try and read it.",
        "This scroll allows the Wizard to automatically dispel and destroy any one spell cast against him or his companions. (RPG: By destroying the spell the Wizard prevents the target from ever casting it again. If you roll a destroyed spell on a Monster's Spell Table when determining which spell it casts, roll again.)",
        "434",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.W },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        350,
        "images/TreasurePackThreeDungeonRoomCard/DestroyMagicScroll1.png",
        InventorySlot.None
    );

    public static MagicItemData DwarfPick => new(
        "Dwarf Pick",
        "The Warriors find an old but serviceable pick, as used by Dwarf miners.",
        "You may use the pick to dig your way through a cave-in. It takes 1D6 turns to clear a way through the rubble. After each successful use, roll a D6. On a roll of a 1 the pick breaks, and must be discarded.",
        "435",
        new[] { RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.D },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Axe },
        125,
        "images/TreasurePackThreeDungeonRoomCard/DwarfPick.png",
        InventorySlot.MainHand
    );

    public static MagicItemData EltharionsBow => new(
        "Eltharion's Bow",
        "This bow is enchanted with Elf magic that makes it much more accurate.",
        "While your Warrior is using this bow he gets +1 to hit.",
        "436",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Bow },
        200,
        "images/TreasurePackThreeDungeonRoomCard/EltharionsBow.png",
        InventorySlot.TwoHanded
    );


    public static MagicItemData FleshWormScroll => new(
        "Flesh Worm Scroll",
        "The scroll bears the words for a Flesh Worm spell. When cast, a small glowing worm appears, hurls itself at a monster and burrows into its flesh.",
        "Pick a Monster on the same board section as the Warrior with the scroll. The Monster is attacked by a Flesh Worm, losing 1 Wound with no modifiers for anything (Toughness, armour). At the start of every further turn, roll 1D6. On a score of 1-4, the Flesh Worm dies. On a score of 5 or 6 it continues to feed and the victim takes another 1 Wound.",
        "531",
        new[] { RuleUsage.OncePerTurn },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        50,
        "images/TreasurePackThreeDungeonRoomCard/FleshWormScroll.png",
        InventorySlot.Pouch
    );

    public static MagicItemData GlitteringRobeScroll => new(
        "Glittering Robe Scroll",
        "The scroll bears the words for the Confuse spell. The Warrior bearing the scroll creates a robe of magical energy that shimmers and glitters about him as he moves.",
        "This spell creates a cloak of magical energy around the Warrior bearing the scroll, which can absorb 1D6 Wounds.",
        "532",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        150,
        "images/TreasurePackThreeDungeonRoomCard/GlitteringRobeScroll.png",
        InventorySlot.Pouch
    );

    public static MagicItemData HolyWater => new(
        "Holy Water",
        "The Warriors find a glass phial of glowing water, probably dropped by a Witch Hunter in the heat of combat.",
        "When thrown (making a normal BS roll to hit, and assuming the Warrior can see his target), it causes 1D6 Wounds to the Monster it hits, and 1D3 Wounds to any adjacent squares. No deductions at all may be made.",
        "533",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        250,
        "images/TreasurePackThreeDungeonRoomCard/HolyWater.png",
        InventorySlot.Pouch
    );

    public static MagicItemData HornOfResilience => new(
        "Horn of Resilience",
        "You find a brass horn in a small wooden casket.",
        "When blown, the magical power of this allows all the Warriors to enter a self-induced hypnotic trance and heal themselves. One turn, during which your Warrior may do nothing else. At the end of the turn your Warrior regains 1D6 Wounds. The horn may be blown once per adventure.",
        "534",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        350,
        "images/TreasurePackThreeDungeonRoomCard/HornOfResilience.png",
        InventorySlot.None
    );

    public static MagicItemData IconOfAgility => new(
        "Icon of Agility",
        "This sturdy jewelled icon twists and turns in the hand of its bearer.",
        "Use once per turn.",
        "535",
        new[] { RuleUsage.OncePerTurn },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        200,
        "images/TreasurePackThreeDungeonRoomCard/IconOfAgility.png",
        InventorySlot.Pouch
    );

    public static MagicItemData Javelin => new(
        "Javelin",
        "You find a slender, silver javelin concealed behind a pile of old rags. It bears magical sigils and glitters in the darkness.",
        "This javelin may be thrown as a Strength 4 missile weapon. If the target is successfully hit, and is standing directly in front of, and adjacent to a wall, roll an extra 1D6 after rolling for damage. If the score is 1-4 the javelin simply causes normal damage. On a score of 5 or 6 the javelin causes normal damage and pins the target to the wall. The target may do nothing for the rest of this turn as it struggles to free itself. After combat, the Warrior may retrieve the javelin.",
        "536",
        new[] { RuleUsage.Permanent, RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Weapon },
        200,
        "images/TreasurePackThreeDungeonRoomCard/Javelin.png",
        InventorySlot.MainHand
    );

    public static MagicItemData LuckstoneOfAnurandel => new(
        "Luckstone of Anurandel",
        "Anurandel was a Wood Elf Sorceress, renowned for her peaceful demeanour, sunny disposition and hatred of battle. She fashioned many items to aid her followers should they be assailed by dark forces.",
        "This plain, smooth stone bears an elf rune. It allows the bearer to reroll any one dice roll once per adventure.",
        "541",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.B, HeroCode.E, HeroCode.W },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        150,
        "images/TreasurePackThreeDungeonRoomCard/LuckstoneOfAnurandel.png",
        InventorySlot.Pouch
    );

    public static MagicItemData Map => new(
        "Map",
        "After a thorough search, one of the Warriors finds a tightly sealed wooden tube.",
        "The tube contains an ancient map of the dungeon. From looking at the map, you can see that there is a secret door leading out of the next room you come to. In the next room, place an extra door on one of the free walls. Through the door is a single dungeon room. When the Warriors enter the room, take 2 Event cards. Once the events are completed, the Warriors gain 2 Treasure items on top of any they gain for killing any Monsters in the room.",
        "542",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        10,
        "images/TreasurePackThreeDungeonRoomCard/Map.png",
        InventorySlot.Pouch
    );

    public static MagicItemData PotionOfEndurance => new(
        "Potion of Endurance",
        "Amongst the debris and detritus you find a small but heavy bottle full of a sluggish, orange liquid.",
        "When drunk, this potion allows your Warrior to ignore the Wounds from a single blow that might otherwise kill him. Use once, then discard.",
        "543",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        300,
        "images/TreasurePackThreeDungeonRoomCard/PotionOfEndurance.png",
        InventorySlot.Pouch
    );

    public static MagicItemData PotionOfFlying => new(
        "Potion of Flying",
        "In a corner you find a thick-necked bottle in which a golden liquid can be seen.",
        "When drunk, this potion causes your Warrior to fly for one turn. While airborne, he moves at 1D6+2 squares, can fly over all obstacles, and cannot be pinned. If he is in contact with a Monster at the end of his flight, he may attack it.",
        "544",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        150,
        "images/TreasurePackThreeDungeonRoomCard/PotionOfFlying.png",
        InventorySlot.Pouch
    );

    public static MagicItemData PotionOfKeensight => new(
        "Potion of Keensight",
        "In a dark corner you find a glass bottle decorated with a small magical icon. The bottle is full of a fiery yellow liquid.",
        "This potion gives your Warrior the ability to make a number of missile attacks equal to his Attacks characteristic, rather than the standard one shot per turn. The pot only contains enough potion for one dose.",
        "545",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        250,
        "images/TreasurePackThreeDungeonRoomCard/PotionOfKeensight.png",
        InventorySlot.Pouch
    );

    public static MagicItemData PotionOfLightningBlades => new(
        "Potion of Lightning Blades",
        "You find a tiny glass bottle full of a purple, bitter liquid.",
        "When drunk, this potion gives your Warrior +1 to hit (RPG: +1 to hit per battle-level) for the duration of one turn.",
        "546",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        500,
        "images/TreasurePackThreeDungeonRoomCard/PotionOfLightningBlades.png",
        InventorySlot.Pouch
    );


    public static MagicItemData PotionOfToughness => new(
        "Potion of Toughness",
        "In a corner you find a shining bottle full of a thick purple liquid.",
        "When drunk, this potion gives your Warrior +1 Toughness for one turn.",
        "551",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        75,
        "images/TreasurePackThreeDungeonRoomCard/PotionOfToughness.png",
        InventorySlot.Pouch
    );

    public static MagicItemData PotionOfWaterWalking => new(
        "Potion of Water Walking",
        "This effervescent liquid has a salty tang reminiscent of the sea.",
        "After drinking this potion your Warrior can walk over areas of water at a rate of (3 x his normal Movement) squares per turn. The potion is effective for one turn.",
        "552",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        100,
        "images/TreasurePackThreeDungeonRoomCard/PotionOfWaterWalking.png",
        InventorySlot.Pouch
    );

    public static MagicItemData ProtectionRing => new(
        "Protection Ring",
        "This small ring has the image of a shield engraved on its uppermost surface.",
        "While wearing the ring, your warrior gets +1 Toughness.",
        "553",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Ring },
        300,
        "images/TreasurePackThreeDungeonRoomCard/ProtectionRing.png",
        InventorySlot.Fingers
    );

    public static MagicItemData RapidFireBracelets => new(
        "Rapid Fire Bracelets",
        "These bracelets were created by the Elves to complement the fabled Silver Band of Loren.",
        "These bracelets give your Warrior +1 Attacks per turn with a missile weapon.",
        "554",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        450,
        "images/TreasurePackThreeDungeonRoomCard/RapidFireBracelets.png",
        InventorySlot.Hands
    );

    public static MagicItemData RingOfInvisibility => new(
        "Ring of Invisibility",
        "As soon as you slip this ring onto your finger you fade from sight.",
        "While wearing this ring your Warrior is invisible and therefore cannot be attacked. He may fight as normal. The invisibility lasts for one turn and the ring may be used once per adventure.",
        "555",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.B, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Ring },
        200,
        "images/TreasurePackThreeDungeonRoomCard/RingOfInvisibility.png",
        InventorySlot.Fingers
    );

    public static MagicItemData RuneOfDestruction => new(
        "Rune of Destruction",
        "The warriors find an ancient item of Dwarf construction: A stone inscribed with a glowing rune.",
        "This rune can be burned onto a single blade by touching the stone to the metal. From now on, the rune allows the wielder of the weapon to double his number of Attacks once per adventure.",
        "556",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        400,
        "images/TreasurePackThreeDungeonRoomCard/RuneOfDestruction.png",
        InventorySlot.Pouch
    );

    public static MagicItemData RunestoneOfDeath => new(
        "Runestone of Death",
        "",
        "This rune can be burned onto a single blade by touching the stone to the metal. Once during each adventure, when using this weapon, you may roll an extra 2D6 when determining damage.",
        "561",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.B, HeroCode.D, HeroCode.W },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        250,
        "images/TreasurePackThreeDungeonRoomCard/RunestoneOfDeath.png",
        InventorySlot.Pouch
    );

    public static MagicItemData RunestoneOfMagic => new(
        "Runestone of Magic",
        "The warriors find an ancient item of Dwarf construction: A stone inscribed with a glowing rune. ",
        "This rune can be burned onto a single blade by touching the stone to the metal. The rune glows dully, and keeps the blade sharp. From now on this weapon is treated as being magical.",
        "562",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        25,
        "images/TreasurePackThreeDungeonRoomCard/RunestoneOfMagic.png",
        InventorySlot.Pouch
    );

    public static MagicItemData SalveOfStrength => new(
        "Salve of Strength",
        "In a corner you find a stoppered jade-stone phial containing a glittering bronze salve.",
        "This salve gives your Warrior +1 Strength for 1D6 turns. There is only enough salve in the phial for one application.",
        "563",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.B, HeroCode.D },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        100,
        "images/TreasurePackThreeDungeonRoomCard/SalveOfStrength.png",
        InventorySlot.Pouch
    );

    public static MagicItemData Stonebread => new(
        "Stonebread",
        "Dwarf stonebread is exactly what its name suggests - bread with the consistency of stone.",
        "Only a Dwarf would ever consider eating stonebread, and they take a gruff satisfaction in the fact that only they can eat the stuff. Eating stonebread is obviously no quick task. If a Dwarf does nothing for a turn, except chew his way through a piece of stonebread, at the end of the Warriors' Phase he regains 1D6 Wounds. You find 1D6 pieces.",
        "564",
        new[] { RuleUsage.Reusable },
        new List<HeroCode> { HeroCode.D },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        30,
        "images/TreasurePackThreeDungeonRoomCard/Stonebread.png",
        InventorySlot.Pouch
    );

    public static MagicItemData SwordOfMight => new(
        "Sword of Might",
        "This sword is imbued with the strength of an ogre, and any blow struck with it delivers that power to the target.",
        "While your Warrior is using this sword he gets +1 Strength.",
        "565",
        new[] { RuleUsage.Permanent },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Weapon },
        150,
        "images/TreasurePackThreeDungeonRoomCard/SwordOfMight.png",
        InventorySlot.MainHand
    );

    public static MagicItemData WindowOfTheVoidScroll => new(
        "Window of the Void Scroll",
        "The scroll creates a dark portal that hypnotically attracts Monsters.",
        "The hole is created in any empty square the Warrior can see. Once the hole is active, roll 1D6 for each Monster adjacent to it. On a score of 1-4 that Monster stands its ground and may ignore the hole. On a score of 5-6 the Monster is hypnotically attracted to the hole, steps through it and vanishes. At the end of the turn the hole disappears with a crack. Warriors are not affected by the hole and can ignore it, but they cannot enter that square.",
        "566",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        400,
        "images/TreasurePackThreeDungeonRoomCard/WindowOfTheVoidScroll.png",
        InventorySlot.Pouch
    );

    public static MagicItemData WinesOfBretonnia => new(
        "Wines of Bretonnia",
        "The Bretonnians are second only to the Elves of Ulthuan when it comes to the creation of fine wines, and their best vintages fetch a high price throughout the world.",
        "The Warriors find 1D6 unopened bottles of 100-year old wine, a spectacular find indeed! Each bottle is worth 100 gold.",
        "611",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        100,
        "images/TreasurePackThreeDungeonRoomCard/WinesOfBretonnia.png",
        InventorySlot.Pouch
    );

    public static MagicItemData WingsOfPowerScroll => new(
        "Wings of Power Scroll",
        "Leathery wings sprout from the Warrior's back, lifting him into the air.",
        "This spell allows the warrior bearing the scroll to fly. While in the air a Warrior moves normally and may ignore any ground-based obstacles such as chasms or pits. He may not make any attacks, and is immune to all attacks except those from missile weapons or of a magical nature. The spell lasts for one whole turn.",
        "612",
        new[] { RuleUsage.DiscardAfterUse },
        new List<HeroCode> { HeroCode.D, HeroCode.W, HeroCode.E },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        100,
        "images/TreasurePackThreeDungeonRoomCard/WingsOfPowerScroll.png",
        InventorySlot.Pouch
    );

    public static MagicItemData WizardsStaff => new(
        "Wizard's Staff",
        "A gnarled, old oak-wooden staff that still holds some stored magic...",
        "The Wizard may use the staff in hand-to-hand combat at -1 to his to hit roll. It causes (1D6+ the Wizard's Strength) Wounds to the target. It can also be wielded defensively, giving the Wizard +1 Toughness while he carries it. The Wizard's Staff is inherently magical and once per adventure you can use it in the Power Phase to re-roll the Wizard's Power (and avoid an Unexpected Event!). A Wizard's Staff comes with 1 point of Power already stored in it, which the Wizard can use in the same way as his Power Tokens.",
        "613",
        new[] { RuleUsage.OncePerDungeon },
        new List<HeroCode> { HeroCode.W },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Weapon },
        0,
        "images/TreasurePackThreeDungeonRoomCard/WizardsStaff.png",
        InventorySlot.MainHand
    );

    public static MagicItemData PreciousIcon => new(
        "Precious Icon",
        "After a thorough search, one of the warriors finds a small metal casket.",
        "The casket contains an icon which belongs to the elders of a far distant village. After the adventure, you may sell the icon back to the elders for 1D6 x 200 gold. RPG: Obviously, the warriors must first visit the village to claim their reward!",
        "614",
        new[] { RuleUsage.OneUseOnly },
        new List<HeroCode> { HeroCode.All },
        new[] { TreasureType.TreasurePackThreeDungeonRoomCard },
        new[] { MagicItemType.Item },
        0,
        "images/TreasurePackThreeDungeonRoomCard/PreciousIcon.png",
        InventorySlot.Pouch
    );


    public static MagicItemData AmuletOfCharadris => new(
        "Amulet of Charadris",
        "Charadris was a Priest of Sigmar who abhorred magic in all its forms, believing that his faith in Sigmar was the greatest power of all.",
        "Any Undead Monster with the Regenerate ability standing next to the Warrior may only regenerate half the number of wounds they normally do (rounding fractions down).",
        "611",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All }, // all warriors
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        300,
        "images/CatacombsOfTerrorTreasureCard/AmuletOfCharadris.png",
        InventorySlot.Neck
    );

    public static MagicItemData AxeOfKhemri => new(
        "Axe of Khemri",
        "This magic axe was forged many centuries ago by the Priest Kings of the ancient realm of Khemri. It is a mighty weapon with a pure white blade. When their kingdom fell, the axe was lost, presumed destroyed.",
        "The axe confers the same Strength bonus as the axe carried by the Dwarf and follows the same rules (roll an extra dice for wounds, and choose the highest score). In addition, when used against Undead, the wielder gains +1 to hit. (RPG – the abilities of this axe cannot be added to in any way, such as runes, etc.)",
        "612",
        [RuleUsage.UnlimitedUses],
        new List<HeroCode> { HeroCode.All }, // all warriors
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Weapon],
        300,
        "images/CatacombsOfTerrorTreasureCard/AxeOfKhemri.png",
        InventorySlot.MainHand
    );

    public static MagicItemData BlessedGem => new(
        "Blessed Gem",
        "This huge ruby has been empowered with warding spells engraved into it by the wizards of the Empire.",
        "The ruby can be used to dispel a Necromantic spell. When the spell is cast, roll a dice. On a roll of 4+, the spell has no effect. Wizards only.",
        "613",
        [RuleUsage.UnlimitedUses],
        new List<HeroCode> { HeroCode.W },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        350,
        "images/CatacombsOfTerrorTreasureCard/BlessedGem.png",
        InventorySlot.Pouch
    );

    public static MagicItemData ChaliceOfVigour => new(
        "Chalice of Vigour",
        "This chalice is one of the legendary artifacts created by the Priest King Alcadizzar. Much sought after by Witch Hunters, the chalice is filled with a golden liquid which never dims or dries up.",
        "Once per adventure, the Warriors may inhale the pungent vapours that rise from the bubbling golden liquid. For the duration of the next combat, on a roll of a 6 to hit, the Warriors will cause an extra 1D3 Wounds against their enemies. Use once per adventure.",
        "614",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        300,
        "images/CatacombsOfTerrorTreasureCard/ChaliceOfVigour.png",
        InventorySlot.Pouch
    );

    public static MagicItemData HelmOfAlcadizzar => new(
        "Helm of Alcadizzar",
        "This glittering helmet was worn by Alcadizzar as he rode into battle against the Undead hordes. It is said that the helm had the magical ability to store the light of the sun, and the Undead would flee in terror from the blazing figure of Alcadizzar as he galloped across the battlefield.",
        "The helm illuminates the dungeon just like the lantern. It adds +1 to the wearer's Toughness, and any Undead are at -1 to hit the wearer.",
        "615",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Armour],
        450,
        "images/CatacombsOfTerrorTreasureCard/HelmOfAlcadizzar.png",
        InventorySlot.Head
    );

    public static MagicItemData TheKingshieldOfTilea => new(
        "The Kingshield of Tilea",
        "King Esteban of Estalia won a famous battle against the Undead of Lahmia, and attributed his legendary invulnerability to the shield he bore. Its past is shrouded in mystery, but the kings of Tilea have always carried it into battle.",
        "The shield adds +1 to the wearer's Toughness, and once per adventure will negate the effect of a single attack or spell that would otherwise wound the bearer.",
        "616",
        [RuleUsage.UnlimitedUses],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Armour],
        200,
        "images/CatacombsOfTerrorTreasureCard/TheKingshieldOfTilea.png",
        InventorySlot.OffHand
    );

    public static MagicItemData OrbOfSigmar => new(
        "Orb of Sigmar",
        "The Grand Theologist Wilhelm used this sparkling orb in his battle against the Vampire Count Vlad von Carstein.",
        "When the power of the Orb is invoked, no Necromantic magic may be used by any model on the same board section for the next 1D6 turns. Use once per adventure.",
        "621",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        400,
        "images/CatacombsOfTerrorTreasureCard/OrbOfSigmar.png",
        InventorySlot.Pouch
    );

    public static MagicItemData SilverStone => new(
        "Silver Stone",
        "The Silver Stone imbues a weapon it touches with magical powers.",
        "The stone may be used once to permanently enchant a single weapon. The affected weapon is now magical and causes an extra D6 wounds on a to hit roll of a 6. Use once and discard.",
        "622",
        [RuleUsage.OneUseOnly],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        200,
        "images/CatacombsOfTerrorTreasureCard/SilverStone.png",
        InventorySlot.Pouch
    );

    public static MagicItemData StoneIconOfGhamaluk => new(
        "Stone Icon of Ghamaluk",
        "Ghamaluk was a grand vizier of Araby, and created a series of stone icons specifically to combat the Undead hordes amassed against him. Many of these icons have passed into the hands of the famous Witch Hunter Gunter Grafftag of Sylvania.",
        "This icon has the power to heal the bearer back to his starting wounds once per adventure. Use once per adventure.",
        "623",
        [RuleUsage.OncePerDungeon],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        200,
        "images/CatacombsOfTerrorTreasureCard/StoneIconOfGhamaluk.png",
        InventorySlot.Pouch
    );

    public static MagicItemData TalismanOfAlcadizar => new(
        "Talisman of Alcadizar",
        "This talisman protected a great Priest King against the decaying magic of the evil Liche Lord Nagash himself.",
        "Any Warrior bearing this talisman is immune to the effects of a Necromantic spell on a dice roll of 5+ per spell. Other Warriors are affected as normal.",
        "624",
        [RuleUsage.Permanent],
        new List<HeroCode> { HeroCode.All },
        [TreasureType.CatacombsOfTerrorTreasureCard],
        [MagicItemType.Item],
        500,
        "images/CatacombsOfTerrorTreasureCard/TalismanOfAlcadizar.png",
        InventorySlot.Neck
    );


    public static MagicItemData? GetMagicItemByName(string name)
    {
        var type = typeof(DungeonRoomTreasureCardsLibrary);
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