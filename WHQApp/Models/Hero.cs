using WHQApp.Logic;

namespace WHQApp.Models;

public class Hero
{
    public static readonly Dictionary<int, int> GoldCostPerLevel = new()
    {
        { 2, 2000 },
        { 3, 4000 },
        { 4, 8000 },
        { 5, 12000 },
        { 6, 18000 },
        { 7, 24000 },
        { 8, 32000 },
        { 9, 45000 },
        { 10, 50000 }
    };

    private Dictionary<string, string> rollDetails = new();

    public Hero(string name, string type)
    {
        Name = name;
        HeroType = type;
    }

    public string Name { get; set; }
    public string HeroType { get; set; }
    public string Title { get; set; }
    public int BattleLevel { get; set; } = 1;
    public int Gold { get; set; } = 0;
    public int StartingWounds { get; set; }
    public DiceRoller.DiceRollResult StartingWoundsRoll { get; set; }
    public int Movement { get; set; }
    public int WeaponSkill { get; set; }
    public string BallisticSkill { get; set; }
    public int Strength { get; set; }
    public int DamageDice { get; set; }
    public int Toughness { get; set; }
    public int Initiative { get; set; }
    public int Attacks { get; set; }
    public int Luck { get; set; }
    public int Willpower { get; set; }
    public string EscapePinning { get; set; }
    public List<Equipment> Equipment { get; set; } = [];
    public List<SpecialRule> SpecialRules { get; set; } = [];
    public List<Skill> Skills { get; set; } = [];
    public int TotalToughness => Toughness + GetBonus("Toughness");
    public int TotalStrength => Strength + GetBonus("Strength");
    public int TotalAttacks => Attacks + GetBonus("Attacks");

    public List<string> SkillNotes { get; set; } = [];

    public Dictionary<string, string> GetRollDetails()
    {
        return rollDetails;
    }

    public void AddSkillNote(string note)
    {
        SkillNotes.Add(note);
    }
    private int GetBonus(string statName)
    {
        return Equipment
            .Where(eq => eq.StatModifiers != null && eq.StatModifiers.TryGetValue(statName, out _))
            .Sum(eq => eq.StatModifiers[statName]);
    }
}