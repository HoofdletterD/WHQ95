namespace WHQCore.Monsters.MonsterProfiles;

public static class ChaosMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
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
