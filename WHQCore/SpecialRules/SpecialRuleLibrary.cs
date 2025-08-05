using WHQCore.Models;

namespace WHQCore.SpecialRules;

public static class SpecialRuleLibrary
{
    public static SpecialRule Fear(int rating)
    {
        return new SpecialRule(
            "Fear",
            $"Causes Fear with rating {rating}.",
            "Models affected by Fear must take a Leadership test at the start of their turn. Failure means they cannot move or attack that turn. The rating indicates the Leadership difficulty.",
            rating,
            ["Psychological", "Morale"],
            "images/fear_icon.png"
        );
    }

    public static SpecialRule Pinning(string value)
    {
        return new SpecialRule(
            "Pinning",
            $"Break from combat rolling {value}.",
            "If there is a Monster in a square adjacent to your Warrior at the start of the Warriors' Phase then your Warrior is 'pinned' by the Monster, and may not move. To escape from pinning you must roll a dice and score at least your pinning value (For this hero, {value}. If successful, the Warrior dodges out of the fight and is free to move normally. If unsuccessful, the Warrior must stay where he is and fight the Monster in hand-to-hand combat. He may not use a missile weapon while he is pinned. Note: No matter how many Monsters pin a Warrior in place, he only has to make one Pinning roll to escape.",
            categories: ["Combat", "Buff"],
            imagePath: "images/berserk_icon.png"
        );
    }
}