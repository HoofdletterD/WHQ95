namespace WHQApp.Models;

public class Skill
{
    public Skill(
        string name,
        string shortDescription,
        string flavor,
        string longDescription,
        string value,
        List<string>? categories = null,
        string? imagePath = null)
    {
        Name = name;
        ShortDescription = shortDescription;
        Flavor = flavor;
        LongDescription = longDescription;
        Value = value;
        if (categories != null)
            Categories = categories;
        ImagePath = imagePath;
    }

    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Flavor { get; set; }
    public string LongDescription { get; set; }
    public string Value { get; set; }

    // Optional categories/tags for filtering in UI
    public List<string> Categories { get; set; } = [];

    // Optional image path or URL for UI
    public string? ImagePath { get; set; }

    public string DisplayFullSkill()
    {
        var displayName = $"**{Name}**" + (!string.IsNullOrWhiteSpace(Value) ? $" ({Value})" : "");

        return $"{displayName}\n" +
               $"_{Flavor}_\n" +
               $"{ShortDescription}\n\n" +
               $"{LongDescription}";
    }
}