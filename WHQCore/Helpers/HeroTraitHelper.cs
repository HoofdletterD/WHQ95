using System.Reflection;
using WHQCore.Models.Enums;

namespace WHQCore.Helpers;

public static class HeroTraitHelper
{
    public static IEnumerable<HeroTrait> GetTraitsByCategory(TraitCategory category)
    {
        return Enum.GetValues<HeroTrait>()
            .Where(t =>
            {
                var attr = t.GetType().GetField(t.ToString())?
                    .GetCustomAttribute<TraitCategoryAttribute>();
                return attr?.Category == category;
            });
    }
}