//TODO: ADD IMPORTS

public record MonsterEvent(
    int D66,
    string RaceAndType,
    string M,
    string WS,
    string BS,
    string S,
    string T,
    string W,
    string I,
    string A,
    string Gold,
    string Armour,
    string Damage,
    string Number,
    string SpecialRules);

public static class MonsterEventTableLevel1
{
    public static readonly IReadOnlyDictionary<int, MonsterEvent[]> Events =
        new Dictionary<int, MonsterEvent[]>
        {
            [11] = new[]
            {
                new MonsterEvent(
                    11, "Roll on Level 2 Monster Table",
                    "", "", "", "", "", "", "", "",
                    "", "", "", "",
                    "")
            },

            [12] = new[]
            {
                new MonsterEvent(
                    12, "Ogres",
                    "6","3","5+","4","5","13","3","2",
                    "400","-","1","1D3",
                    "Fear 5")
            },

            [13] = new[]
            {
                new MonsterEvent(
                    13, "Beastmen",
                    "4","4","4+","3","4","6","3","1",
                    "100","-","1","1D6+2",
                    "Throw Spears (Str 3)")
            },

            [14] = new[]
            {
                new MonsterEvent(
                    14, "Skaven Stormvermin",
                    "5","4","4+","4","3","5","5","1",
                    "95","-","1","1D6+3",
                    "")
            },

            [15] = new[]
            {
                new MonsterEvent(
                    15, "Snotlings",
                    "4","1","-","1","1","1","1","1",
                    "10","-","S","1D6+6",
                    "Ambush; Magic A; Gang Up")
            },

            [16] = new[]
            {
                new MonsterEvent(
                    16, "Giant Bats",
                    "8","2","-","2","2","1","-","1",
                    "15","-","1","1D6+6",
                    "Ambush A; Fly")
            },

            [21] = new[]
            {
                new MonsterEvent(
                    21, "Giant Spiders",
                    "6","2","-","5","2","1","-","1",
                    "15","-","1","2D6",
                    "Web (1D3)")
            },

            [22] = new[]
            {
                new MonsterEvent(
                    22, "Giant Rats",
                    "6","2","-","3","3","1","4","1",
                    "25","-","5","2D6",
                    "Deathleap")
            },

            [23] = new[]
            {
                new MonsterEvent(
                    23, "Orcs",
                    "4","3","4+","3","4","3","2","1",
                    "55","-","1","2D6",
                    "Armed with [1-3] Bows (Str 3) or [4-6] Swords")
            },

            [24] = new[]
            {
                new MonsterEvent(
                    24, "Skaven Clanrats",
                    "5","3","4+","3","3","3","4","1",
                    "40","-","1","2D6",
                    "")
            },

            [25] = new[]
            {
                new MonsterEvent(
                    25, "Savage Orcs",
                    "4","3","4+","3","4","5","2","1",
                    "65","S*","1","1D6",
                    "Armed with Bows (Str 3); Tattoos 6+"),

                new MonsterEvent(
                    25, "Savage Orc Shaman",
                    "4","3","4+","3","5","16","3","1",
                    "590","S*","1","1",
                    "Orc Magic 1; Magic Resistance 6+; Magic Weapon; Tattoos 5+")
            },

            [26] = new[]
            {
                new MonsterEvent(
                    26, "Goblin Netters",
                    "4","2","5+","3","3","2","2","1",
                    "35","-","S","1D6",
                    "Armed with Nets")
            },

            [31] = new[]
            {
                new MonsterEvent(
                    31, "Skeletons",
                    "4","2","5+","3","3","5","2","1",
                    "80","-","1","2D6",
                    "Bows or Swords; Fear 5; Regenerate 1")
            },

            [32] = new[]
            {
                new MonsterEvent(
                    32, "Zombies",
                    "4","2","-","3","3","5","1","1",
                    "40","-","1","1D6",
                    "Fear 3")
            },

            [33] = new[]
            {
                new MonsterEvent(
                    33, "Ghouls",
                    "4","2","-","3","4","4","3","2",
                    "80","-","1","2D6",
                    "Break; Fear 4")
            },

            [34] = new[]
            {
                new MonsterEvent(
                    34, "Dark Elves",
                    "5","4","3+","3","3","6","6","1",
                    "100","1","1","1D6+3",
                    "Crossbows (Str 4); Dodge 6+; Hate Elves")
            },

            [35] = new[]
            {
                new MonsterEvent(
                    35, "Giant Spiders",
                    "6","2","-","5","2","1","-","1",
                    "15","-","1","2D6",
                    "Web (1D3)")
            },

            [36] = new[]
            {
                new MonsterEvent(
                    36, "Wild Cave Squigs",
                    "S","4","-","5","3","3","5","2",
                    "200","-","1","1D3",
                    "Never Pinned; Wild Squig Attack"),

                new MonsterEvent(
                    36, "Trained Cave Squigs",
                    "S","4","-","5","3","3","5","2",
                    "200","-","1","1D3",
                    "Never Pinned"),

                new MonsterEvent(
                    36, "Goblin Squig Hunters",
                    "4","2","5+","3","3","2","2","1",
                    "25","-","1","Special",
                    "Herd Squigs")
            },

            [41] = Events[15],

            [42] = Events[16],

            [43] = new[]
            {
                new MonsterEvent(
                    43,"Hobgoblins",
                    "4","3","4+","3","3","4","2","1",
                    "50","1","1","1D6+3",
                    "Ambush; Magic A; Break")
            },

            [44] = new[]
            {
                new MonsterEvent(
                    44,"Goblins",
                    "4","2","5+","3","3","2","2","1",
                    "20","-","1","1D6+6",
                    "Bows (Str 1) or Spears (Fight in Ranks)"),

                new MonsterEvent(
                    44,"Goblin Shaman",
                    "4","2","5+","3","4","3","3","1",
                    "280","-","1","1",
                    "Goblin Magic 1; Magic Resistance 5+ (Ring)")
            },

            [45] = new[]
            {
                new MonsterEvent(
                    45,"Minotaurs",
                    "6","4","4+","4","4","15","3","2",
                    "440","-","2","1D3",
                    "Fear")
            },

            [46] = Events[23],

            [51] = Events[15],

            [52] = Events[16],

            [53] = Events[21],

            [54] = Events[22],

            [55] = Events[24],

            [56] = Events[31],

            [61] = new[]
            {
                new MonsterEvent(
                    61,"Goblins",
                    "4","2","5+","3","3","2","2","1",
                    "20","-","1","1D6+6",
                    "Bows (Str 1) or Spears (Fight in Ranks)")
            },

            [62] = Events[43],

            [63] = new[]
            {
                new MonsterEvent(
                    63,
                    "Dark Elf Naggaroth Black Guards",
                    "5","5","3+","4","3","6","7","1",
                    "150","2","1","1D6+2",
                    "Halberds; Fight in Ranks; Hate Elves")
            },

            [64] = new[]
            {
                new MonsterEvent(
                    64,
                    "Centaurs",
                    "8","3","3+","4","3","12","3","2",
                    "300","-","2","1D3",
                    "Bows (Str 4); Fear 4")
            },

            [65] = new[]
            {
                new MonsterEvent(
                    65,
                    "Minotaurs",
                    "6","4","4+","4","4","15","3","2",
                    "440","-","2","1D3",
                    "Fear 5")
            },

            [66] = new[]
            {
                new MonsterEvent(
                    66, "Roll on Level 2 Monster Table",
                    "", "", "", "", "", "", "", "",
                    "", "", "", "",
                    "")
            }
        };
}
