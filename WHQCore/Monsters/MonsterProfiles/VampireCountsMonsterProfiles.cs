namespace WHQCore.Monsters.MonsterProfiles;

public static class VampireCountsMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.skeleton",
            Name = "Skeleton",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Initiative = 5,
            Wounds = 3,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 80,
            Armour = 0,
            SpecialRules =
            [
                "Armed with [1-3] Bows (Str 3) or [4-6] Swords",
                "Fear 5",
                "Regenerate 1"
            ]
        },
        new()
        {
            Id = "bestiary.zombie",
            Name = "Zombie",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 3,
            Initiative = 5,
            Wounds = 5,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 40,
            Armour = 0,
            SpecialRules =
            [
                "Fear 3"
            ]
        },
        new()
        {
            Id = "bestiary.ghoul",
            Name = "Ghoul",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 4,
            Initiative = 4,
            Wounds = 4,
            Attacks = 3,
            Damage = "1",
            GoldPerModel = 80,
            Armour = 0,
            SpecialRules =
            [
                "Break",
                "Fear 4"
            ]
        },
        new()
        {
            Id = "bestiary.ghost",
            Name = "Ghost",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "-",
            Strength = 0,
            Toughness = 3,
            Initiative = 3,
            Wounds = 16,
            Attacks = 1,
            Damage = "S",
            GoldPerModel = 0,
            Armour = 0,
            SpecialRules =
            [
                "Chill 1",
                "Ethereal -1",
                "Fear 6"
            ]
        },
        new()
        {
            Id = "bestiary.wight",
            Name = "Wight",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 4,
            Initiative = 3,
            Wounds = 14,
            Attacks = 1,
            Damage = "2",
            GoldPerModel = 370,
            Armour = 2,
            SpecialRules =
            [
                "Fear 7"
            ]
        },
        new()
        {
            Id = "bestiary.wight_lord",
            Name = "Wight Lord",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 4,
            Toughness = 4,
            Initiative = 4,
            Wounds = 35,
            Attacks = 2,
            Damage = "2",
            GoldPerModel = 650,
            Armour = 2,
            SpecialRules =
            [
                "Fear 8",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.necromancer_champion",
            Name = "Necromancer Champion",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 3,
            Initiative = 4,
            Wounds = 29,
            Attacks = 4,
            Damage = "1",
            GoldPerModel = 1630,
            Armour = 0,
            SpecialRules =
            [
                "Necromantic Magic 2",
                "Magic Resistance 4+",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.vampire_lord_necromancer",
            Name = "Vampire Lord Necromancer",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 6,
            WeaponSkill = 7,
            BallisticSkill = "2+",
            Strength = 6,
            Toughness = 5,
            Initiative = 8,
            Wounds = 38,
            Attacks = 3,
            Damage = "4",
            GoldPerModel = 4750,
            Armour = 4,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Dispel 4+",
                "Fly",
                "Necromantic Magic 4",
                "Magic Resistance 4+",
                "Magic Armour",
                "4 x Magic Item",
                "Magic Weapon",
                "Vampire 2"
            ]
        },
        new()
        {
            Id = "bestiary.necromancer_lord",
            Name = "Necromancer Lord",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 5,
            Toughness = 4,
            Initiative = 6,
            Wounds = 39,
            Attacks = 5,
            Damage = "3",
            GoldPerModel = 4100,
            Armour = 4,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Necromantic Magic 4",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "4 x Magic Item",
                "Magic Weapon",
                "Regenerate 2"
            ]
        },
        new()
        {
            Id = "bestiary.master_necromancer",
            Name = "Master Necromancer",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 5,
            Toughness = 4,
            Initiative = 5,
            Wounds = 34,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 2780,
            Armour = 3,
            SpecialRules =
            [
                "Necromantic Magic 3",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "3 x Magic Item",
                "Magic Weapon",
                "Regenerate 2"
            ]
        },
        new()
        {
            Id = "bestiary.necromancer",
            Name = "Necromancer",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 3,
            Wounds = 25,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 680,
            Armour = 0,
            SpecialRules =
            [
                "Necromantic Magic 1",
                "Magic Resistance 5+",
                "Magic Weapon",
                "Regenerate 2"
            ]
        },
        new()
        {
            Id = "bestiary.vampire_count",
            Name = "Vampire Count",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 6,
            WeaponSkill = 7,
            BallisticSkill = "2+",
            Strength = 7,
            Toughness = 6,
            Initiative = 8,
            Wounds = 30,
            Attacks = 3,
            Damage = "2D6/3D6(5+)",
            GoldPerModel = 2000,
            Armour = 3,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Fly",
                "Necromantic Magic 2",
                "Magic Resistance 5+",
                "Vampire"
            ]
        },
        new()
        {
            Id = "bestiary.vampire_lord",
            Name = "Vampire Lord",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 6,
            WeaponSkill = 8,
            BallisticSkill = "1+",
            Strength = 7,
            Toughness = 6,
            Initiative = 9,
            Wounds = 42,
            Attacks = 4,
            Damage = "3D6",
            GoldPerModel = 3750,
            Armour = 3,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Fly",
                "Necromantic Magic 3",
                "Magic Resistance 5+",
                "Vampire"
            ]
        },
        new()
        {
            Id = "bestiary.wraith",
            Name = "Wraith",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 3,
            Initiative = 3,
            Wounds = 30,
            Attacks = 2,
            Damage = "Special",
            GoldPerModel = 750,
            Armour = 0,
            SpecialRules =
            [
                "Chill 2",
                "Ethereal -1",
                "Terror 8"
            ]
        },
        new()
        {
            Id = "bestiary.wight_champion",
            Name = "Wight Champion",
            Allegiance = MonsterAllegiance.VampireCounts,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 4,
            Toughness = 4,
            Initiative = 4,
            Wounds = 35,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 650,
            Armour = 2,
            SpecialRules =
            [
                "Fear 8",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
    ];
}
