public class EventCard
{
    public string EventType { get; init; } = string.Empty;
    public string CardName { get; init; } = string.Empty;
    public string Set { get; init; } = string.Empty;
    public string Quantity { get; init; } = string.Empty;
    public string ApplicableRace { get; init; } = string.Empty;
    public string? SpecialRules { get; init; }
    public bool DrawAnotherEventCard { get; init; }
    public bool TreasureCard { get; init; }
    public string? MonsterProfileId { get; init; }
}

public static class CoreCards
{
    public static readonly List<EventCard> Cards =
    [
        new()
        {
            EventType = "Monster",
            CardName = "Minotaur",
            Set = "Core",
            Quantity = "1",
            ApplicableRace = "Beastmen",
            DrawAnotherEventCard = true,
            TreasureCard = true
        },

        new()
        {
            EventType = "Monster",
            CardName = "Minotaur",
            Set = "Core",
            Quantity = "D3",
            ApplicableRace = "Beastmen",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },

        new()
        {
            EventType = "Monster",
            CardName = "Giant Bats",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Vampire Counts",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Giant Rats",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Skaven",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Giant Spider",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Goblin Archer",
            Set = "Core",
            Quantity = "1D6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Goblins",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            SpecialRules = "Place 1D6 goblin spearmen and 1D6 goblin archers.",
            DrawAnotherEventCard = true,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Goblin Spearmen",
            Set = "Core",
            Quantity = "6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Orcs",
            Set = "Core",
            Quantity = "6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Orcs",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            SpecialRules = "Place 1D6 Orc warriors and 1D6 Orc archers.",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Skaven Warriors",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Skaven",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
            EventType = "Monster",
            CardName = "Snotlings",
            Set = "Core",
            Quantity = "2D6",
            ApplicableRace = "Orcs & Goblins",
            DrawAnotherEventCard = false,
            TreasureCard = true
        },
        new()
        {
        EventType = "Encounter",
        CardName = "Cave-in",
        Set = "Core",
        Quantity = "n/a",
        ApplicableRace = "n/a",
        SpecialRules =
            "Place the cave-in marker in the board section where this card was triggered to show that all exits except the one the warriors entered by are now blocked. Any warriors still in this board section at the end of the next turn are crushed by rubble and killed. Any monsters in the room are crushed by falling masonry. Warriors attempting to escape are not subject to pinning rules whilst in this room. The room is now impassible and may not be re-entered. If this card is drawn in the first room in the dungeon, ignore it and draw another event card immediately.",
        DrawAnotherEventCard = true,
        TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Dead Body",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "Before the warriors lies a dead barbarian, lying in a pool of blood. Clutched tightly to his chest is a bag. Roll 1D6 for each warrior. The warrior with the lowest score must take the bag. Roll 1D6 on the following table to see what happens when he does. 1: Poison Gas! Every model on this board section takes 1D6 wounds with no modifiers for toughness or armour. 2-3: Trap! A spear shoots out of the wall and inflicts 2D6 wounds on the warrior who took the bag. The bag turns out to be empty. 4-6: The bag contains 1D6 x 100 gold, to be given to the warrior who took it.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Key",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "Slumped against the wall the warriors find a dying Dwarf prospector, riddled with Orc arrows. As they approach, he growls a warning, threatening them with a huge axe. When he sees that they are not Orcs or evil creatures, he calms down and gives them a key. With his dying breath he says: 'This is the key to the portcullis. Without it, you will never get through'. One of the players should keep this card to remind you that this warrior has the key.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Falling Block",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "A huge block of stone falls down from the ceiling onto one of the warriors. Randomize a warrior to determine who set off the trap. The unlucky warrior must roll a D6 and add his Initiative. If the total score is 7+, the warrior nimbly avoids the stone. On a score of 6 or less, the warrior is hit and loses 2D6 wounds. Remember, a 1 is always a failure. Whether the warrior was hit or not, move the model to an adjacent square and place the Fallen Block counter in the original square. The square is now 'blocked' and can no longer be moved through.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Old Bones",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "The floor of this room is littered with bones and skulls, with a glint of gold underneath. As the warriors collect the gold, roll 1D6. 1: Trap! Crackling laughter echoes around the room and lightning flashes. Randomize a warrior to determine which warrior is hit by a magical bolt that inflicts 1D6 wounds with no modifiers for toughness or armour. 2-3: Illusion! In a bright flash of light, the bones and gold vanish. Draw another event card immediately. 4-5: Each warrior on this board section finds (1D6 x 10) gold. Draw another event card immediately. 6: Each warrior on this board section finds (2D6 x 10) gold. In addition, draw one treasure card.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Portcullis",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "Once all warriors have entered this board section, a portcullis slams shut behind them, cutting them off. They can only retrace their steps if they have a key. Place the portcullis marker across the doorway the warriors entered by to show that it is blocked.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Scorpions",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "A scorpion swarm is a special form of monster and its attack is resolved immediately. Randomly determine which warrior is attacked by the swarm. There are 12 scorpions in the swarm, but they are very small and are not represented by miniatures on the board. Roll your warrior's normal damage dice to see how many scorpions he kills with his attack - the number rolled is the number of scorpions he kills. Each scorpion killed is worth 5 gold. Any scorpions that are left inflict 1 wound each, with no modifiers for toughness or armour. The scorpion swarm then scuttles away and this card is discarded. After this event, roll a D6: on a 1, 2 or 3, draw another event card immediately.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        },

        new()
        {
            EventType = "Encounter",
            CardName = "Trap",
            Set = "Core",
            Quantity = "n/a",
            ApplicableRace = "n/a",
            SpecialRules =
                "Roll 1D6 for each warrior. The warrior with the lowest score has set off a trap. Roll 1D6 on the following table. 1: There is a loud explosion and the room is filled with fire and smoke. Every model on this board section takes 1D6 wounds with no modifiers for toughness or armour. 2-5: A pit opens in the floor and your warrior plummets onto the rocky floor below. He takes 2D6 wounds and can only escape if the party has the rope or a levitation spell. 6: A stone slab slides back in the wall, revealing the glint of gems and gold. Draw one treasure card. After resolving this event, roll a D6: on a 1, 2 or 3, draw another event card immediately.",
            DrawAnotherEventCard = true,
            TreasureCard = false
        }
    ];
}
