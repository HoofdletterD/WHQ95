namespace WHQCore.Monsters.MonsterProfiles;

public static class SkavenMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.stormvermin",
            Name = "Stormvermin",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 3,
            Initiative = 5,
            Wounds = 5,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 95,
            Armour = 1,
            SpecialRules = []
        },
        new()
        {
            Id = "bestiary.rat_ogre",
            Name = "Rat Ogre",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 5,
            Initiative = 5,
            Wounds = 20,
            Attacks = 2,
            Damage = "2",
            GoldPerModel = 500,
            Armour = 0,
            SpecialRules =
            [
                "Fear 5"
            ]
        },
        new()
        {
            Id = "bestiary.gutter_runner",
            Name = "Skaven Gutter Runner",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 5,
            Wounds = 5,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 120,
            Armour = 0,
            SpecialRules =
            [
                "Ambush 4+"
            ]
        },
        new()
        {
            Id = "bestiary.plague_censer_bearer",
            Name = "Skaven Plague Censer Bearer",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 4,
            Toughness = 4,
            Initiative = 4,
            Wounds = 4,
            Attacks = 1,
            Damage = "5",
            GoldPerModel = 150,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Plague Censers"
            ]
        },
        new()
        {
            Id = "bestiary.poison_globadier",
            Name = "Skaven Poison Globadier",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Initiative = 4,
            Wounds = 4,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 200,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Poison Globes"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_champion",
            Name = "Skaven Champion",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 5,
            Wounds = 11,
            Attacks = 2,
            Damage = "2",
            GoldPerModel = 270,
            Armour = 2,
            SpecialRules =
            [
                "Magic Weapon",
                "Never Pinned"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_assassin",
            Name = "Skaven Assassin",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 6,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 5,
            Wounds = 7,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 300,
            Armour = 0,
            SpecialRules =
            [
                "Ambush A",
                "Assassinate 6+",
                "Dodge 5+",
                "Weeping Blades"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_jezzail",
            Name = "Skaven Jezzail",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Wounds = 6,
            Initiative = 4,
            Attacks = 1,
            GoldPerModel = 300,
            Armour = 1,
            Damage = "1"
        },
        new()
        {
            Id = "bestiary.skaven_warpfire_thrower_team",
            Name = "Skaven Warpfire Thrower Team",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Initiative = 4,
            Wounds = 3,
            Attacks = 1,
            Damage = "Special",
            GoldPerModel = 700,
            Armour = 1,
            SpecialRules =
            [
                "Armed with Warpfire Throwers"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_warlord",
            Name = "Skaven Warlord",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 4,
            Initiative = 7,
            Wounds = 30,
            Attacks = 4,
            Damage = "2",
            GoldPerModel = 900,
            Armour = 3,
            SpecialRules =
            [
                "Dodge 5+",
                "Magic Resistance 5+",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_plague_monk",
            Name = "Skaven Plague Monk",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Initiative = 4,
            Wounds = 5,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 60,
            Armour = 0,
            SpecialRules =
            [
                "Frenzy 5+",
                "Weeping Blades"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_plague_priest",
            Name = "Skaven Plague Priest",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 5,
            Initiative = 6,
            Wounds = 23,
            Attacks = 3,
            Damage = "1",
            GoldPerModel = 730,
            Armour = 0,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Frenzy 4+",
                "Magic Weapon",
                "Weeping Blade"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_warlock_champion",
            Name = "Skaven Warlock Champion",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 4,
            Initiative = 5,
            Wounds = 18,
            Attacks = 1,
            Damage = "2",
            GoldPerModel = 1180,
            Armour = 2,
            SpecialRules =
            [
                "Skaven Magic 2",
                "Magic Dispel 5+",
                "Magic Resistance 5+",
                "Magic Item",
                "Weeping Blade"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_plague_lord",
            Name = "Skaven Plague Lord",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 5,
            Initiative = 7,
            Wounds = 30,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 2250,
            Armour = 0,
            SpecialRules =
            [
                "Death Fog",
                "Dodge 3+",
                "Frenzy 3+",
                "Magic Resistance 3+",
                "3 x Magic Item",
                "Magic Weapon",
                "Never Pinned",
                "Terror 10",
                "Weeping Blade"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_vermin_lord",
            Name = "Skaven Vermin Lord",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 8,
            WeaponSkill = 8,
            BallisticSkill = "A",
            Strength = 8,
            Toughness = 7,
            Initiative = 10,
            Wounds = 75,
            Attacks = 8,
            Damage = "6",
            GoldPerModel = 6000,
            Armour = 6,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Armed with Doom Glaive",
                "Dodge 3+",
                "Frenzy 5+",
                "Greater Daemon 14",
                "Ignore Pain 6",
                "Large Monster",
                "Skaven Magic 4",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Skitterleap"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_deathmaster_assassin",
            Name = "Skaven Deathmaster Assassin",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 6,
            WeaponSkill = 8,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 4,
            Initiative = 10,
            Wounds = 32,
            Attacks = 5,
            Damage = "4",
            GoldPerModel = 2300,
            Armour = 0,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Dodge 4+",
                "Assassinate 4+",
                "Magic Resistance 5+",
                "Magic Weapon",
                "Weeping Blade"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_grey_seer",
            Name = "Skaven Grey Seer",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 4,
            Initiative = 7,
            Wounds = 43,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 3400,
            Armour = 0,
            SpecialRules =
            [
                "Skaven Magic 4",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "4 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_vermin_lord",
            Name = "Skaven Vermin Lord",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 8,
            WeaponSkill = 8,
            BallisticSkill = "A",
            Strength = 8,
            Toughness = 7,
            Initiative = 10,
            Wounds = 75,
            Attacks = 8,
            Damage = "6",
            GoldPerModel = 6000,
            Armour = 6,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Armed with Doom Glaive",
                "Dodge 3+",
                "Frenzy 5+",
                "Greater Daemon 14",
                "Ignore Pain 6",
                "Large Monster",
                "Skaven Magic 4",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Skitterleap"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_chieftain",
            Name = "Skaven Chieftain",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 4,
            Initiative = 6,
            Wounds = 20,
            Attacks = 3,
            Damage = "2D6",
            GoldPerModel = 590,
            Armour = 2,
            SpecialRules =
            [
                "Dodge 5+",
                "Never Pinned",
                "Weeping Blade"
            ]
        },
        new()
        {
            Id = "bestiary.stormvermin_champion",
            Name = "Skaven Stormvermin Champion",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 5,
            Wounds = 11,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 270,
            Armour = 2,
            SpecialRules =
            [
                "Magic Weapon",
                "Never Pinned"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_warlock",
            Name = "Skaven Warlock",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Initiative = 4,
            Wounds = 15,
            Attacks = 1,
            Damage = "2D6",
            GoldPerModel = 560,
            Armour = 0,
            SpecialRules =
            [
                "Dodge 5+",
                "Skaven Magic 1",
                "Magic Dispel 6+"
            ]
        },
        new()
        {
            Id = "bestiary.skaven_master_warlock",
            Name = "Skaven Master Warlock",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 4,
            Initiative = 6,
            Wounds = 30,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 1900,
            Armour = 0,
            SpecialRules =
            [
                "Skaven Magic 3",
                "Magic Resistance 4+",
                "3 x Magic Item",
                "Magic Weapon"
            ]
        },
    ];
}
