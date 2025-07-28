namespace WHQApp.Logic;

public static class DiceRoller
{
    private static readonly Random _random = new();

    public static int RollD6()
    {
        return _random.Next(1, 7);
    }

    public static int Roll2D6()
    {
        return RollD6() + RollD6();
    }

    public static DiceRollResult RollD6WithRerollIfOne(out int first, out int reroll)
    {
        first = RollD6();

        if (first == 1)
        {
            reroll = RollD6();
            return new DiceRollResult
            {
                FirstRoll = first,
                Reroll = reroll
            };
        }

        reroll = 0; // no reroll needed
        return new DiceRollResult
        {
            FirstRoll = first,
            Reroll = null
        };
    }

    public static int RollDie(int sides)
    {
        return _random.Next(1, sides + 1);
    }


    public class DiceRollResult
    {
        public int FirstRoll { get; set; }
        public int? Reroll { get; set; }

        public int Total => Reroll.HasValue ? Reroll.Value : FirstRoll;

        public override string ToString()
        {
            return Reroll.HasValue
                ? $"Rolled {FirstRoll} → rerolled to {Reroll.Value}"
                : $"Rolled {FirstRoll}";
        }
    }
}

