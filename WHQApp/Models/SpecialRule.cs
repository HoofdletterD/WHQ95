namespace WHQApp.Models;

public class SpecialRule
{
    public SpecialRule(
        string name,
        string shortDescription,
        string longDescription,
        int? value = null,
        List<string>? categories = null,
        string? imagePath = null)
    {
        Name = name;
        ShortDescription = shortDescription;
        LongDescription = longDescription;
        Value = value;
        if (categories != null)
            Categories = categories;
        ImagePath = imagePath;
    }

    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public int? Value { get; set; }

    // Optional categories/tags for filtering in UI
    public List<string> Categories { get; set; } = [];

    // Optional image path or URL for UI
    public string? ImagePath { get; set; }

    public override string ToString()
    {
        return Value.HasValue ? $"{Name} ({Value})" : Name;
    }
}