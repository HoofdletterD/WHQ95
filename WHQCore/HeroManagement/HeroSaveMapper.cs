using WHQCore.Helpers;
using WHQCore.Models;
using WHQCore.Libraries.Equipment;
using WHQCore.Libraries.MagicItems;
using WHQCore.Libraries.SpecialRules;
using WHQCore.Libraries;

namespace WHQCore.HeroManagement;

public static class HeroSaveMapper
{
    public static HeroSaveData ToSaveData(IHero hero)
    {
        var c = hero.Character;
        return new HeroSaveData
        {
            Name = c.Name,
            HeroType = c.HeroType,
            BattleLevel = c.BattleLevel,
            Gold = c.Gold,
            StartingWounds = c.StartingWounds,
            Movement = c.Movement,
            WeaponSkill = c.WeaponSkill,
            BallisticSkill = c.BallisticSkill,
            Strength = c.Strength,
            Toughness = c.Toughness,
            Initiative = c.Initiative,
            Attacks = c.Attacks,
            Luck = c.Luck,
            Willpower = c.Willpower,
            EscapePinning = c.EscapePinning,

            // Save skills with both Name and Value
            Skills = c.Skills
                .Select(s => new SkillSaveData { Name = s.Name, Value = s.Value })
                .ToList(),

            Spells = c.Spells.Select(s => s.SpellName).ToList(),
            Equipment = c.Equipment.Select(e => e.Name).ToList(),
            MagicItems = c.MagicItems.Select(m => m.Name).ToList(),
            SpecialRules = c.SpecialRules.Select(r => r.Name).ToList()
        };
    }

    public static IHero FromSaveData(HeroSaveData data)
    {
        // Find hero definition
        var heroDef = HeroRegistry.Heroes
            .FirstOrDefault(h => h.DisplayName.Equals(data.HeroType, StringComparison.OrdinalIgnoreCase));

        if (heroDef == null)
            throw new InvalidOperationException($"Unknown hero type: {data.HeroType}");

        // Create base hero
        IHero hero = heroDef.CreateBase(data.Name);
        var c = hero.Character;

        // Restore core stats
        c.BattleLevel = data.BattleLevel;
        c.Gold = data.Gold;
        c.StartingWounds = data.StartingWounds;
        c.Movement = data.Movement;
        c.WeaponSkill = data.WeaponSkill;
        c.BallisticSkill = data.BallisticSkill;
        c.Strength = data.Strength;
        c.Toughness = data.Toughness;
        c.Initiative = data.Initiative;
        c.Attacks = data.Attacks;
        c.Luck = data.Luck;
        c.Willpower = data.Willpower;
        c.EscapePinning = data.EscapePinning;

        // --- Clear lists before restoring ---
        c.Spells.Clear();
        c.Skills.Clear();
        c.Equipment.Clear();
        c.MagicItems.Clear();
        c.SpecialRules.Clear();

        // Restore spells
        foreach (var spellName in data.Spells)
        {
            var spell = SpellSelectionHelper.GetSpellByName(spellName);
            if (spell != null)
                c.Spells.Add(spell);
        }

        // Restore skills (skip for Wizard)
        if (!c.HeroType.Equals("Wizard", StringComparison.OrdinalIgnoreCase))
        {
            foreach (var savedSkill in data.Skills)
            {
                Skill? skill = null;

                // Try value first
                if (!string.IsNullOrWhiteSpace(savedSkill.Value))
                {
                    skill = SkillLibraryHelper.GetSkillByValueForHero(c.HeroType, savedSkill.Value);
                }

                // Fallback to name
                if (skill == null && !string.IsNullOrWhiteSpace(savedSkill.Name))
                {
                    skill = SkillLibraryHelper.GetSkillByNameForHero(c.HeroType, savedSkill.Name);
                }

                if (skill != null)
                {
                    c.Skills.Add(skill);
                }
            }
        }

        // Restore equipment
        foreach (var eq in data.Equipment)
        {
            var item = EquipmentLibrary.GetEquipmentByName(eq);
            if (item != null)
                c.Equipment.Add(item);
        }

        // Restore magic items
        foreach (var mi in data.MagicItems)
        {
            var magicItem = MagicItemLibrary.GetMagicItemByName(mi);
            if (magicItem != null)
                c.MagicItems.Add(magicItem);
        }

        // Restore magic weapons and armour
        foreach (var mi in data.MagicItems)
        {
            var MagicWeaponAndArmorItem = MagicWeaponsAndArmorLibrary.GetMagicWeaponsAndSwordsByName(mi);
            if (MagicWeaponAndArmorItem != null)
                c.MagicItems.Add(MagicWeaponAndArmorItem);
        }

        // Restore objective room treasure
        foreach (var mi in data.MagicItems)
        {
            var ObjectiveRoomItem = ObjectiveRoomTreasureLibrary.GetObjectiveRoomTreasureByName(mi);
            if (ObjectiveRoomItem != null)
                c.MagicItems.Add(ObjectiveRoomItem);
        }

        // Restore special rules
        foreach (var rule in data.SpecialRules)
        {
            var specialRule = SpecialRuleLibrary.GetSpecialRuleByName(rule);
            if (specialRule != null)
                c.SpecialRules.Add(specialRule);
        }

        return hero;
    }

    public static void TestSkillLoadingForAllHeroes(IHero hero, List<SkillSaveData> savedSkills)
    {
        var heroType = hero.Character.HeroType;

        Console.WriteLine($"Testing skill restoration for {hero.Character.Name} ({heroType})...");

        foreach (var savedSkill in savedSkills)
        {
            Skill? skill = null;

            if (!string.IsNullOrWhiteSpace(savedSkill.Value))
                skill = SkillLibraryHelper.GetSkillByValueForHero(heroType, savedSkill.Value);

            if (skill == null && !string.IsNullOrWhiteSpace(savedSkill.Name))
                skill = SkillLibraryHelper.GetSkillByNameForHero(heroType, savedSkill.Name);

            if (skill != null)
                Console.WriteLine($"Loaded skill: {skill.Name} ({skill.Value})");
            else
                Console.WriteLine($"Failed to load skill: Name='{savedSkill.Name}', Value='{savedSkill.Value}'");
        }
    }

}
