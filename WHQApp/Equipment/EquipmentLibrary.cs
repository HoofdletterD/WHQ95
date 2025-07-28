namespace WHQApp.Equipment;

public static class EquipmentLibrary
{
    public static Models.Equipment ThickFurs => new(
        "Thick Furs",
        "Gives +1 Toughness",
        "Used to keep the coldness at bay somewhat, but also surprisingly effective against enemy attacks.",
        categories: ["Starting Equipment", "Barbarian", "Armour"],
        imagePath: "images/equipment/ThickFurs.png",
        statModifiers: new Dictionary<string, int>
        {
            { "Toughness", 1 }
        }
    );

    public static Models.Equipment Sword => new(
        "Sword",
        "1D6 + Strength damage",
        "A t(h)rust worthy armament, suitable for almost all warriors.",
        categories: ["Starting Equipment", "Weapon"],
        imagePath: "images/equipment/ThickFurs.png"
    );

    public static Models.Equipment Lantern => new(
        "Sword",
        "Illuminates the board sections",
        "The lantarn illuminates the board section this hero is on, and all adjacent board sections. If a warrior strays too far away from the light they can get lost.",
        categories: ["Starting Equipment", "Lantarn"],
        imagePath: "images/equipment/Lantarn.png"
    );
}