namespace WHQCore.Models.Enums;

public enum RuleUsage
{
    None = 0,
    OneUseOnly = 1 << 0,
    OncePerDungeon = 1 << 1,
    Reusable = 1 << 2,
    DiscardAfterUse = 1 << 3,
    PassiveEffect = 1 << 4,
    RequiresAction = 1 << 5,
    OncePerTurn,
    UnlimitedUses = 1 << 6,
    Permanent = 1 << 7,
}