using System.Reflection;
using WHQCore.Models;

namespace WHQCore.Helpers
{
    public static class SkillLibraryHelper
    {
        public static Skill? GetSkillByNameForHero(string heroType, string skillName)
        {
            if (string.IsNullOrWhiteSpace(heroType) || string.IsNullOrWhiteSpace(skillName))
                return null;

            var libType = GetSkillLibraryType(heroType);
            if (libType == null)
                return null;

            var skills = libType
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => f.FieldType == typeof(Skill))
                .Select(f => (Skill)f.GetValue(null));

            return skills.FirstOrDefault(s =>
                s.Name.Equals(skillName, StringComparison.OrdinalIgnoreCase));
        }

        public static Skill? GetSkillByValueForHero(string heroType, string value)
        {
            if (string.IsNullOrWhiteSpace(heroType) || string.IsNullOrWhiteSpace(value))
                return null;

            var libType = GetSkillLibraryType(heroType);
            if (libType == null)
                return null;

            // Look for a public static method named "GetSkillByValue"
            var method = libType.GetMethod("GetSkillByValue", BindingFlags.Public | BindingFlags.Static);
            if (method == null)
                return null;

            return method.Invoke(null, new object[] { value }) as Skill;
        }

        private static Type? GetSkillLibraryType(string heroType)
        {
            var assembly = typeof(SkillLibraryHelper).Assembly;
            var expectedClassName = $"{heroType.Replace(" ", "")}SkillsLibrary";

            return assembly.GetTypes()
                .FirstOrDefault(t =>
                    t.IsAbstract && t.IsSealed &&
                    t.Name.Equals(expectedClassName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
