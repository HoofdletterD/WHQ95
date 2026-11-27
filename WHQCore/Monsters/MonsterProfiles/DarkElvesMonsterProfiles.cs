namespace WHQCore.Monsters.MonsterProfiles;

public static class DarkElvesMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "bestiary.dark_elf_warrior",
            Name = "Dark Elf Warrior",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 3,
            Toughness = 3,
            Initiative = 6,
            Wounds = 6,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 100,
            Armour = 1,
            SpecialRules =
            [
                "Armed with Crossbows (Str 4)",
                "Dodge 6+",
                "Hate Elves"
            ]
        },
        new()
        {
            Id = "bestiary.naggaroth_black_guard",
            Name = "Nagaroth Black Guard",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 4,
            Initiative = 7,
            Wounds = 6,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 150,
            Armour = 2,
            SpecialRules =
            [
                "Armed with Halberds",
                "Fight in Ranks",
                "Hate Elves"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf_beastmaster",
            Name = "Dark Elf Beastmaster",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
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
            Id = "bestiary.witch_elf",
            Name = "Witch Elf",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 3,
            Toughness = 3,
            Initiative = 6,
            Wounds = 11,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 140,
            Armour = 0,
            SpecialRules =
            [
                "Frenzy 4+",
                "Hate Elves"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf_assassin",
            Name = "Dark Elf Assassin",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 9,
            BallisticSkill = "A",
            Strength = 4,
            Toughness = 4,
            Initiative = 10,
            Wounds = 12,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 410,
            Armour = 0,
            SpecialRules =
            [
                "Ambush",
                "Magic 5+",
                "Assassinate 6+",
                "Dodge 5+",
                "Weeping Blades"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf_hero",
            Name = "Dark Elf Hero",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 4,
            Initiative = 8,
            Wounds = 25,
            Attacks = 3,
            Damage = "1",
            GoldPerModel = 1040,
            Armour = 4,
            SpecialRules =
            [
                "Dodge 4+",
                "Hate Elves",
                "Magic Resistance 5+",
                "Magic Armour",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.hydra",
            Name = "Hydra",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 6,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 6,
            Initiative = 3,
            Wounds = 70,
            Attacks = 5,
            Damage = "4",
            GoldPerModel = 2250,
            Armour = 3,
            SpecialRules =
            [
                "Breathe Fire 4",
                "Ignore Blows 5+",
                "Ignore Pain 7",
                "Large Monster",
                "Never Pinned",
                "Terror 11"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf",
            Name = "Dark Elf",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 3,
            Toughness = 3,
            Initiative = 6,
            Wounds = 6,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 100,
            Armour = 1,
            SpecialRules =
            [
                "Armed with Crossbows (Str 4)",
                "Dodge 6+",
                "Hate Elves"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf_champion",
            Name = "Dark Elf Champion",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 5,
            BallisticSkill = "5",
            Strength = 4,
            Toughness = 3,
            Initiative = 7,
            Wounds = 14,
            Attacks = 2,
            Damage = "2D6",
            GoldPerModel = 480,
            Armour = 2,
            SpecialRules =
            [
                "Dodge 6+",
                "Hate Elves",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf_lord",
            Name = "Dark Elf Lord",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 4,
            Toughness = 4,
            Initiative = 9,
            Wounds = 34,
            Attacks = 4,
            Damage = "3D6",
            GoldPerModel = 1600,
            Armour = 4,
            SpecialRules =
            [
                "Dodge 4+",
                "Hate Elves",
                "Magic Resistance 5+",
                "Magic Armour",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.dark_elf_sorcerer",
            Name = "Dark Elf Sorcerer",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 4,
            BallisticSkill = "3+",
            Strength = 3,
            Toughness = 4,
            Initiative = 7,
            Wounds = 12,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 590,
            Armour = 0,
            SpecialRules =
            [
                "Dark Elf Magic 1",
                "Hate Elves",
                "Magic Resistance 6+",
                "Magic Item"
            ]
        },
    ];
}
