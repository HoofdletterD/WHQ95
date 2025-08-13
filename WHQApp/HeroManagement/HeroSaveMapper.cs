using WHQCore.Helpers;
using WHQCore.Models;
using WHQCore.Skills;
using WHQCore.Equipment;
using WHQCore.MagicItems;
using WHQCore.SpecialRules;

namespace WHQCreator.HeroManagement;

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
            Equipment = c.Equipment.Select(e => e.ToString()).ToList(),
            MagicItems = c.MagicItems.Select(m => m.ToString()).ToList(),
            SpecialRules = c.SpecialRules.Select(r => r.ToString()).ToList()
        };
    }

    public static IHero FromSaveData(HeroSaveData data)
    {
        // Find hero definition
        var heroDef = HeroRegistry.Heroes
            .FirstOrDefault(h => h.DisplayName.Equals(data.HeroType, StringComparison.OrdinalIgnoreCase));

        if (heroDef == null)
        {
            throw new InvalidOperationException($"Unknown hero type: {data.HeroType}");
        }

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
                Skill skill = null;

                // Try value first
                if (!string.IsNullOrWhiteSpace(savedSkill.Value))
                {
                    skill = SkillLibraryHelper.GetSkillByValueForHero(c.HeroType, savedSkill.Value);
                }

                // Fallback to name
                if (skill == null)
                {
                    skill = SkillLibraryHelper.GetSkillByNameForHero(c.HeroType, savedSkill.Name);
                }

                if (skill != null && !c.Skills.Any(s => s.Name.Equals(skill.Name, StringComparison.OrdinalIgnoreCase)))
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

        // Restore special rules
        foreach (var rule in data.SpecialRules)
        {
            var specialRule = SpecialRuleLibrary.GetSpecialRuleByName(rule);
            if (specialRule != null)
                c.SpecialRules.Add(specialRule);
        }

        return hero;
    }
}
