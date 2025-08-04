namespace WHQCore.Models;

public class Equipment(
    string name,
    string effect,
    string description,
    List<string> categories,
    string imagePath,
    Dictionary<string, int>? statModifiers = null)
{
    public string Name { get; } = name;
    public string Effect { get; } = effect;
    public string Description { get; } = description;
    public List<string> Categories { get; } = categories;
    public string ImagePath { get; } = imagePath;

    public Dictionary<string, int> StatModifiers { get; } = statModifiers ?? new Dictionary<string, int>();
    public override string ToString()
    {
        return string.IsNullOrWhiteSpace(Effect)
            ? Name
            : $"{Name} ({Effect})";
    }
}