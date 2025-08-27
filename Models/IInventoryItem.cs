using WHQCore.Models.Enums;

namespace WHQCore.Models
{
    public interface IInventoryItem
    {
        string Name { get; }
        string Description { get; }
        HashSet<InventorySlot> Slot { get; }
        string ImagePath { get; }
    }
}
