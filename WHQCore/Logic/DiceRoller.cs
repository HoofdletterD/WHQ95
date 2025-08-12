namespace WHQCore.Logic;

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

    public static class SpellDiceCombiner
    {
        public static List<List<int>> GenerateAllCastingCombinations(List<int> dice)
        {
            var results = new List<List<int>>();
            Generate(dice, new List<int>(), results);
            return results;
        }

        private static void Generate(List<int> remaining, List<int> current, List<List<int>> results)
        {
            if (remaining.Count == 0)
            {
                results.Add(new List<int>(current));
                return;
            }

            for (var i = 1; i <= remaining.Count; i++)
            {
                var subset = remaining.Take(i).ToList();
                var sum = subset.Sum();

                var rest = remaining.Skip(i).ToList();

                var next = new List<int>(current) { sum };

                Generate(rest, next, results);
            }
        }
    }

    public static List<int> GetPossibleCastingNumbers(List<int> dice)
    {
        var results = new HashSet<int>();

        var n = dice.Count;
        for (var mask = 1; mask < (1 << n); mask++)
        {
            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                if ((mask & (1 << i)) != 0)
                    sum += dice[i];
            }
            results.Add(sum);
        }

        return results.ToList();
    }

    public static bool RemoveDiceForCastingNumber(List<int> dice, int target)
    {
        var n = dice.Count;

        // Try all subsets to find one that sums to target
        for (var mask = 1; mask < (1 << n); mask++)
        {
            var sum = 0;
            var indices = new List<int>();
            for (var i = 0; i < n; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    sum += dice[i];
                    indices.Add(i);
                }
            }

            if (sum == target)
            {
                // Remove dice starting from highest index so removal doesn't shift earlier ones
                foreach (var idx in indices.OrderByDescending(x => x))
                {
                    dice.RemoveAt(idx);
                }
                return true;
            }
        }

        return false; // No combination found
    }
}

