using WHQApp.Models;

namespace WHQApp.Helpers
{
    public static class StatProgressionApplier
    {
        public static void Apply(Hero character, ILevelProgression progression)
        {
            character.Title = progression.Title;

            if (progression.Movement.HasValue)
                character.Movement = progression.Movement.Value;

            if (progression.WeaponSkill.HasValue)
                character.WeaponSkill = progression.WeaponSkill.Value;

            if (!string.IsNullOrWhiteSpace(progression.BallisticSkill))
                character.BallisticSkill = progression.BallisticSkill;
            
            if (progression.Strength.HasValue)
                character.Strength = progression.Strength.Value;
            
            if (progression.Toughness.HasValue)
                character.Toughness = progression.Toughness.Value;

            if (progression.Luck.HasValue)
                character.Luck = progression.Luck.Value;

            if (progression.Willpower.HasValue)
                character.Willpower = progression.Willpower.Value;

            if (progression.Attacks.HasValue)
                character.Attacks = progression.Attacks.Value;

            if (progression.Initiative.HasValue)
                character.Initiative = progression.Initiative.Value;

            if (progression.DamageDice.HasValue)
                character.DamageDice = progression.DamageDice.Value;

            if (!string.IsNullOrWhiteSpace(progression.EscapePinning))
                character.EscapePinning = progression.EscapePinning;
        }
    }
}