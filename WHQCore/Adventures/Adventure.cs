namespace WHQCore.Adventures;

public class Adventure
{
    /// <summary>
    /// Objective Room this adventure belongs to.
    /// </summary>
    public ObjectiveRoomType ObjectiveRoom { get; init; }

    /// <summary>
    /// The D6 result used to select this adventure.
    /// </summary>
    public int Roll { get; init; }

    /// <summary>
    /// Adventure title.
    /// Example: Clearwater.
    /// </summary>
    public string Title { get; init; } = string.Empty;

    /// <summary>
    /// Introduction and story text.
    /// </summary>
    public string Background { get; init; } = string.Empty;

    /// <summary>
    /// Special rules that apply during the adventure.
    /// </summary>
    public string SpecialRules { get; init; } = string.Empty;

    /// <summary>
    /// Instructions for resolving the objective room.
    /// Example: defeat monsters then pour the barrel into the fountain.
    /// </summary>
    public string ObjectiveRoomRules { get; init; } = string.Empty;

    /// <summary>
    /// Optional notes for future expansions,
    /// errata, White Dwarf content, etc.
    /// </summary>
    public string Notes { get; init; } = string.Empty;


    /// <summary>
    /// Checks the different options for an adventure: Cards or tables.
    /// </summary>
    public AdventureOptions Options { get; init; } = new();


    public override string ToString()
    {
        return $"{ObjectiveRoom} - {Roll}: {Title}";
    }


}