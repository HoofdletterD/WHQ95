namespace WHQCore.Monsters.MonsterProfiles;

public static class TombKingsMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.mummy",
            Name = "Mummy",
            Allegiance = MonsterAllegiance.TombKings,
            Move = 3,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 4,
            Toughness = 5,
            Wounds = 40,
            Initiative = 3,
            Attacks = 2,
            GoldPerModel = 450,
            Armour = 0,
            Damage = "2"
        },
        new()
        {
            Id = "bestiary.tomb_guardian",
            Name = "Tomb Guardian",
            Allegiance = MonsterAllegiance.TombKings,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "6+",
            Strength = 3,
            Toughness = 3,
            Initiative = 2,
            Wounds = 15,
            Attacks = 1,
            Damage = "2",
            GoldPerModel = 110,
            Armour = 1,
            SpecialRules =
            [
                "Fear 5",
                "Regenerate 1"
            ]
        },
        new()
        {
            Id = "bestiary.mummy_tomb_king",
            Name = "Mummy Tomb King",
            Allegiance = MonsterAllegiance.TombKings,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 5,
            Initiative = 4,
            Wounds = 45,
            Attacks = 3,
            Damage = "3",
            GoldPerModel = 1000,
            Armour = 2,
            SpecialRules =
            [
                "Fear 7",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon",
                "Tomb Rot (1D6)"
            ]
        },
        new()
        {
            Id = "bestiary.liche_king",
            Name = "Liche King",
            Allegiance = MonsterAllegiance.TombKings,
            Move = 6,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 7,
            Toughness = 6,
            Initiative = 4,
            Wounds = 63,
            Attacks = 5,
            Damage = "6",
            GoldPerModel = 7500,
            Armour = 6,
            SpecialRules =
            [
                "Chaos Magic 2",
                "Large Monster",
                "Necromantic Magic 3",
                "Magic Armour",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "3 x Magic Item",
                "Magic Weapon",
                "Terror 14",
                "Regenerate 2"
            ]
        },
        new()
        {
            Id = "bestiary.liche",
            Name = "Liche",
            Allegiance = MonsterAllegiance.TombKings,
            Move = 4,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 5,
            Toughness = 4,
            Initiative = 6,
            Wounds = 40,
            Attacks = 1,
            Damage = "4",
            GoldPerModel = 3500,
            Armour = 0,
            SpecialRules =
            [
                "Fear 10",
                "Necromantic Magic 3",
                "2 x Magic Item",
                "Magic Weapon",
                "Regenerate 2"
            ]
        },
        new()
        {
            Id = "bestiary.liche_king",
            Name = "Liche King",
            Allegiance = MonsterAllegiance.TombKings,
            Move = 6,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 7,
            Toughness = 6,
            Initiative = 4,
            Wounds = 63,
            Attacks = 5,
            Damage = "6",
            GoldPerModel = 7500,
            Armour = 6,
            SpecialRules =
            [
                "Chaos Magic 2",
                "Large Monster",
                "Necromantic Magic 3",
                "Magic Armour",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "3 x Magic Item",
                "Magic Weapon",
                "Terror 14",
                "Regenerate 4"
            ]
        },
    ];
}
