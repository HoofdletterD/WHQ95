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
        },
        new()
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
            GoldPerModel = 590,
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
            GoldPerModel = 750,
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
            GoldPerModel = 870,
            Armour = 2,
            Damage = "2"
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
        },
        new()
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
            Id = "bestiary.necromancer_champion",
            Name = "Necromancer Champion",
            Allegiance = MonsterAllegiance.Undead,
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
            Id = "bestiary.dragon_ogre_champion",
            Name = "Dragon Ogre Champion",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 5,
            BallisticSkill = "4+",
            Strength = 6,
            Toughness = 5,
            Initiative = 3,
            Wounds = 44,
            Attacks = 4,
            Damage = "2",
            GoldPerModel = 1550,
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
            Id = "bestiary.lord_of_change",
            Name = "Lord of Change",
            Allegiance = MonsterAllegiance.DaemonsOfChaos,
            Move = 8,
            WeaponSkill = 9,
            BallisticSkill = "A",
            Strength = 7,
            Toughness = 7,
            Initiative = 10,
            Wounds = 75,
            Attacks = 6,
            Damage = "6D6",
            GoldPerModel = 5000,
            Armour = 4,
            SpecialRules =
            [
                "Ambush",
                "Magic A",
                "Greater Daemon 13",
                "Chaos Magic 5",
                "Fly",
                "Ignore Blows 5+",
                "Ignore Pain 7",
                "Large Monster",
                "Magic Source",
                "3 x Magic Items",
                "Power of Tzeentch"
            ]
        },

        new()
        {
            Id = "bestiary.keeper_of_secrets",
            Name = "Keeper of Secrets",
            Allegiance = MonsterAllegiance.DaemonsOfChaos,
            Move = 6,
            WeaponSkill = 9,
            BallisticSkill = "A",
            Strength = 7,
            Toughness = 7,
            Initiative = 7,
            Wounds = 84,
            Attacks = 6,
            Damage = "6",
            GoldPerModel = 5500,
            Armour = 4,
            SpecialRules =
            [
                "Ambush",
                "Magic 2+",
                "Aura of Slaanesh",
                "Greater Daemon 13",
                "Ignore Blows 5+",
                "Ignore Pain 7",
                "Large Monster",
                "Chaos Magic 4",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Never Pinned"
            ]
        },

        new()
        {
            Id = "bestiary.great_unclean_one",
            Name = "Great Unclean One",
            Allegiance = MonsterAllegiance.DaemonsOfChaos,
            Move = 4,
            WeaponSkill = 7,
            BallisticSkill = "A",
            Strength = 7,
            Toughness = 8,
            Initiative = 4,
            Wounds = 100,
            Attacks = 7,
            Damage = "6",
            GoldPerModel = 5500,
            Armour = 4,
            SpecialRules =
            [
                "Ambush",
                "Magic 5+",
                "Chaos Magic 4",
                "Greater Daemon 13",
                "Ignore Blows 5+",
                "Ignore Pain 10",
                "Large Monster",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Plague",
                "Stream of Corruption"
            ]
        },

        new()
        {
            Id = "bestiary.bloodthirster",
            Name = "Bloodthirster",
            Allegiance = MonsterAllegiance.DaemonsOfChaos,
            Move = 6,
            WeaponSkill = 10,
            BallisticSkill = "A",
            Strength = 8,
            Toughness = 7,
            Initiative = 8,
            Wounds = 125,
            Attacks = 10,
            Damage = "8",
            GoldPerModel = 8000,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Axe of Khorne",
                "Armed with Daemon Whip",
                "Drain Power",
                "Fly",
                "Greater Daemon 14",
                "Ignore Blows 3+",
                "Ignore Pain 12",
                "Large Monster",
                "Magic Drain 5+"
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
            Id = "bestiary.chaos_lord",
            Name = "Chaos Lord",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 9,
            BallisticSkill = "A",
            Strength = 5,
            Toughness = 5,
            Initiative = 9,
            Wounds = 35,
            Attacks = 5,
            Damage = "4",
            GoldPerModel = 3050,
            Armour = 6,
            SpecialRules =
            [
                "Magic Armour",
                "3 x Magic Items",
                "Magic Weapon"
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
            Id = "bestiary.master_chaos_sorcerer",
            Name = "Master Chaos Sorcerer",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 6,
            BallisticSkill = "1+",
            Strength = 5,
            Toughness = 5,
            Initiative = 8,
            Wounds = 31,
            Attacks = 3,
            Damage = "4",
            GoldPerModel = 2400,
            Armour = 1,
            SpecialRules =
            [
                "Chaos Magic 3",
                "Magic Dispel 4+",
                "Magic Resistance 4+",
                "Magic Armour",
                "3 x Magic Items",
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
            Id = "bestiary.giant",
            Name = "Giant",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 7,
            Toughness = 6,
            Initiative = 3,
            Wounds = 64,
            Attacks = 0,
            Damage = "5",
            GoldPerModel = 2000,
            Armour = 5,
            SpecialRules =
            [
                "Fear 11",
                "Giant Attacks",
                "Ignore Blows 5+",
                "Ignore Pain 10",
                "Large Monster",
                "Never Pinned"
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
            Id = "bestiary.manticore",
            Name = "Manticore",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 6,
            BallisticSkill = "-",
            Strength = 7,
            Toughness = 7,
            Initiative = 4,
            Wounds = 50,
            Attacks = 4,
            Damage = "4",
            GoldPerModel = 2000,
            Armour = 0,
            SpecialRules =
            [
                "Fly",
                "Manticore Sting",
                "Terror 11"
            ]
        },
        new()
        {
            Id = "bestiary.necromancer_lord",
            Name = "Necromancer Lord",
            Allegiance = MonsterAllegiance.Undead,
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
            Allegiance = MonsterAllegiance.Undead,
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
            Id = "bestiary.chaos_hero",
            Name = "Chaos Hero",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 4,
            WeaponSkill = 8,
            BallisticSkill = "A",
            Strength = 5,
            Toughness = 5,
            Initiative = 8,
            Wounds = 30,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 1930,
            Armour = 6,
            SpecialRules =
            [
                "Magic Armour",
                "2 x Magic Item",
                "Magic Weapon"
            ]
        },
        new()
        {
            Id = "bestiary.dragon_ogre_hero",
            Name = "Dragon Ogre Hero",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 6,
            BallisticSkill = "3+",
            Strength = 6,
            Toughness = 5,
            Initiative = 4,
            Wounds = 53,
            Attacks = 4,
            Damage = "3",
            GoldPerModel = 3300,
            Armour = 2,
            SpecialRules =
            [
                "Fear 9",
                "Magic Armour",
                "Magic Item",
                "Magic Weapon"
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
            Id = "bestiary.chimera",
            Name = "Chimera",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 7,
            Toughness = 6,
            Initiative = 4,
            Wounds = 60,
            Attacks = 6,
            Damage = "3D6/4D6(5+)",
            GoldPerModel = 2500,
            Armour = 3,
            SpecialRules =
            [
                "Breathe Fire 4",
                "Ambush A",
                "Ignore Blows 5+",
                "Ignore Pain 7",
                "Large Monster",
                "Sting (3D6)",
                "Terror 11"
            ]
        },

        new()
        {
            Id = "bestiary.wyvern",
            Name = "Wyvern",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 5,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 6,
            Initiative = 4,
            Wounds = 46,
            Attacks = 3,
            Damage = "3D6/4D6(5+)",
            GoldPerModel = 1800,
            Armour = 3,
            SpecialRules =
            [
                "Drag and Rend",
                "Fly",
                "Ignore Blows 5+",
                "Ignore Pain 6",
                "Large Monster",
                "Never Pinned",
                "Sting (3D6)",
                "Terror 10"
            ]
        },
        new()
        {
            Id = "bestiary.warhound",
            Name = "Warhound",
            Allegiance = MonsterAllegiance.Chaos,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "-",
            Strength = 3,
            Toughness = 3,
            Initiative = 6,
            Wounds = 6,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 130,
            Armour = 0,
            SpecialRules =
            [
                "Ambush 5+",
                "Gang Up"
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

        new()
        {
            Id = "bestiary.plaguebearer_of_nurgle",
            Name = "Plaguebearer",
            Allegiance = MonsterAllegiance.DaemonsOfChaos,
            Move = 4,
            WeaponSkill = 5,
            BallisticSkill = "2+",
            Strength = 4,
            Toughness = 3,
            Initiative = 6,
            Wounds = 9,
            Attacks = 2,
            Damage = "1D6",
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
            Id = "bestiary.juggernaut_of_khorne",
            Name = "Juggernaut Of Khorne",
            Allegiance = MonsterAllegiance.DaemonsOfChaos,
            Move = 7,
            WeaponSkill = 3,
            BallisticSkill = "-",
            Strength = 5,
            Toughness = 5,
            Initiative = 2,
            Wounds = 35,
            Attacks = 3,
            Damage = "2D6",
            GoldPerModel = 700,
            Armour = 2,
            SpecialRules =
            [
                "Daemonic -1",
                "Fear 7",
                "Magic Resistance 5+",
                "Never Pinned"
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

        new()
        {
            Id = "bestiary.necromancer",
            Name = "Necromancer",
            Allegiance = MonsterAllegiance.Undead,
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
            Allegiance = MonsterAllegiance.Undead,
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
            Allegiance = MonsterAllegiance.Undead,
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
        new()
        {
            Id = "bestiary.chaos_warrior_rider",
            Name = "Chaos Warrior Rider",
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
            SpecialRules =
            [
                "Mounted on Juggernaut of Khorne",
                "Choose whether Warriors attack Rider or Juggernaut"
            ]
        },
    ];
}