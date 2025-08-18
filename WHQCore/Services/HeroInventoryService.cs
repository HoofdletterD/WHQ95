using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Services
{
    public static class HeroInventoryService
    {
        /// <summary>
        /// Checks if the hero can equip this item based on its InventorySlots.
        /// Returns true if all required slots are free.
        /// </summary>
        public static bool CanEquip(IHero hero, IInventoryItem item)
        {
            foreach (var slot in item.Slots)
            {
                if (IsSlotOccupied(hero, slot))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Equips an item to the hero if the slots are free.
        /// Returns true if equipped successfully, false otherwise.
        /// </summary>
        public static bool Equip(IHero hero, IInventoryItem item)
        {
            if (!CanEquip(hero, item))
                return false;

            switch (item)
            {
                case EquipmentData eq:
                    hero.Character.Equipment.Add(eq);
                    break;

                case MagicItemData mi:
                    hero.Character.MagicItems.Add(mi);
                    break;
            }

            return true;
        }

        /// <summary>
        /// Unequips an item from the hero, freeing its slots.
        /// </summary>
        public static void Unequip(IHero hero, IInventoryItem item)
        {
            switch (item)
            {
                case EquipmentData eq:
                    hero.Character.Equipment.Remove(eq);
                    break;

                case MagicItemData mi:
                    hero.Character.MagicItems.Remove(mi);
                    break;
            }
        }

        /// <summary>
        /// Returns true if a hero already has an item occupying this slot.
        /// </summary>
        private static bool IsSlotOccupied(IHero hero, InventorySlot slot)
        {
            return hero.Character.Equipment.Any(e => e.Slot.Contains(slot)) ||
                   hero.Character.MagicItems.Any(m => m.Slots.Contains(slot));
        }
    }

    /// <summary>
    /// Shared interface to unify EquipmentData and MagicItemData for inventory operations.
    /// </summary>
    public interface IInventoryItem
    {
        public HashSet<InventorySlot> Slots { get; }
    }
}
