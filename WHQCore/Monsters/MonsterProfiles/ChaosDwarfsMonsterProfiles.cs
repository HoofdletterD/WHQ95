namespace WHQCore.Monsters.MonsterProfiles;

public static class ChaosDwarfsMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.hobgoblin",
            Name = "Hobgoblin",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Initiative = 4,
            Wounds = 2,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 50,
            Armour = 1,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Break"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf",
            Name = "Chaos Dwarf",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Initiative = 2,
            Wounds = 8,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 140,
            Armour = 2,
            SpecialRules =
            [
                "Magic Resistance 6+"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_blunderbuss",
            Name = "Chaos Dwarf Blunderbuss",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Initiative = 2,
            Wounds = 8,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 140,
            Armour = 1,
            SpecialRules =
            [
                "Armed with Blunderbuss",
                "Magic Resistance 6+"
            ]
        },
        new()
        {
            Id = "bestiary.bull_centaur",
            Name = "Bull Centaur",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 8,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 4,
            Initiative = 3,
            Wounds = 12,
            Attacks = 2,
            Damage = "2",
            GoldPerModel = 410,
            Armour = 2,
            SpecialRules =
            [
                "Fear 5",
                "Magic Resistance 6+"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_sorcerer",
            Name = "Chaos Dwarf Sorcerer",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 5,
            Initiative = 3,
            Wounds = 8,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 590,
            Armour = 2,
            SpecialRules =
            [
                "Chaos Dwarf Magic 1",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Protection Ring (+1T)"
            ]
        },
        new()
        {
            Id = "bestiary.bull_centaur_hero",
            Name = "Bull Centaur Hero",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 8,
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 5,
            Toughness = 5,
            Initiative = 5,
            Wounds = 32,
            Attacks = 4,
            Damage = "3/4(5+)",
            GoldPerModel = 2320,
            Armour = 3,
            SpecialRules =
            [
                "Fear 7",
                "Magic Resistance 5+",
                "Magic Armour",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_master_sorcerer",
            Name = "Chaos Dwarf Master Sorcerer",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 5,
            Initiative = 4,
            Wounds = 26,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 2190,
            Armour = 3,
            SpecialRules =
            [
                "Chaos Dwarf Magic 3",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_lord",
            Name = "Chaos Dwarf Lord",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 7,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 5,
            Initiative = 5,
            Wounds = 33,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 1600,
            Armour = 3,
            SpecialRules =
            [
                "Magic Resistance 5+",
                "Magic Armour",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.bull_centaur_lord",
            Name = "Bull Centaur Lord",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 8,
            WeaponSkill = 7,
            BallisticSkill = "1+",
            Strength = 5,
            Toughness = 5,
            Initiative = 6,
            Wounds = 42,
            Attacks = 5,
            Damage = "4/(5+)5",
            GoldPerModel = 3680,
            Armour = 3,
            SpecialRules =
            [
                "Fear 7",
                "Magic Resistance 4+",
                "Magic Armour",
                "3 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.lammasu",
            Name = "Lammasu",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 6,
            WeaponSkill = 6,
            BallisticSkill = "-",
            Strength = 6,
            Toughness = 7,
            Initiative = 6,
            Wounds = 50,
            Attacks = 3,
            Damage = "4",
            GoldPerModel = 2000,
            Armour = 0,
            SpecialRules =
            [
                "Fly",
                "Magic Resistance 4+",
                "Sorcerous Exhalation",
                "Terror 10"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_sorcerer_lord",
            Name = "Chaos Dwarf Sorcerer Lord",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 5,
            Initiative = 5,
            Wounds = 40,
            Attacks = 3,
            Damage = "3/4(5+)",
            GoldPerModel = 3280,
            Armour = 3,
            SpecialRules =
            [
                "Chaos Dwarf Magic 4",
                "Magic Dispel 4+",
                "Magic Resistance 3+",
                "Magic Armour",
                "3 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.great_taurus",
            Name = "Great Taurus",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 6,
            WeaponSkill = 6,
            BallisticSkill = "-",
            Strength = 6,
            Toughness = 6,
            Initiative = 7,
            Wounds = 50,
            Attacks = 4,
            Damage = "4",
            GoldPerModel = 2250,
            Armour = 3,
            SpecialRules =
            [
                "Breathe Fire",
                "Fly",
                "Terror 10"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_champion",
            Name = "Chaos Dwarf Champion",
            Allegiance = MonsterAllegiance.ChaosDwarfs,
            Move = 3,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 4,
            Initiative = 3,
            Wounds = 16,
            Attacks = 2,
            Damage = "2/3(5+)",
            GoldPerModel = 480,
            Armour = 2,
            SpecialRules =
            [
                "Magic Resistance 6+",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon"
            ]
        },
    ];
}
