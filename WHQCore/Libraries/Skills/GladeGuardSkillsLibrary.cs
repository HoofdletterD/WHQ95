using WHQCore.Models;

namespace WHQCore.Libraries.Skills;

public class GladeGuardSkillsLibrary
{
    public static Skill Dodge = new(
        "Dodge",
        "An additional save to dodge out of the way of harm",
        "Elves are well-known for their lightning quick reflexes that can save them in battle from all but the fastest of blows.",
        "Whenever an opponent hits them, Glade Guard can attempt to dodge the blow, causing it to miss completely. Roll a D6. On the score of a 6, the glade guard dodges the incoming blow.",
        categories: ["Survivability", "Buff"],
        value: "Default",
        imagePath: "images/skills/Dodge_icon.png"
    );

    public static Skill Leap = new(
        "Leap",
        "Leap over an adjacent square to land beyond it.",
        "In a single, fluid movement you launch yourself into the air and flip over your stunned opponent's head, landing on the balls of your feet behind him, sword in hand.",
        "This skill allows your Warrior to leap 1 square in any direction as part of his move, landing in the square beyond. Any obstacle in the square being leaped is ignored, though it still counts as 1 square of movement. This skill may be used once per turn.",
        categories: ["Buff"],
        value: "2",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Sureshot = new(
        "Sureshot",
        "Re-roll one missed missile attack each turn.",
        "Taking careful aim, you ease the bowstring back and let an arrow fly straight towards its target.",
        "This skill allows you to re-roll any one of your Warrior's missile attacks that has missed. This skill may be used once per turn.",
        categories: ["Buff"],
        value: "3",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Doomstrike = new(
        "Doomstrike",
        "+3 to all to hit rolls for one turn.",
        "Summoning all your strength you bring an awesome blow crashing down upon your opponent.",
        "This skill allows you to add +3 to all of your Warrior's to hit rolls for one turn. This skill can be used once per adventure.",
        categories: ["Buff"],
        value: "4",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Herblore = new(
        "Herblore",
        "Attempt to heal yourself or an ally with a herbal salve.",
        "You rub the foul-smelling salve into your companion's wound, reassuring him that even if the concoction does sting it is doing him good.",
        "This skill allows your Warrior to try and heal himself or a wounded companion. Roll 1D6 on the following table:\n1 The wounded Warrior reacts badly to the salve and takes another 1D6 Wounds.\n2-3 Nothing happens.\n4-5 The salve works and the wounded Warrior regains 1D6 Wounds.\n6 The treatment is even better than expected and the wounded Warrior regains 2D6 Wounds.\nThis skill may be used once per turn.",
        categories: ["Buff"],
        value: "5",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill RapidFire = new(
        "Rapid Fire",
        "+1 Attack per turn with a missile weapon.",
        "Your arms almost a blur, you release arrow after arrow into the enemy ranks.",
        "This skill gives your Warrior +1 Attacks per turn with a missile weapon.",
        categories: ["Buff"],
        value: "6",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill PowerShot = new(
        "Power Shot",
        "Bow shots deal +2 Wounds.",
        "Your forearms strain as you pull back the tightened bowstring, using all your strength against the increased pull of the weapon.",
        "This skill allows your Warrior to fire his bow with increased power, adding +2 Wounds to the damage inflicted.",
        categories: ["Buff"],
        value: "7",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Evade = new(
        "Evade",
        "On a 5+, dodge an incoming attack.",
        "Nimbly stepping to one side, you dodge the incoming axe, flinching slightly as the razor-sharp blade whistles past your ear and buries itself in the table next to you.",
        "This skill gives your Warrior the ability to dodge incoming blows by stepping to one side. If a Monster successfully hits your Warrior, roll 1D6. On a score of 1, 2, 3 or 4 he hits your Warrior as normal. On a score of a 5 or 6 your Warrior can evade the blow by stepping into any empty adjacent square. If there are no squares free he must take the blow as normal.\nIn the process of side-stepping, your Warrior may come into contact with another Monster that he was not in base-to-base contact with originally. This has no effect this turn, but as of next turn it may attack your Warrior as usual. Similarly, by evading your Warrior may move out of contact with another Monster who was going to attack him this turn. If this Monster is not pinned by another Warrior, it will move after your Warrior.",
        categories: ["Buff"],
        value: "8",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Pinion = new(
        "Pinion",
        "Pin an enemy to a wall on a successful shot.",
        "The arrow whistles through the air and slams into your opponent, pinning him to the wall like a stuck pig.",
        "This skill allows your Warrior to trade in multiple attacks for one single, carefully aimed shot. If the target is successfully hit, and is standing directly in front of, and adjacent to, a wall, roll an extra 1D6 after rolling for damage. If the score is 1, 2, 3 or 4 the shot simply causes normal damage. On a score of 5 or 6 the shot causes normal damage and pins the target to the wall. The target may do nothing for the rest of this turn as it struggles to free itself.",
        categories: ["Buff"],
        value: "9",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Hypnosis = new(
        "Hypnosis",
        "Enter a trance to heal 1D6 Wounds.",
        "Slowing your breath to half its normal rate, you slowly drift into a state of altered consciousness, calming the raging pain of your wounds and speeding their healing.",
        "This skill allows your Warrior to enter a self-induced hypnotic trance and heal himself. This skill may only be used if there are no Monsters in the room or the same board section as the Elf. Entering the trance takes one turn, during which your Warrior may do nothing else. At the end of the turn your Warrior regains 1D6 Wounds.",
        categories: ["Buff"],
        value: "10",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill ForestWalker = new(
        "Forest Walker",
        "Shorten travel to settlement by one week and find herbs.",
        "Brushing aside the undergrowth, you find an almost invisible deer track leading straight to the next village and cutting a good seven days off the journey.",
        "This skill allows your Warrior to find almost hidden short cuts in the trek between dungeons. When travelling to a Settlement, this skill allows your Warrior to reduce the journey time by one week. In addition, on the journey he finds enough herbs to make 1D6 healing potions. Each potion restores a number of Wounds equal to the Elf's Battle-level.",
        categories: ["Buff"],
        value: "11",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill Parry = new(
        "Parry",
        "On a 6, block an incoming melee attack.",
        "With a practised manoeuvre and a deft flick of the wrist you hook your sword around your enemy's weapon and twist it down and to one side.",
        "This skill allows your Warrior to parry an incoming blow. When your Warrior is attacked roll 1D6. On a score of 1-5 he must take the blow as normal. On a score of 6 he turns the blow and it causes no damage.",
        categories: ["Buff"],
        value: "12",
        imagePath: "images/skills/_icon.png"
    );

    public static Skill GetSkillByValue(string value)
    {
        var allSkills = new List<Skill>
        {
            Leap,
            Sureshot,
            Doomstrike,
            Herblore,
            RapidFire,
            PowerShot,
            Evade,
            Pinion,
            Hypnosis,
            ForestWalker,
            Parry
        };

        return allSkills.FirstOrDefault(s => s.Value == value);
    }
}