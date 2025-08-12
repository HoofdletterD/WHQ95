using WHQCore.Models.Enums;

namespace WHQCore.Models;

public class Spell(
        string spellName,
        IEnumerable<SpellType> spellType,
        IEnumerable<Lore> lore,
        string flavor,
        string castingNumber,
        string rules,
        string spellTarget,
        string duration,
        string imagePath)
    {
    public string SpellName { get; } = spellName;

    public HashSet<SpellType> SpellTypes { get; } = [.. spellType];

    public HashSet<Lore> Lore { get; } = [.. lore];
    public string Flavor { get; } = flavor;
    public string CastingNumber { get; } = castingNumber;
    public string Rules { get; } = rules;

    public string SpellTarget { get; } = spellTarget;

    public string Duration { get; } = duration;
}