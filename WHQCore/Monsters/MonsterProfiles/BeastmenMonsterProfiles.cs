namespace WHQCore.Monsters.MonsterProfiles;

public static class BeastmenMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.gor",
            Name = "Gor",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Initiative = 6,
            Wounds = 6,
            Attacks = 3,
            Damage = "1",
            GoldPerModel = 100,
            Armour = 0,
            SpecialRules =
            [
                "Throw Spears (Str 3)"
            ]
        },
        new()
        {
            Id = "bestiary.centigor",
            Name = "Centigor",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 8,
            WeaponSkill = 3,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 4,
            Initiative = 12,
            Wounds = 3,
            Attacks = 2,
            Damage = "2",
            GoldPerModel = 300,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Bows (Str 4)",
                "Fear 4"
            ]
        },
        new()
        {
            Id = "bestiary.beastman_lord",
            Name = "Beastman Lord",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 4,
            WeaponSkill = 7,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 5,
            Initiative = 6,
            Wounds = 47,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 2000,
            Armour = 2,
            SpecialRules =
            [
                "Magic Armour",
                "2 x Magic Item",
                "Magic Weapon",
                "Throw Spears (Str 10)"
            ]
        },
        new()
        {
            Id = "bestiary.beastman_hero",
            Name = "Beastman Hero",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 5,
            Initiative = 5,
            Wounds = 34,
            Attacks = 3,
            Damage = "2",
            GoldPerModel = 1300,
            Armour = 2,
            SpecialRules =
            [
                "Magic Item",
                "Magic Weapon",
                "Throw Spears (Str 9)"
            ]
        },
        new()
        {
            Id = "bestiary.centaur_hero",
            Name = "Centaur Hero",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 8,
            WeaponSkill = 5,
            BallisticSkill = "1+",
            Strength = 5,
            Toughness = 4,
            Initiative = 5,
            Wounds = 40,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 2200,
            Armour = 4,
            SpecialRules =
            [
                "Armed with Bow (Str 8)",
                "Fear 8",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.beastman_champion",
            Name = "Beastman Champion",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 4,
            Initiative = 3,
            Wounds = 30,
            Attacks = 4,
            Damage = "1/2(5+)",
            GoldPerModel = 610,
            Armour = 0,
            SpecialRules =
            [
                "Guards (Beastman Shaman)",
                "Magic Weapon",
                "Throw Spears (Str 8)"
            ]
        },
        new()
        {
            Id = "bestiary.beastman",
            Name = "Beastman",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 3,
            Toughness = 4,
            Initiative = 3,
            Wounds = 6,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 100,
            Armour = 0,
            SpecialRules =
            [
                "Throw Spears (Str 3)"
            ]
        },
        new()
        {
            Id = "bestiary.beastman_shaman_champion",
            Name = "Beastman Shaman Champion",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 5,
            Initiative = 4,
            Wounds = 34,
            Attacks = 1,
            Damage = "2D6",
            GoldPerModel = 1340,
            Armour = 0,
            SpecialRules =
            [
                "Beastman Magic 2",
                "Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.centaur",
            Name = "Centaur",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 8,
            WeaponSkill = 3,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 3,
            Wounds = 12,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 300,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Bow (Str 4)",
                "Fear 4"
            ]
        },
        new()
        {
            Id = "bestiary.centaur_champion",
            Name = "Centaur Champion",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 8,
            WeaponSkill = 4,
            BallisticSkill = "2+",
            Strength = 5,
            Toughness = 3,
            Initiative = 4,
            Wounds = 27,
            Attacks = 3,
            Damage = "2D6/3D6(5+)",
            GoldPerModel = 1000,
            Armour = 2,
            SpecialRules =
            [
                "Armed with Bow (Str 7)",
                "Fear 8",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.minotaur",
            Name = "Minotaur",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 4,
            Initiative = 3,
            Wounds = 15,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 440,
            Armour = 0,
            SpecialRules =
            [
                "Fear 5"
            ]
        },
        new()
        {
            Id = "bestiary.minotaur_champion",
            Name = "Minotaur Champion",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 6,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 5,
            Toughness = 4,
            Initiative = 4,
            Wounds = 34,
            Attacks = 3,
            Damage = "3D6",
            GoldPerModel = 1100,
            Armour = 1,
            SpecialRules =
            [
                "Fear 6",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.minotaur_hero",
            Name = "Minotaur Hero",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 6,
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 5,
            Toughness = 5,
            Initiative = 5,
            Wounds = 48,
            Attacks = 4,
            Damage = "3D6/4D6(5+)",
            GoldPerModel = 2400,
            Armour = 2,
            SpecialRules =
            [
                "Fear 9",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
    ];
}
