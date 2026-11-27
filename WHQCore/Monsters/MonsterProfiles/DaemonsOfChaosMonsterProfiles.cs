namespace WHQCore.Monsters.MonsterProfiles;

public static class DaemonsOfChaosMonsterProfiles
{
    public static readonly List<MonsterProfile> Profiles =
    [
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
    ];
}
