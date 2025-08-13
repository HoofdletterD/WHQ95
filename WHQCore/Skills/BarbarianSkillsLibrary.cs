using WHQCore.MagicItems;
using WHQCore.Models;

namespace WHQCore.Skills;

public static class BarbarianSkillsLibrary
{
    public static Skill Berserk = new(
        "Berserk",
        "Gains a chance of +1 attack based on number of monsters killed.",
        "It's the love of battle that sometimes overcome the Barbarian, paying no heed to their surroundings and laughing maniacally whilst their swords swing through the air...",
        "Each turn, before this Hero fights, roll a D6 and add the number of monsters slain in the current combat. If the result is 6 or more, the Hero goes Berserk and adds +1 to his attacks until the combat is over. If a natural '1' is rolled for this Berserk roll, his bloodlust causes 1 automatic wound on all adjacent heroes. Barbarians of battle level 4 or higher gain a +1 to their Berserk dice roll. Barbarians of Level 8 or higher gain +2 on their Berserk roll instead.",
        categories: ["Combat", "Buff"],
        value: "Default",
        imagePath: "images/skills/berserk_icon.png"
    );

    public static Skill HuntersEye = new(
        "Hunter's Eye",
        "Shoot a number of missles equal to your Attack",
        "Taking careful aim, you rapidly let fly a volley of arrows into the enemy ranks...",
        "Gain the ability to make a number of missile attacks equal to your Attacks Characteristic. Cannot be used when Berserking.",
        categories: ["Shooting", "Buff"],
        value: "2",
        imagePath: "images/skills/HuntersEye_icon.png"
    );

    public static Skill BattleBlades = new(
        "Battle Blades",
        "When facing new group of monster, get a 50% chance to double your attacks",
        "Your sword screams as it cuts the air in a blurred arc of steel, cutting through bone and armour like butter.",
        "On a D6 roll of 4, 5 of 6 double your normal number of attacks ofr the first turn when facing a new group of monsters.",
        categories: ["Combat", "Buff"],
        value: "3",
        imagePath: "images/skills/BattleBlades.png"
    );

    public static Skill BattleRage = new(
        "Battle Rage",
        "Get a combat boost for one turn during one dungeon level",
        "Consuming rage overcomes you and you go completely berserk, slashing and hacking away at your foe.",
        "Once per dungeon, gain +1 Attack per Battle level, or +1 to Hit per battle level, or +2 Strength per battle level, for one turn. Choose which before combat begins.",
        categories: ["Combat", "Buff"],
        value: "4",
        imagePath: "images/skills/BattleRage.png"
    );

    public static Skill Run = new(
        "Run",
        "Chance to run past enemies, or to get in a better position",
        "Given the desperation of your situation you summon hidden reserves of energy to speed your way.",
        "Roll a D6 before moving. On a 5 or a 6, you may double your movement and are not pinned for that movement. May be used once per turn.",
        categories: ["Movement", "Buff"],
        value: "5",
        imagePath: "images/skills/Run.png"
    );

    public static Skill IgnoreWounds = new(
        "Ignore Wounds",
        "Chance to get back in the fight after being downed",
        "Although the pain from your wounds is screaming along every nerve, you somehow manage to stay conscious and fight on.",
        "When reduced to 0 wounds, roll a D6. On a 5 or 6, remain standing with 1 wound left.",
        categories: ["Survivability", "Buff"],
        value: "6",
        imagePath: "images/skills/IgnoreWounds.png"
    );

    public static Skill ShieldWall = new(
        "Shield Wall",
        "Once per dungeon, ignore all effects of a single blow when using a shield",
        "You barely manage to turn the blow as it slams towards you, glancing it off your shield with a flick of your wrist.",
        "Catch the impact of a single blow of this warrior's choosing once per adventure/dungeon level, ignoring ALL damage caused. May only be used when a shield is equipped.",
        categories: ["Defensive", "Buff"],
        value: "7",
        imagePath: "images/skills/ShieldWall.png"
    );

    public static Skill Duckback = new(
        "Duckback",
        "Increase your chance of escaping pinning",
        "Sensing the danger of your situation, you pull back from combat to find a better position",
        "This skill adds a permanent +1 to your dice roll to escape from being Pinned by an enemy model",
        categories: ["Movement", "Buff"],
        value: "8",
        imagePath: "images/skills/Duckback.png"
    );

    public static Skill SixthSense = new(
        "Sixth Sense",
        "Sense the imminent danger when a new board section is being placed",
        "You sniff the air and listen intently for the telltale signs of the monsters that wait to ambush you in the next room.",
        "When a new board section is placed, roll a D6. On a 5 or a 6, turn over the next event card (and roll ofr any relevant monster tables etc.) to see what is in that room.",
        categories: ["Exploration", "Buff"],
        value: "9",
        imagePath: "images/skills/SixthSense.png"
    );

    public static Skill ReactionStrike = new(
        "Reaction Strike",
        "Get a strike in when monsters are placed near you",
        "An Orc lunges out of the darkness towards you. No sooner have you caught sight of it's huge bulk than your sword is out and ready to strike!",
        "Perform one bonus attack on a single monster of your choosing when they are placed adjacent to you.",
        categories: ["Combat", "Buff"],
        value: "10",
        imagePath: "images/skills/ReactionStrike.png"
    );

    public static Skill Grapple = new(
        "Grapple",
        "Grapple the life out of an enemy instead of performing a regular attack",
        "Dropping your weapon to one side, you lunge at your opponent and throw your arms around his chest in a bear-hug, squeezing his lungs and chocking him.",
        "In stead of attacking normal, replace all your attacks with one grapple attack. Roll to hit as normal. If hit, you inflict D6 x Battle Level wounds with no modifiers for armour. Grapples cannot be dodged.",
        categories: ["Combat", "Buff"],
        value: "11",
        imagePath: "images/skills/Grapple.png"
    );

    public static Skill BruteStrength = new(
        "Brute Strength",
        "Shove monsters out of your way",
        "Flexing every muscle you possess, you slam into your opponent, pushing him backwards.",
        "If desired, you may try and push a single monster by rolling D6 and add your Strength. If this total beats the monster's Strength value, push him out of the way into one of the three squares behind the monster of your choosing. Then occupy the square the monster was in and perform your attacks as normal.",
        categories: ["Combat", "Buff"],
        value: "12",
        imagePath: "images/skills/BruteStrength.png"
    );

    public static Skill GetSkillByValue(string value)
    {
        var allSkills = new List<Skill>
        {
            Berserk,
            HuntersEye,
            BattleBlades,
            BattleRage,
            Run,
            IgnoreWounds,
            ShieldWall,
            Duckback,
            SixthSense,
            ReactionStrike,
            Grapple,
            BruteStrength
        };

        return allSkills.FirstOrDefault(s => s.Value == value);
    }
}