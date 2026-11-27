namespace WHQCore.Monsters.MonsterProfiles;

public static class NeutralMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.ogre",
            Name = "Ogre",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 3,
            BallisticSkill = "5+",
            Strength = 4,
            Toughness = 5,
            Initiative = 3,
            Wounds = 13,
            Attacks = 3,
            Damage = "1D2(5+)",
            GoldPerModel = 400,
            Armour = 0,
            SpecialRules =
            [
                "Fear 5"
            ]
        },
        new()
        {
            Id = "bestiary.giant_scorpion",
            Name = "Giant Scorpion",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 6,
            Initiative = 1,
            Wounds = 20,
            Attacks = 2,
            Damage = "2",
            GoldPerModel = 450,
            Armour = 0,
            SpecialRules =
            [
                "Sting (2D6)"
            ]
        },
        new()
        {
            Id = "bestiary.troll",
            Name = "Troll",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 3,
            BallisticSkill = "6+",
            Strength = 5,
            Toughness = 4,
            Initiative = 1,
            Wounds = 30,
            Attacks = 3,
            Damage = "2",
            GoldPerModel = 650,
            Armour = 0,
            SpecialRules =
            [
                "Fear 6",
                "Regenerate 2",
                "Vomit"
            ]
        },
        new()
        {
            Id = "bestiary.stone_troll",
            Name = "Stone Troll",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 3,
            BallisticSkill = "6+",
            Strength = 5,
            Toughness = 4,
            Initiative = 1,
            Wounds = 25,
            Attacks = 3,
            Damage = "2",
            GoldPerModel = 650,
            Armour = 0,
            SpecialRules =
            [
                "Fear 6",
                "Magic Drain 6",
                "Regenerate 2"
            ]
        },
        new()
        {
            Id = "bestiary.gigantic_spider",
            Name = "Gigantic Spider",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 4,
            Wounds = 20,
            Initiative = 1,
            Attacks = 2,
            GoldPerModel = 450,
            Armour = 0,
            Damage = "2"
        },
        new()
        {
            Id = "bestiary.gorgon",
            Name = "Gorgon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "4+",
            Strength = 13,
            Toughness = 3,
            Initiative = 5,
            Wounds = 35,
            Attacks = 1,
            Damage = "2",
            GoldPerModel = 1100,
            Armour = 0,
            SpecialRules =
            [
                "Fear 9",
                "Petrify"
            ]
        },
        new()
        {
            Id = "bestiary.cockatrice",
            Name = "Cockatrice",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 4,
            Toughness = 4,
            Initiative = 4,
            Wounds = 26,
            Attacks = 3,
            Damage = "3/4(5+)",
            GoldPerModel = 1500,
            Armour = 0,
            SpecialRules =
            [
                "Fear 10",
                "Fly",
                "Petrify"
            ]
        },
        new()
        {
            Id = "bestiary.griffon",
            Name = "Griffon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 5,
            BallisticSkill = "-",
            Strength = 6,
            Toughness = 5,
            Initiative = 7,
            Wounds = 52,
            Attacks = 4,
            Damage = "4",
            GoldPerModel = 1500,
            Armour = 0,
            SpecialRules =
            [
                "Fly",
                "Terror 10"
            ]
        },
        new()
        {
            Id = "bestiary.hippogriff",
            Name = "Hippogriff",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 8,
            WeaponSkill = 5,
            BallisticSkill = "-",
            Strength = 6,
            Toughness = 5,
            Initiative = 6,
            Wounds = 55,
            Attacks = 3,
            Damage = "3/4(5+)",
            GoldPerModel = 1450,
            Armour = 0,
            SpecialRules =
            [
                "Fly",
                "Terror 10"
            ]
        },
        new()
        {
            Id = "bestiary.emperor_dragon",
            Name = "Emperor Dragon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 8,
            BallisticSkill = "-",
            Strength = 8,
            Toughness = 8,
            Initiative = 6,
            Wounds = 94,
            Attacks = 9,
            Damage = "8",
            GoldPerModel = 7500,
            Armour = 8,
            SpecialRules =
            [
                "Dragon Breath",
                "Ambush",
                "Magic A",
                "Fly",
                "Ignore Blows 4+",
                "Ignore Pain 3D6",
                "Large Monster",
                "Chaos Magic 2",
                "Terror 14",
                "Treasure Hoard +2"
            ]
        },
        new()
        {
            Id = "bestiary.emperor_dragon",
            Name = "Emperor Dragon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 8,
            BallisticSkill = "-",
            Strength = 8,
            Toughness = 8,
            Initiative = 6,
            Wounds = 94,
            Attacks = 9,
            Damage = "8",
            GoldPerModel = 7500,
            Armour = 8,
            SpecialRules =
            [
                "Dragon Breath",
                "Ambush",
                "Magic A",
                "Fly",
                "Ignore Blows 4+",
                "Ignore Pain 3D6",
                "Large Monster",
                "Chaos Magic 2",
                "Terror 14",
                "Treasure Hoard +2"
            ]
        },
        new()
        {
            Id = "bestiary.griffon",
            Name = "Griffon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 5,
            BallisticSkill = "-",
            Strength = 6,
            Toughness = 5,
            Initiative = 7,
            Wounds = 52,
            Attacks = 4,
            Damage = "4",
            GoldPerModel = 1500,
            Armour = 0,
            SpecialRules =
            [
                "Fly",
                "Terror 10"
            ]
        },
        new()
        {
            Id = "bestiary.dragon",
            Name = "Dragon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 6,
            BallisticSkill = "-",
            Strength = 6,
            Toughness = 6,
            Initiative = 8,
            Wounds = 74,
            Attacks = 7,
            Damage = "6",
            GoldPerModel = 4500,
            Armour = 6,
            SpecialRules =
            [
                "Dragon Breath",
                "Ambush",
                "Magic A",
                "Fly",
                "Ignore Blows 5+",
                "Ignore Pain 7",
                "Large Monster",
                "Terror 12",
                "Treasure Hoard +0"
            ]
        },
        new()
        {
            Id = "bestiary.great_dragon",
            Name = "Great Dragon",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 7,
            BallisticSkill = "-",
            Strength = 7,
            Toughness = 7,
            Initiative = 7,
            Wounds = 84,
            Attacks = 8,
            Damage = "6/7(5+)",
            GoldPerModel = 6000,
            Armour = 7,
            SpecialRules =
            [
                "Dragon Breath",
                "Ambush",
                "Magic A",
                "Fly",
                "Ignore Blows 4+",
                "Ignore Pain 7",
                "Large Monster",
                "Chaos Magic 1",
                "Terror 13",
                "Treasure Hoard +1"
            ]
        },
    ];
}
