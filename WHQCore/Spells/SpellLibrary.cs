using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Spells;

public static class SpellLibrary
{
    public static Spell Bloodblade => new(
        spellName:"Bloodblade",
        spellType: [SpellType.Attack],
        lore: [Lore.Death],
        flavor:"The Wizard's sword glows as a thick red liquid coagulates on the blade.",
        castingNumber: "1",
        rules: "Roll 1D6 for each Monster adjacent to the Wizard. On a score of 6 that target takes 1 Wound, with no modifiers for Toughness or armour. This spell may be cast once per turn.",
        spellTarget: "All monsters adjacent to the wizard",
        duration: "Immediate",
        imagePath: "images/Spell/Bloodblade.png"
    );

    public static Spell GetSpellByValue(string value)
    {
        var allSkills = new List<Spell>
        {
            Bloodblade
        };

        return allSkills.FirstOrDefault(s => s.CastingNumber == value);
    }
}
