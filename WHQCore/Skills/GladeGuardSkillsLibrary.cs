using WHQCore.Models;

namespace WHQCore.Skills
{
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

        public static Skill ElfSkill2 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "2",
            imagePath: "images/skills/_icon.png"
        );

        public static Skill ElfSkill3 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "3",
            imagePath: "images/skills/KillingBlow.png"
        );

        public static Skill ElfSkill4 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "4",
            imagePath: "images/skills/Enraged.png"
        );

        public static Skill ElfSkill5 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "5",
            imagePath: "images/skills/Endure.png"
        );

        public static Skill ElfSkill6 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "6",
            imagePath: "images/skills/Stonemaster.png"
        );

        public static Skill ElfSkill7 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "7",
            imagePath: "images/skills/Deathsong.png"
        );

        public static Skill ElfSkill8 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "8",
            imagePath: "images/skills/Goldmaster.png"
        );

        public static Skill ElfSkill9 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "9",
            imagePath: "images/skills/Grudelord.png"
        );

        public static Skill ElfSkill10 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "10",
            imagePath: "images/skills/BloodFever.png"
        );

        public static Skill ElfSkill11 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "11",
            imagePath: "images/skills/TunnelFighter.png"
        );

        public static Skill ElfSkill12 = new(
            "",
            "",
            "",
            "",
            categories: ["", "Buff"],
            value: "12",
            imagePath: "images/skills/Trademaster.png"
        );

        public static Skill GetSkillByValue(string value)
        {
            var allSkills = new List<Skill>
            {
                ElfSkill2,
                ElfSkill3,
                ElfSkill4,
                ElfSkill5,
                ElfSkill6,
                ElfSkill7,
                ElfSkill8,
                ElfSkill9,
                ElfSkill10,
                ElfSkill11,
                ElfSkill12
            };

            return allSkills.FirstOrDefault(s => s.Value == value);
        }
    }
}