using WHQCore.Models;

namespace WHQCore.Libraries.SpecialRules;

public static class SpecialRuleLibrary
{
    public static SpecialRule Ambush(string value)
    {
        return new SpecialRule(
            "Ambush",
            $"Placed monsters will attack out of sequence.",
            "Some Monsters are able to Ambush the Warriors, springing from the darkness and attacking them before they have the chance to react. Each type of Monster with the Ambush ability has an Ambush Rating (n) that shows the score they need on 106 to successfully spring their Ambush. Daemonettes of Slaanesh, for instance, have Ambush 5+, and therefore need a score of 5 or 6 on 1D6 to successfully Ambush the Warriors. An Ambush Rating of 'A' indicates that the Monster automatically succeeds in making its Ambush and doesn't need to roll. Monsters that successfully carry out an Ambush may ignore the rule about waiting until the next Monsters' Phase before they attack. If the Monsters appear in the Power Phase, for instance, they are placed and make one set of attacks in that phase and attack in the Monsters' Phase. Once such Monsters have sprung their ambush they fight only in the Monsters' Phase from then on, as normal. Note that as any sort of attach may be an Ambush, special abilities that are also Ambushes are indicated with the suffix 'Ambush' in the Monster Tables. A Hydra, for instance, has the Breathe Fire 4 (Ambush A) Special Ability, indicating that it makes an automatically successful Ambush with its 4D6 damage Breathe Fire attack when it is first placed on the board",
            categories: ["Monster", "Placement"],
            imagePath: "images/Ambush_Icon.png"
        );
    }
    
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







    public static SpecialRule? GetSpecialRuleByName(string name)
    {
        var type = typeof(SpecialRuleLibrary);
        var props = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);

        foreach (var prop in props)
        {
            if (prop.PropertyType == typeof(SpecialRule))
            {
                var item = (SpecialRule)prop.GetValue(null);
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
        }
        return null;
    }
}