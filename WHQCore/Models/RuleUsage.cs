namespace WHQCore.Models;

[Flags]
public enum RuleUsage
{
    None = 0,
    OneUseOnly = 1 << 0,
    OncePerDungeon = 1 << 1,
    Reusable = 1 << 2,
    DiscardAfterUse = 1 << 3,
    PassiveEffect = 1 << 4,
    RequiresAction = 1 << 5,
    // Add more as needed
}