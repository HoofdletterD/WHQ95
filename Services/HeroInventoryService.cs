using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Services
{
    public static class HeroInventoryService
    {
        // Display full inventory: equipped items by slot and backpack items
        public static void DisplayInventory(IHero heroBase)
        {
            var hero = heroBase.Character;

            Console.WriteLine($"\n--- {hero.Name}'s Inventory ---");

            var slots = Enum.GetValues<InventorySlot>().Cast<InventorySlot>();

            // --- Equipped Items ---
            Console.WriteLine("\nEquipped Items:");
            foreach (var slot in slots)
            {
                hero.EquippedItems.TryGetValue(slot, out var equipped);
                Console.WriteLine($"{slot}: {(equipped != null ? equipped.Name : "(empty)")}");
            }

            // --- Backpack Items ---
            Console.WriteLine("\nBackpack Items:");
            var backpack = GetBackpack(hero);

            if (!backpack.Any())
            {
                Console.WriteLine("No items in backpack.");
            }
            else
            {
                int index = 1;
                foreach (var item in backpack)
                    Console.WriteLine($"{index++}. {item.Name}");
            }
        }

        // Add item to hero's inventory (pouch/backpack)
        public static void AddToInventory(Hero hero, IInventoryItem item)
        {
            hero.Inventory.Add(item);
        }

        // Equip an item from inventory/backpack
        public static void TryEquipItem(Hero hero, IInventoryItem item)
        {
            if (item.Slot.Contains(InventorySlot.Pouch))
            {
                Console.Write($"Use {item.Name}? (y/n): ");
                var key = Console.ReadKey(true).Key;
                Console.WriteLine();
                if (key == ConsoleKey.Y)
                {
                    Console.WriteLine($"{item.Name} used!");
                    hero.Inventory.Remove(item);
                }
                return;
            }

            if (!ItemCanBeUsedByHero(hero, item))
            {
                Console.WriteLine($"{item.Name} cannot be equipped by this hero.");
                return;
            }

            // === Handle Two-Handed Equip ===
            if (item.Slot.Contains(InventorySlot.TwoHanded))
            {
                // If something is in main/offhand, unequip them
                if (hero.EquippedItems.TryGetValue(InventorySlot.MainHand, out var mh) && mh != null)
                {
                    Console.WriteLine($"\nEquipping {item.Name} will replace: {mh.Name}");
                    hero.Inventory.Add(mh);
                    RemoveFromEquipped(hero, mh);
                }
                if (hero.EquippedItems.TryGetValue(InventorySlot.OffHand, out var oh) && oh != null)
                {
                    Console.WriteLine($"\nEquipping {item.Name} will replace: {oh.Name}");
                    hero.Inventory.Add(oh);
                    RemoveFromEquipped(hero, oh);
                }
            }

            // === Handle MainHand / OffHand Equip ===
            if (item.Slot.Contains(InventorySlot.MainHand) || item.Slot.Contains(InventorySlot.OffHand))
            {
                // If a two-handed is equipped, unequip it
                if (hero.EquippedItems.TryGetValue(InventorySlot.TwoHanded, out var twoHanded) && twoHanded != null)
                {
                    Console.WriteLine($"\nEquipping {item.Name} will replace: {twoHanded.Name}");
                    MoveItemToInventory(hero, twoHanded);
                    RemoveFromEquipped(hero, twoHanded);
                }
            }

            // === Handle Slot Conflicts Normally ===
            foreach (var slot in item.Slot)
            {
                if (hero.EquippedItems.TryGetValue(slot, out var currentlyEquipped) && currentlyEquipped != null)
                {
                    Console.WriteLine($"\nEquipping {item.Name} will replace: {currentlyEquipped.Name}");
                    Console.Write("Do you want to continue? (y/n): ");
                    var key = Console.ReadKey(true).Key;
                    Console.WriteLine();
                    if (key != ConsoleKey.Y)
                        return;

                    hero.Inventory.Add(currentlyEquipped);
                    RemoveFromEquipped(hero, currentlyEquipped);
                }

                hero.EquippedItems[slot] = item;
            }

            // Remove from backpack if it was there
            hero.Inventory.Remove(item);

            // Ensure it's also in Equipment/MagicItems
            if (item is EquipmentData eq && !hero.Equipment.Contains(eq))
                hero.Equipment.Add(eq);
            else if (item is MagicItemData mi && !hero.MagicItems.Contains(mi))
                hero.MagicItems.Add(mi);

            Console.WriteLine($"{item.Name} equipped.");
        }


        // NEW: Unequip an item and move it back to the backpack
        public static void UnequipItem(Hero hero, IInventoryItem item)
        {
            if (item == null)
                return;

            // Remove from equipped slots
            RemoveFromEquipped(hero, item);

            // Put back into backpack
            if (!hero.Inventory.Contains(item))
                hero.Inventory.Add(item);

            Console.WriteLine($"{item.Name} unequipped and moved to backpack.");
        }

        // Interactive menu
        public static void ManageInventoryMenu(IHero heroBase)
        {
            var hero = heroBase.Character;

            while (true)
            {
                Console.Clear();
                DisplayInventory(heroBase);

                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Equip/Use item from backpack");
                Console.WriteLine("2. Unequip item");
                Console.WriteLine("0. Exit");

                Console.Write("\n> ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageBackpackMenu(hero);
                        break;
                    case "2":
                        ManageUnequipMenu(hero);
                        break;
                    case "0":
                        return;
                }
            }
        }

        private static void ManageBackpackMenu(Hero hero)
        {
            var backpack = GetBackpack(hero);
            if (!backpack.Any())
            {
                Console.WriteLine("\nNo items to equip or use. Press any key...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nSelect an item to equip or use (0 to cancel):");
            for (int i = 0; i < backpack.Count; i++)
                Console.WriteLine($"{i + 1}. {backpack[i].Name}");

            Console.Write("> ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int choice) || choice < 0 || choice > backpack.Count)
                return;
            if (choice == 0) return;

            var selectedItem = backpack[choice - 1];
            TryEquipItem(hero, selectedItem);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        private static void ManageUnequipMenu(Hero hero)
        {
            var equipped = hero.EquippedItems.Values.Where(i => i != null).ToList();
            if (!equipped.Any())
            {
                Console.WriteLine("\nNo items equipped. Press any key...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nSelect an item to unequip (0 to cancel):");
            for (int i = 0; i < equipped.Count; i++)
                Console.WriteLine($"{i + 1}. {equipped[i].Name}");

            Console.Write("> ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int choice) || choice < 0 || choice > equipped.Count)
                return;
            if (choice == 0) return;

            var selectedItem = equipped[choice - 1];
            UnequipItem(hero, selectedItem);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Get all backpack items (unequipped equipment/magic items + hero.Inventory)
        private static List<IInventoryItem> GetBackpack(Hero hero)
        {
            var equipped = hero.EquippedItems.Values.Where(v => v != null);
            var unequipped = hero.Equipment.Concat<IInventoryItem>(hero.MagicItems)
                                .Except(equipped);
            return unequipped.Concat(hero.Inventory).ToList();
        }

        private static void RemoveFromEquipped(Hero hero, IInventoryItem item)
        {
            var keysToRemove = hero.EquippedItems
                                    .Where(kv => kv.Value == item)
                                    .Select(kv => kv.Key)
                                    .ToList();
            foreach (var key in keysToRemove)
                hero.EquippedItems[key] = null;
        }

        private static bool ItemCanBeUsedByHero(Hero hero, IInventoryItem item)
        {
            return item switch
            {
                EquipmentData eq => eq.Warriors.Contains(hero.HeroCode) || eq.Warriors.Contains(HeroCode.All),
                MagicItemData mi => mi.Warriors.Contains(hero.HeroCode) || mi.Warriors.Contains(HeroCode.All),
                _ => false
            };
        }

        private static void MoveItemToInventory(Hero hero, IInventoryItem item)
        {
            if (!hero.Inventory.Contains(item))
                hero.Inventory.Add(item);

            if (item is EquipmentData eq && hero.Equipment.Contains(eq))
                hero.Equipment.Remove(eq);
            else if (item is MagicItemData mi && hero.MagicItems.Contains(mi))
                hero.MagicItems.Remove(mi);
        }
    }
}
