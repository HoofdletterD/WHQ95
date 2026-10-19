using WHQCore.Models.Enums;

namespace WHQCore.Libraries.DungeonCards;

public static class DungeonCards
{
    public static IReadOnlyList<DungeonCard> All => new List<DungeonCard>
    {
        new()
        {
            Name = "Circle of Power",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "Shards of flickering, unnatural green light pierce the darkness from within this room.",
            Rules = "The Circle of Power will always trigger an Event Card, unless the Adventur Book states otherwise."
        },

        new()
        {
            Name = "Corner",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.Corridor,
            Quantity = 1,
            Size = "6x2",
            TileCount = 12,
            AdditionalDoors = 1,
            Lore = "The corridor suddenly and sharply twists into the darkness.",
            Rules = "The Corner will always be empty unless the Adventure Book states otherwise, or an Unexpected Event is rolled during the power phase."
        },

        new()
        {
            Name = "Dungeon Cell",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "What little light penetrates this room seems to be absorbed by its deep blue floor.",
            Rules = "The Dungeon Cell will always trigger an Event Card, unless the Adventur Book states otherwise."
        },

        new()
        {
            Name = "Fighting Pit",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x4",
            TileCount = 32,
            AdditionalDoors = 0,
            Lore = "The dim light of a single lamp suspended from the ceiling barely penetrates the shadows of this dark and forbidding room.",
            Rules = "See the Adventure Book for details of the Fighting Pit"
        },

        new()
        {
            Name = "Firechasm",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x4",
            TileCount = 32,
            AdditionalDoors = 0,
            Lore = "A deep red light seeps out from this room, suffusing the area with a burning glow. The air is almost too hot to breathe and the walls are warm to the touch.",
            Rules = "See the Adventure Book for details of the Firechasm."
        },

        new()
        {
            Name = "Fountain of Light",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x4",
            TileCount = 32,
            AdditionalDoors = 0,
            Lore = "A faint yellow glow emanates from this room, and you can just hear the trickle of running water.",
            Rules = "See the Adventure Book for details of the Fountain of Light."
        },

        new()
        {
            Name = "Guard Room",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "The dim light of your lantern illuminates what appears to be a floor covered in a checkerboard pattern.",
            Rules = "The Guard Room will always trigger an Event Card, unless the Adventure Book states otherwise."
        },

        new()
        {
            Name = "Idol Chamber",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x4",
            TileCount = 32,
            AdditionalDoors = 0,
            Lore = "The wan light of your lantern glints off the cold stone walls of this chamber, revealing a hideous stone idol at the far end of the room.",
            Rules = "See the Adventure Book for details of the Idol Chamber."
        },

        new()
        {
            Name = "Monsters' Lair",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "As your peer into the gloom, the lantern's light glints off what seems to be bones.",
            Rules = "The Monsters' Room will always trigger an Event Card, unless the Adventure Book states otherwise."
        },

        new()
        {
            Name = "Passageway",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.Corridor,
            Quantity = 7,
            Size = "6x2",
            TileCount = 12,
            AdditionalDoors = 1,
            Lore = "You are standing just inside a dank, dark expanse of corridor that disappears into the gloom.",
            Rules = "The Passageway will always be empty unless the Adventure Book states otherwise, or an Unexpected Event is rolled during the power phase."
        },

        new()
        {
            Name = "Stairway",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.Corridor,
            Quantity = 1,
            Size = "6x2",
            TileCount = 12,
            AdditionalDoors = 1,
            Lore = "You almost stumble and fall down a set of slimy stone steps that descend into the darkness.",
            Rules = "The Stairway will always be empty unless the Adventure Book states otherwise, or an Unexpected Event is rolled during the power phase."
        },

        new()
        {
            Name = "T-Junction",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.Corridor,
            Quantity = 3,
            Size = "6x4",
            TileCount = 16,
            AdditionalDoors = 2,
            Lore = "The passage divides into two here, leaving you with no idea as to which direction to take.",
            Rules = "The T-Junction will always be empty unless the Adventure Book states otherwise, or an Unexpected Event is rolled during the power phase. When the warriors find this room, split the dungeon deck between the two exits."
        },

        new()
        {
            Name = "Tomb Chamber",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x4",
            TileCount = 32,
            AdditionalDoors = 0,
            Lore = "A chill breeze blows from the room. In the flickering light, you can make out the shape of a stone slab inside.",
            Rules = "See the Adventure Book for details of the Tomb Chamber."
        },

        new()
        {
            Name = "Torture Chamber",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "By the flickering light of your lantern, you can just make out a small rough-hewn room.",
            Rules = "The Torture Chamber will always trigger an Event Card, unless the Adventure Book states otherwise."
        },

        new()
        {
            Name = "Well of Doom",
            Set = ExpansionSet.CoreGame,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "The stench of decay hangs heavy in the air, emanating from a bottomless shaft in the center of the room.",
            Rules = "The Well of Doom will always trigger an Event Card, unless the Adventure Book states otherwise."
        },

        new()
        {
            Name = "Chasm of Despair",
            Set = ExpansionSet.CatacombsOfTerror,
            CardType = DungeonCardType.Corridor,
            Quantity = 1,
            Size = "6x2",
            TileCount = 12,
            AdditionalDoors = 1,
            Lore = "This narrow bridge crosses a deep chasm.",
            Rules = "Any warrior or monster that rolls a natural 1 to hit in hand-to-hand combat will lose their balance and fall to their death in the chasm below."
        },

        new()
        {
            Name = "Hall of Death",
            Set = ExpansionSet.CatacombsOfTerror,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "5x4",
            TileCount = 14,
            AdditionalDoors = 3,
            Lore = "This bone-filled room reeks of terror, decay and death.",
            Rules = "When the warriors find this room, split the rest of the dungeon deck between the three exits, just as for a T-junction."
        },

        new()
        {
            Name = "Dread King's Throne Room",
            Set = ExpansionSet.CatacombsOfTerror,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "5x8",
            TileCount = 36,
            AdditionalDoors = 0,
            Lore = "This massive chamber is the royal hall of the Liche King himself.",
            Rules = "See the Catacombs of Terror rules book for details."
        },

        new()
        {
            Name = "Shaman's Den",
            Set = ExpansionSet.LairOfTheOrcLord,
            CardType = DungeonCardType.DungeonRoom,
            Quantity = 1,
            Size = "4x4",
            TileCount = 16,
            AdditionalDoors = 1,
            Lore = "The warriors can feel the magical power in this room.",
            Rules = "See Lair of the Orc Lord page 12 for complete rules."
        },

        new()
        {
            Name = "Gorgut's Lair",
            Set = ExpansionSet.LairOfTheOrcLord,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x5",
            TileCount = 36,
            AdditionalDoors = 0,
            Lore = "This huge room has an air of menace.",
            Rules = "See the Lair of the Orc Lord rulebook for details on Gorgut's Lair."
        },

        new()
        {
            Name = "Collapsed Passage",
            Set = ExpansionSet.WD192,
            CardType = DungeonCardType.Corridor,
            Quantity = 1,
            Size = "6x2",
            TileCount = 8,
            AdditionalDoors = 1,
            Lore = "The walls of this passage have fallen in.",
            Rules = "This passage way will be empty unless an Unexpected Event is rolled during the power phase."
        },

        new()
        {
            Name = "Into the Dark",
            Set = ExpansionSet.WD192,
            CardType = DungeonCardType.Special,
            Quantity = 1,
            Size = "2x2",
            TileCount = 4,
            AdditionalDoors = 1,
            Lore = "A set of ancient stairs descend into the depths of the dungeon.",
            Rules = "See White Dwarf 192 for complete Into the Dark rules."
        },

        new()
        {
            Name = "Dead End",
            Set = ExpansionSet.WD192,
            CardType = DungeonCardType.Corridor,
            Quantity = 1,
            Size = "3x2",
            TileCount = 6,
            AdditionalDoors = 0,
            Lore = "A rockfall blocks the tunnel ahead.",
            Rules = "See White Dwarf 192 for complete Dead End rules."
        },

        new()
        {
            Name = "The Gaol",
            Set = ExpansionSet.WD185,
            CardType = DungeonCardType.Special,
            Quantity = 1,
            Size = "2x2",
            TileCount = 4,
            AdditionalDoors = 0,
            Lore = "This tiny cell is dark and damp and smells of rotten flesh.",
            Rules = "See White Dwarf 185 for details of the Gaol."
        },

        new()
        {
            Name = "Quirrik's Laboratory",
            Set = ExpansionSet.WD195,
            CardType = DungeonCardType.ObjectiveRoom,
            Quantity = 1,
            Size = "8x4",
            TileCount = 32,
            AdditionalDoors = 0,
            Lore = "The stench of burning warpstone fills the air.",
            Rules = "See White Dwarf 195 for details of Quirrik's Laboratory."
        },

        new()
        {
            Name = "Sewer",
            Set = ExpansionSet.WD204,
            CardType = DungeonCardType.Special,
            Quantity = 1,
            Size = "6x3",
            TileCount = 18,
            AdditionalDoors = 1,
            Lore = "The rancid stench of noxious vapours assails the Warriors' nostrils.",
            Rules = "See White Dwarf 204 for complete Sewer rules."
        },

        new()
        {
            Name = "Flames of Khazla",
            Set = ExpansionSet.WD186,
            CardType = DungeonCardType.Corridor,
            Quantity = 1,
            Size = "2x2",
            TileCount = 4,
            AdditionalDoors = 1,
            Lore = "Nestled in the corner ahead is a small shrine of multi-coloured flames.",
            Rules = "See White Dwarf 186 for complete Flames of Khazla rules."
        }
    };
}
