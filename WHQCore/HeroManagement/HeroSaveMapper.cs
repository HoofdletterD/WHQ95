using WHQCore.Helpers;
using WHQCore.Models;
using WHQCore.Libraries;
using WHQCore.Libraries.MagicItems;
using WHQCore.Libraries.Equipment;
using WHQCore.Libraries.SpecialRules;
using System.Linq;

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

            Skills = c.Skills.Select(s => new SkillSaveData { Name = s.Name, Value = s.Value }).ToList(),
            Spells = c.Spells.Select(s => s.SpellName).ToList(),
            Equipment = c.Equipment.Select(e => e.Name).ToList(),

            // Save Magic Items by name per library
            MagicItems = c.MagicItems
                .Where(mi => TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicItemLibrary))
                             .Any(lib => lib.Name == mi.Name))
                .GroupBy(mi => mi.Name).Select(g => g.First()).ToList(),

            MagicWeaponsAndArmor = c.MagicItems
                .Where(mi => TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicWeaponsAndArmorLibrary))
                             .Any(lib => lib.Name == mi.Name))
                .GroupBy(mi => mi.Name).Select(g => g.First()).ToList(),

            ObjectiveRoomTreasure = c.MagicItems
                .Where(mi => TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(ObjectiveRoomTreasureLibrary))
                             .Any(lib => lib.Name == mi.Name))
                .GroupBy(mi => mi.Name).Select(g => g.First()).ToList(),

            SpecialRules = c.SpecialRules.Select(r => r.Name).ToList()
        };
    }

    public static IHero FromSaveData(HeroSaveData data)
    {
        var heroDef = HeroRegistry.Heroes
            .FirstOrDefault(h => h.DisplayName.Equals(data.HeroType, System.StringComparison.OrdinalIgnoreCase));

        if (heroDef == null)
            throw new InvalidOperationException($"Unknown hero type: {data.HeroType}");

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

        // Clear lists before restoring
        c.Spells.Clear();
        c.Skills.Clear();
        c.Equipment.Clear();
        c.MagicItems.Clear();
        c.SpecialRules.Clear();

        // Restore Spells
        foreach (var spellName in data.Spells)
        {
            var spell = SpellSelectionHelper.GetSpellByName(spellName);
            if (spell != null)
                c.Spells.Add(spell);
        }

        // Restore Skills (skip Wizard)
        if (!c.HeroType.Equals("Wizard", System.StringComparison.OrdinalIgnoreCase))
        {
            foreach (var savedSkill in data.Skills)
            {
                Skill? skill = null;
                if (!string.IsNullOrWhiteSpace(savedSkill.Value))
                    skill = SkillLibraryHelper.GetSkillByValueForHero(c.HeroType, savedSkill.Value);

                if (skill == null && !string.IsNullOrWhiteSpace(savedSkill.Name))
                    skill = SkillLibraryHelper.GetSkillByNameForHero(c.HeroType, savedSkill.Name);

                if (skill != null)
                    c.Skills.Add(skill);
            }
        }

        // Restore Equipment
        foreach (var eq in data.Equipment)
        {
            var item = EquipmentLibrary.GetEquipmentByName(eq);
            if (item != null)
                c.Equipment.Add(item);
        }

        // Restore MagicItemLibrary items
        foreach (var item in data.MagicItems.GroupBy(mi => mi.Name).Select(g => g.First()))
        {
            var mi = TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicItemLibrary))
                .FirstOrDefault(x => x.Name == item.Name);
            if (mi != null)
                c.MagicItems.Add(mi);
        }

        // Restore MagicWeaponsAndArmorLibrary items
        foreach (var item in data.MagicWeaponsAndArmor.GroupBy(mi => mi.Name).Select(g => g.First()))
        {
            var mi = TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(MagicWeaponsAndArmorLibrary))
                .FirstOrDefault(x => x.Name == item.Name);
            if (mi != null)
                c.MagicItems.Add(mi);
        }

        // Restore ObjectiveRoomTreasureLibrary items
        foreach (var item in data.ObjectiveRoomTreasure.GroupBy(mi => mi.Name).Select(g => g.First()))
        {
            var mi = TreasureLibraryHelper.GetAllItemsFromLibrary(typeof(ObjectiveRoomTreasureLibrary))
                .FirstOrDefault(x => x.Name == item.Name);
            if (mi != null)
                c.MagicItems.Add(mi);
        }

        // Restore SpecialRules
        foreach (var ruleName in data.SpecialRules)
        {
            var specialRule = SpecialRuleLibrary.GetSpecialRuleByName(ruleName);
            if (specialRule != null)
                c.SpecialRules.Add(specialRule);
        }

        return hero;
    }
}
