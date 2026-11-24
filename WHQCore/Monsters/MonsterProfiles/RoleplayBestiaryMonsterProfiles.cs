namespace WHQCore.Monsters.MonsterProfiles;

    public static class RoleplayBestiaryMonsterProfiles
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
            Initiative = 5,
            Wounds = 3,
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
            Id = "bestiary.naggaroth_black_guard",
            Name = "Nagaroth Black Guard",
            Allegiance = MonsterAllegiance.DarkElves,
            Move = 5,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 4,
            Toughness = 4,
            Initiative = 6,
            Wounds = 7,
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
        }
        ];
    }
