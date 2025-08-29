namespace WHQCore.Models.Enums;

public enum TraitCategory
{
    Positive,
    Neutral,
    Negative
}

[AttributeUsage(AttributeTargets.Field)]
public class TraitCategoryAttribute : Attribute
{
    public TraitCategory Category { get; }
    public TraitCategoryAttribute(TraitCategory category) => Category = category;
}

public enum HeroTrait
{
    // Positive traits
    [TraitCategory(TraitCategory.Positive)]
    Brave,
    [TraitCategory(TraitCategory.Positive)]
    Clever,
    [TraitCategory(TraitCategory.Positive)]
    Charismatic,
    [TraitCategory(TraitCategory.Positive)]
    Loyal,
    [TraitCategory(TraitCategory.Positive)]
    Resourceful,
    [TraitCategory(TraitCategory.Positive)]
    Steadfast,
    [TraitCategory(TraitCategory.Positive)]
    Agile,
    [TraitCategory(TraitCategory.Positive)]
    StrongWilled,

    // Neutral / quirky traits
    [TraitCategory(TraitCategory.Neutral)]
    Curious,
    [TraitCategory(TraitCategory.Neutral)]
    Reckless,
    [TraitCategory(TraitCategory.Neutral)]
    Superstitious,
    [TraitCategory(TraitCategory.Neutral)]
    Pessimistic,
    [TraitCategory(TraitCategory.Neutral)]
    Optimistic,
    [TraitCategory(TraitCategory.Neutral)]
    Talkative,
    [TraitCategory(TraitCategory.Neutral)]
    Sneaky,

    // Negative traits
    [TraitCategory(TraitCategory.Negative)]
    Greedy,
    [TraitCategory(TraitCategory.Negative)]
    Cowardly,
    [TraitCategory(TraitCategory.Negative)]
    Impulsive,
    [TraitCategory(TraitCategory.Negative)]
    ShortTempered,
    [TraitCategory(TraitCategory.Negative)]
    Arrogant,
    [TraitCategory(TraitCategory.Negative)]
    Clumsy,
    [TraitCategory(TraitCategory.Negative)]
    Forgetful
}