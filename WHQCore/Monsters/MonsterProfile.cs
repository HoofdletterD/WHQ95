namespace WHQCore.Monsters;

public sealed class MonsterProfile
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public required MonsterAllegiance Allegiance { get; init; }
    public MonsterSubfaction Subfaction { get; init; } = MonsterSubfaction.None;

    public int Wounds { get; init; }
    public int Move { get; init; }
    public int WeaponSkill { get; init; }
    public string BallisticSkill { get; init; }
    public int Strength { get; init; }
    public int Toughness { get; init; }
    public int Initiative { get; init; }
    public int Attacks { get; init; }

    public int GoldPerModel { get; init; }

    public int? Armour { get; init; }
    public string Damage { get; init; } = "";

    public List<string> SpecialRules { get; init; } = [];
}