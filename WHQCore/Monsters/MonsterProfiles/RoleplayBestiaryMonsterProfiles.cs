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
            Id = "bestiary.chaos_warrior",
            Name = "Chaos Warrior",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 4,
            Initiative = 6,
            Wounds = 12,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 240,
            Armour = 2,
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
        },new()
        {
            Id = "bestiary.pink_horror",
            Name = "Pink Horror",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 3,
            Initiative = 6,
            Wounds = 8,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 200,
            Armour = 0,
            SpecialRules =
            [
                "Daemonic -1",
                "Fear 6",
                "Magic Resistance 6+",
                "Die → Blue Horrors"
            ]
        },
        new()
        {
            Id = "bestiary.blue_horror",
            Name = "Blue Horror",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Initiative = 7,
            Wounds = 4,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 100,
            Armour = 0,
            SpecialRules =
            [
                "Daemonic -1",
                "Fear 4",
                "Magic Resistance 6+"
            ]
        },
        new()
        {
            Id = "bestiary.fiend_of_slaanesh",
            Name = "Fiend of Slaanesh",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 3,
            Initiative = 3,
            Wounds = 8,
            Attacks = 3,
            Damage = "1",
            GoldPerModel = 250,
            Armour = 0,
            SpecialRules =
            [
                "Aura of Slaanesh",
                "Daemonic -1",
                "Fear 6"
            ]
        },
        new()
        {
            Id = "bestiary.bloodletter",
            Name = "Bloodletter",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 3,
            Initiative = 6,
            Wounds = 7,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 200,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Hellblade",
                "Daemonic -1",
                "Fear 5"
            ]
        },
        new()
        {
            Id = "bestiary.plaguebearer",
            Name = "Plaguebearer",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 3,
            Initiative = 6,
            Wounds = 9,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 200,
            Armour = 0,
            SpecialRules =
            [
                "Daemonic -1",
                "Fear 5",
                "Plague"
            ]
        },
        new()
        {
            Id = "bestiary.chaos_hound",
            Name = "Chaos Hound",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 4,
            Toughness = 4,
            Initiative = 4,
            Wounds = 8,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 160,
            Armour = 2,
            SpecialRules =
            [
                "Ambush 5+",
                "Gang Up"
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
            Id = "bestiary.daemonette_of_slaanesh",
            Name = "Daemonette of Slaanesh",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 3,
            Initiative = 6,
            Wounds = 15,
            Attacks = 3,
            Damage = "1",
            GoldPerModel = 300,
            Armour = 0,
            SpecialRules =
            [
                "Ambush 5+",
                "Daemonic -1",
                "Fear 6",
                "Magic Resistance 6+"
            ]
        },
        new()
        {
            Id = "bestiary.nurgling",
            Name = "Nurgling",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Initiative = 2,
            Wounds = 3,
            Attacks = 2,
            Damage = "S",
            GoldPerModel = 50,
            Armour = 0,
            SpecialRules =
            [
                "Ambush A",
                "Daemonic -1",
                "Fear 4",
                "Gang Up",
                "Plague"
            ]
        },
        new()
        {
            Id = "bestiary.flamer_of_tzeentch",
            Name = "Flamer of Tzeentch",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 9,
            WeaponSkill = 3,
            BallisticSkill = "2+",
            Strength = 5,
            Toughness = 4,
            Initiative = 4,
            Wounds = 17,
            Attacks = 0,
            Damage = "S",
            GoldPerModel = 300,
            Armour = 0,
            SpecialRules =
            [
                "Ambush",
                "Magic 5+",
                "Daemonic -1",
                "Fear 7",
                "Flamer of Tzeentch Attack",
                "Magic Resistance 6+"
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
            GoldPerModel =150,
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
            GoldPerModel =150,
            Armour = 2,
            Damage = "1"
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
            GoldPerModel =450,
            Armour = 0,
            Damage = "2"
        },
        new()
        {
            Id = "bestiary.chaos_dwarf_sorcerer",
            Name = "Chaos Dwarf Sorcerer",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 3,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 5,
            Wounds = 8,
            Initiative = 3,
            Attacks = 1,
            GoldPerModel =590,
            Armour = 2,
            Damage = "1/2(6+)"
        },
        new()
        {
            Id = "bestiary.beast_of_nurgle",
            Name = "Beast of Nurgle",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 3,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 5,
            Wounds = 25,
            Initiative = 3,
            Attacks = 1,
            GoldPerModel =750,
            Armour = 0,
            Damage = "2"
        },
        new()
        {
            Id = "bestiary.dragon_ogre",
            Name = "Dragon Ogre",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "5+",
            Strength = 5,
            Toughness = 5,
            Wounds = 40,
            Initiative = 2,
            Attacks = 3,
            GoldPerModel =870,
            Armour = 2,
            Damage = "2"
        },new()
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
            Id = "bestiary.mummy",
            Name = "Mummy",
            Allegiance = MonsterAllegiance.Undead,
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
            Id = "bestiary.chaos_champion",
            Name = "Chaos Champion",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 5,
            Toughness = 4,
            Wounds = 15,
            Initiative = 7,
            Attacks = 3,
            GoldPerModel = 910,
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
        },new()
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
        },new()
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
        },new()
        {
            Id = "bestiary.bull_centaur_champion",
            Name = "Bull Centaur Champion",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 8,
            WeaponSkill = 5,
            BallisticSkill = "3+",
            Strength = 5,
            Toughness = 4,
            Initiative = 4,
            Wounds = 23,
            Attacks = 3,
            Damage = "2",
            GoldPerModel = 1060,
            Armour = 2,
            SpecialRules =
            [
                "Fear 7",
                "Magic Resistance 5+",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon"
            ]
        },new()
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
        },new()
        {
            Id = "bestiary.tomb_guardian",
            Name = "Tomb Guardian",
            Allegiance = MonsterAllegiance.VampireCounts,
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
            Allegiance = MonsterAllegiance.VampireCounts,
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
        },new()
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
        },new()
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
        },new()
        {
            Id = "bestiary.beastman_shaman",
            Name = "Beastman Shaman",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 4,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 5,
            Initiative = 4,
            Wounds = 26,
            Attacks = 1,
            Damage = "1",
            GoldPerModel = 680,
            Armour = 0,
            SpecialRules =
            [
                "Beastman Magic 1",
                "Magic Weapon"
            ]
        },new()
        {
            Id = "bestiary.chaos_sorcerer",
            Name = "Chaos Sorcerer",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 4,
            Toughness = 5,
            Initiative = 6,
            Wounds = 15,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 840,
            Armour = 1,
            SpecialRules =
            [
                "Chaos Magic 1",
                "Magic Resistance 4+",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon"
            ]
        },
        ];
    }
