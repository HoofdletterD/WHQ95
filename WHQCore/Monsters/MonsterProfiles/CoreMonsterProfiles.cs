using WHQCore.Monsters;

namespace WHQCore.Data;

public static class CoreMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
        new()
        {
            Id = "core.orc_warrior",
            Name = "Orc Warrior",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Wounds = 3,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 55,
            Armour = 0
        },
        new()
        {
            Id = "core.orc_archer",
            Name = "Orc Archer",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 4,
            Wounds = 3,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 55,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Bow (Strength 3)"
            ]
        },
        new()
        {
            Id = "core.goblin_warrior",
            Name = "Goblin Warrior",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Wounds = 2,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 20,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Spear"
            ]
        },
        new()
        {
            Id = "core.night_goblin_archer",
            Name = "Night Goblin Archer",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 2,
            BallisticSkill = "5+",
            Strength = 3,
            Toughness = 3,
            Wounds = 2,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 20,
            Armour = 0,
            SpecialRules =
            [
                "Armed with Bow (Strength 1)"
            ]
        },
        new()
        {
            Id = "core.snotling",
            Name = "Snotling",
            Allegiance = MonsterAllegiance.Greenskins,
            Move = 4,
            WeaponSkill = 1,
            BallisticSkill = "-",
            Strength = 1,
            Toughness = 1,
            Wounds = 1,
            Attacks = 1,
            Damage = "1D6",
            GoldPerModel = 10,
            Armour = 0,
            SpecialRules =["Ambush"]
        },
        new()
        {
            Id = "core.skaven_warrior",
            Name = "Skaven Warrior",
            Allegiance = MonsterAllegiance.Skaven,
            Move = 5,
            WeaponSkill = 3,
            BallisticSkill = "4+",
            Strength = 3,
            Toughness = 3,
            Wounds = 3,
            Attacks = 1,
            Damage = "2D6",
            GoldPerModel = 40,
            Armour = 0
        },
        new()
        {
            Id = "core.minotaur",
            Name = "Minotaur",
            Allegiance = MonsterAllegiance.Beastmen,
            Move = 6,
            WeaponSkill = 4,
            BallisticSkill = "4+",
            Strength = 4,
            Toughness = 4,
            Wounds = 4,
            Attacks = 2,
            Damage = "1",
            GoldPerModel = 440,
            Armour = 0,
            SpecialRules =
            [
                "Causes 2D6+4 Wounds"
            ]
        },
        new()
        {
            Id = "core.giant_spiders",
            Name = "Giant Spiders",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 2,
            BallisticSkill = "-",
            Strength = 0,
            Toughness = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "2D6",
            GoldPerModel = 15,
            Armour = 0,
            SpecialRules =
            [
                "Webattack"
            ]
        },
        new()
        {
            Id = "core.giant_rats",
            Name = "Giant Rats",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 6,
            WeaponSkill = 2,
            BallisticSkill = "-",
            Strength = 2,
            Toughness = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "2D6",
            GoldPerModel = 20,
            Armour = 0,
            SpecialRules =
            [
                "Deathleap"
            ]
        },
        new()
        {
            Id = "core.giant_bats",
            Name = "Giant Bats",
            Allegiance = MonsterAllegiance.Neutral,
            Move = 8,
            WeaponSkill = 2,
            BallisticSkill = "-",
            Strength = 2,
            Toughness = 2,
            Wounds = 2,
            Attacks = 1,
            Damage = "2D6",
            GoldPerModel = 15,
            Armour = 0,
            SpecialRules =["Ambush"]
        }
    ];
}
