namespace WHQCore.Monsters.MonsterProfiles;

public static class GreenskinsMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.savage_orc",
            Name = "Savage Orc",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Initiative = 5,
            Wounds = 5,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 65,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Bows (Str 3)",
                "*Tattoos 6+"
            ]
        },
        new()
        {
            Id = "bestiary.goblin_shaman",
            Name = "Goblin Shaman",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 4,
            Initiative = 3,
            Wounds = 3,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 280,
            Armour = 0,
            SpecialRules =
            [
                "Goblin Magic 1",
                "Magic Resistance 5+ (Ring)"
            ]
        },
        new()
        {
            Id = "bestiary.goblin_netter",
            Name = "Goblin Netter",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Initiative = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 35,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Nets"
            ]
        },
        new()
        {
            Id = "bestiary.cave_squig",
            Name = "Cave Squig",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 0,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 3,
            Initiative = 3,
            Wounds = 5,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 200,
            Armour = 0,
            SpecialRules =
            [
                "Never Pinned",
                "Wild Squig Attack"
            ]
        },
        new()
        {
            Id = "bestiary.goblin_squig_hunter",
            Name = "Goblin Squig Hunter",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Initiative = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 25,
            Armour = 0,
            SpecialRules =
            [
                "Herd Squigs"
            ]
        },
        new()
        {
            Id = "bestiary.black_orc",
            Name = "Black Orc",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 4,
            Initiative = 2,
            Wounds = 7,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 90,
            Armour = 1,
            SpecialRules = []
        },
        new()
        {
            Id = "bestiary.goblin_boss",
            Name = "Goblin Boss",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 3,
            Initiative = 3,
            Wounds = 6,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 150,
            Armour = 2,
            SpecialRules =
            [
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.savage_orc_shaman",
            Name = "Savage Orc Shaman",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 5,
            Initiative = 3,
            Wounds = 16,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 590,
            Armour = 0,
            SpecialRules =
            [
                "Orc Magic 1",
                "Magic Resistance 6+",
                "Magic Weapon",
                "*Tattoos 5+"
            ]
        },
        new()
        {
            Id = "bestiary.black_orc_champion",
            Name = "Black Orc Champion",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 5,
            Toughness = 4,
            Wounds = 20,
            Initiative = 3,
            Attacks = 2,
            GoldPerModel = 420,
            Armour = 2,
            Damage = "2"
        },
        new()
        {
            Id = "bestiary.black_orc_boss",
            Name = "Black Orc Boss",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 5,
            Toughness = 4,
            Wounds = 15,
            Initiative = 7,
            Attacks = 2,
            GoldPerModel = 150,
            Armour = 2,
            Damage = "1"
        },
        new()
        {
            Id = "bestiary.black_orc_big_boss",
            Name = "Black Orc Big Boss",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 5,
            Toughness = 5,
            Initiative = 4,
            Wounds = 23,
            Attacks = 3,
            Damage = "2",
            GoldPerModel = 910,
            Armour = 3,
            SpecialRules =
            [
                "Ignore Pain 6+",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.orc_shaman",
            Name = "Orc Shaman",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 5,
            Initiative = 3,
            Wounds = 16,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 590,
            Armour = 0,
            SpecialRules =
            [
                "Orc Magic 1",
                "Magic Resistance 6+",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.orc_big_boss",
            Name = "Orc Big Boss",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 5,
            Initiative = 4,
            Wounds = 25,
            Attacks = 3,
            Damage = "2",
            GoldPerModel = 720,
            Armour = 3,
            SpecialRules =
            [
                "Ignore Pain 6+",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.orc_shaman_champion",
            Name = "Orc Shaman Champion",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 5,
            Initiative = 3,
            Wounds = 20,
            Attacks = 3,
            Damage = "1/2(5+)",
            GoldPerModel = 1180,
            Armour = 2,
            SpecialRules =
            [
                "Orc Magic 3",
                "Magic Resistance 5+",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.orc_war_boss",
            Name = "Orc War Boss",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 5,
            Toughness = 5,
            Initiative = 5,
            Wounds = 33,
            Attacks = 4,
            Damage = "2D6/3D6(5+)",
            GoldPerModel = 1400,
            Armour = 3,
            SpecialRules =
            [
                "Ignore Pain 5+",
                "Magic Armour",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.orc_shaman_lord",
            Name = "Orc Shaman Lord",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "5+",
            Strength = 4,
            Toughness = 5,
            Initiative = 5,
            Wounds = 42,
            Attacks = 3,
            Damage = "2D6/3D6(5+)",
            GoldPerModel = 2870,
            Armour = 2,
            SpecialRules =
            [
                "Orc Magic 3",
                "Magic Dispel 5+",
                "Magic Resistance 4+",
                "Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.goblin",
            Name = "Goblin",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Initiative = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 20,
            Armour = 0,
            SpecialRules =
            [
                "Armed with [1-3] Bows (Str 1) or [4-6] Spears (Fight in Ranks)"
            ]
        },
        new()
        {
            Id = "bestiary.goblin_big_boss",
            Name = "Goblin Big Boss",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 4,
            Initiative = 4,
            Wounds = 12,
            Attacks = 2,
            Damage = "1D6",
            GoldPerModel = 330,
            Armour = 2,
            SpecialRules =
            [
                "Magic Weapon",
                "Magic Resistance 5+"
            ]
        },
        new()
        {
            Id = "bestiary.goblin_fanatic",
            Name = "Goblin Fanatic",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Initiative = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "Special",
            GoldPerModel = 300,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Ball and Chain",
                "Never Pinned"
            ]
        },
    ];
}
