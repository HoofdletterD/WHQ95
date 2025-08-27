using WHQCore.Models;

namespace WHQCore.Heroes.DwarfSoldier;

public static class DwarfSoldierSkillsLibrary
{
    public static Skill RunicItems = new(
        "Runic Items",
        "At the runesmith, Dwarfs can inscribe items with powerful runes, and the stronger they become, the more runes can be placed.",
        "Dwarf Runes enable the Dwarfs to temper and bind magical essence in the fires of their forges. Especially powerful runes include the awesome master runes and certain secret runes known only to the runesmiths of the temple of Grungni, Grimnir and Valaya. Inscribed into a weapon, the rune may glow or flash, especially when it is unsheathed for battle and although most will fade over time, hundreds or thousands of years, the eternal runes never fade. ",
        "A Dwarf may only ever have two runes per Battle-level inscribed on each of his weapons at the Runesmith, though subject to this limit one or more of the runes may be the same type. A Battle-level 5 Dwarf, for instance, may have a maximum of 10 runes inscribed on each of his weapons, even though up to all ten on a single weapon may be identical.",
        categories: ["Combat", "Buff"],
        value: "Default",
        imagePath: "images/skills/berserk_icon.png"
    );
    
    public static Skill MightyBlow = new(
        "Mighty Blow",
        "Trade attacks for more power",
        "Putting all of your strength behind your blow, you bring your weapon crashing down on your opponent's body.",
        "For each attack your warrior gives up, they may re-roll an extra 1d6 wounds on one of his remaining attacks. You must declare that your warrior is using this skill before rolling to hit. May only be used once per turn.",
        categories: ["combat", "Buff"],
        value: "2",
        imagePath: "images/skills/MightyBlow_icon.png"
    );

    public static Skill KillingBlow = new(
        "Killing Blow",
        "Aim your weapon just right to do some additional damage.",
        "You judge the moment to strike perfectly and your blade slips through your opponent's armour, spearing his vital organs.",
        "This skill allows your Warrior to cause an extra 2 Wounds on his opponent if his to hit roll was a natural 6.", 
        categories: ["Combat", "Buff"],
        value: "3",
        imagePath: "images/skills/KillingBlow.png"
    );

    public static Skill Enraged = new(
        "Enraged",
        "Getting Angry to possibly gain more attacks.",
        "Your blade cuts a red swathe through your enemies as you charge into combat in the grip of a boiling fury.",
        "Once per turn, just before your Warrior makes his attacks, you may roll 1D6 on the following table: 1: Your Warrior is so enraged that all his attacks go wild, and he hits nothing this turn. 2-4: Your Warrior is very angry, but it has little effect on his attacks this turn. He fights as normal. 5-6: Your Warrior is completely enraged and gets +1D6 Attacks this turn, but with a -1 to hit on each Attack as he is so out of control.", 
        categories: ["Combat", "Buff"],
        value: "4",
        imagePath: "images/skills/Enraged.png"
    );

    public static Skill Endure = new(
        "Endure",
        "Once per dungeon, ignore a single blow.",
        "The Monster's attack carves a wound in your chest an inch deep, but summoning your reserves of willpower, you grit your teeth and ignore the terrible pain.",
        "This skill allows your Warrior to ignore the Wounds from a single blow that might otherwise kill him. This skill may be used once per dungeon.", 
        categories: ["Movement", "Buff"],
        value: "5",
        imagePath: "images/skills/Endure.png"
    );

    public static Skill Stonemaster = new(
        "Stonemaster",
        "Making it easier to find secrets in the dungeon.",
        "Running your fingers along the wall you find the tell-tale concealed hinge of a secret door.",
        "This skill allows your Warrior to identify secret doors in the dungeon walls. Each time your Warrior checks a room or corridor roll 1D6 on the following table: 1: Collapse. Roll 1D6 for each Warrior on the board section, adding his Initiative to the score. If the total is less than 7 that Warrior suffers 2D6 Wounds with no modifiers for Toughness or armour. Note that this collapse does not block the board section. 2-4: Nothing. 5: Secret Door. Your Warrior finds a secret door in one of the walls (your choice) leading to a dungeon room. 6: Very Secret Door. Your Warrior finds a secret door in one of the walls (your choice) leading to an objective room. This skill may be used once on each board section and only when there are no Monsters on the board. Each dungeon only ever contains one secret door, so once it is found there is no further point using this skill (unless a Dungeon Master is in play)", 
        categories: ["Exploration", "Buff"],
        value: "6",
        imagePath: "images/skills/Stonemaster.png"
    );

    public static Skill Deathsong = new(
        "Deathsong",
        "Get back from the brink of death.",
        "Before the fatal blow falls you start to bellow the lament that is your family's deathsong. drawing upon its history and meaning to sustain you.",
        "This skill allows your Warrior to survive below zero Wounds by drawing on his inner reserves of strength and willpower. As soon as your Warrior is knocked to zero Wounds or below he begins to sing a fearful, grim battledirge - his deathsong. Rather than falling down unconscious. your Warrior remains standing and can continue to fight. Place him on 1 Wound. Each time your Warrior is hit while singing his deathsong roll 1D6. On a score of 1, 2, 3 or 4 the blow has its normal effect, and takes your Warrior below 0 Wounds and into unconsciousness. On a score of 5 or 6 he ignores the blow's effects. remains standing and on 1 Wound. Your Warrior continues to sing his deathsong and remain on 1 Wound until he is healed in the normal manner.", 
        categories: ["Survivability", "Buff"],
        value: "7",
        imagePath: "images/skills/Deathsong.png"
    );

    public static Skill Goldmaster = new(
        "Goldmaster",
        "Find more gold during your adventures.",
        "Your companions declare that they've found all the treasure here and it's time to move on. You're not so sure, and have a feeling you ought to check out that loose stone you saw by the door. . .",
        "This skill allows your Warrior to develop what amounts to a sixth sense when looking for hidden gold. Once all the Monsters in a room are dead and the party is dealing out treasure roll 2D6 x 10. If either of the dice comes up with a 1, your Warrior finds nothing, otherwise he finds that much extra gold concealed around the room.", 
        categories: ["Movement", "Buff"],
        value: "8",
        imagePath: "images/skills/Goldmaster.png"
    );

    public static Skill Grudelord = new(
        "Grudelord",
        "Grudges against single monsters will make you fight harder.",
        "You've barely had time to draw your axe when you realise with anger that the Orc nearest the far corner is the same foul beast that burnt your brother's village to the ground and killed its inhabitants. With no regard for your own safety, you charge directly at it, swearing to avenge your kin.",
        "Your Warrior bears grudges against most of the inhabitants of the dungeons of the Warhammer World. As a group of Monsters are placed you may declare that your Warrior bears a grudge against one of them. As long as that Monster still lives your Warrior gets +1 on all of his to hit rolls. He will always attack the 'grudged' Monster if possible (breaking from pinning when he can, etc.) and gets double its Gold Value if he succeeds in killing it himself. This skill may be used once per dungeon.",
        categories: ["Exploration", "Buff"],
        value: "9",
        imagePath: "images/skills/Grudelord.png"
    );

    public static Skill BloodFever = new(
        "Blood-Fever",
        "",
        "Your eyes glaze over as your axe swings to and fro wildly, a relentless cascade of blows raining down upon the enemy.",
        "This skill allows your Warrior to trade in all of his attacks each turn for a single blood-fever attack. Make a normal attack. If you hit the target and kill it with that one blow, your Warrior can step forward one square and, if this takes him into contact with another Monster, he may make another attack. This process continues until your Warrior fails to kill his opponent. This skill may be used once per turn",
        categories: ["Combat", "Buff"],
        value: "10",
        imagePath: "images/skills/BloodFever.png"
    );

    public static Skill TunnelFighter = new(
        "Tunnel-Fighter",
        "Learning the way of the Ironbreaker, you are accustomed to fight in close, confined spaces.",
        "Having trained in the claustrophobic caverns of nearby caves in your youth, the cramped conditions of a dungeon stairway cause you no problems at all.",
        "This skill gives your Warrior +1 on his to hit rolls when fighting in corridors, junctions, stairways. and other similar enclosed places.",
        categories: ["Combat", "Buff"],
        value: "11",
        imagePath: "images/skills/TunnelFighter.png"
    );

    public static Skill Trademaster = new(
        "Trademaster",
        "Gain an eye for bargains",
        "Deciding against your usual supplier of axes you search out a little backstreet market stall, selling comparable goods but much more cheaply!",
        "While in a settlement you may roll an extra 1D6 when making the dice roll to see if an item is in stock. In addition, when your warrior buys an item roll 1D6. On a 6, you get a 50% discount on that item.",
        categories: ["settlement", "Buff"],
        value: "12",
        imagePath: "images/skills/Trademaster.png"
    );

    public static Skill GetSkillByValue(string value)
    {
        var allSkills = new List<Skill>
        {
            MightyBlow,
            KillingBlow,
            Enraged,
            Endure,
            Stonemaster,
            Deathsong,
            Goldmaster,
            Grudelord,
            BloodFever,
            TunnelFighter,
            Trademaster
        };

        return allSkills.FirstOrDefault(s => s.Value == value);
    }
}