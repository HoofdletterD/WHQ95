namespace WHQCore.Adventures;

public enum EventGenerationMode
{
    // Adventures may use either Cards to draw, or Tables to populate the dungeon from.
    // Tables are considered to be 'harder' and requires a larger collection of models.
    Cards,
    Tables
}