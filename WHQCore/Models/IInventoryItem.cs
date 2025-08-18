using WHQCore.Models.Enums;
using System.Collections.Generic;

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
