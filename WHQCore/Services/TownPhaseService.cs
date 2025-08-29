using WHQCore.Helpers;
using WHQCore.HeroManagement;
using WHQCore.Libraries.Equipment;
using WHQCore.Logic;
using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Services;

public static class TownPhaseService
{
    public static void RunTownPhase(IHero heroBase)
    {
        var hero = heroBase.Character;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n--- Town Phase ---");
            Console.WriteLine("1. Visit a Trader");
            Console.WriteLine("2. Sell Magic Items");
            Console.WriteLine("3. Level Up");
            Console.WriteLine("4. Visit Special Location");
            Console.WriteLine("5. Show Hero Stats");
            Console.WriteLine("6. Manage Inventory");
            Console.WriteLine("0. Leave Town");
            Console.Write("Choose an option: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    VisitTraderSession(heroBase);
                    break;
                case "2":
                    SellMagicItemsLoop(heroBase);
                    break;
                case "3":
                    AttemptLevelUp(heroBase);
                    break;
                case "4":
                    VisitSpecialLocation();
                    break;
                case "5":
                    HeroDisplayer.DisplayHeroAllInformation(heroBase);
                    break;
                case "6":
                    HeroInventoryService.ManageInventoryMenu(heroBase);
                    HeroSaveManager.SaveHero(heroBase);
                    break;
                case "0":
                    Console.WriteLine("Leaving town...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private static void VisitTraderSession(IHero hero)
    {
        var traders = Enum.GetValues<Trader>()
            .Where(t => t != Trader.NoTraderAvailable)
            .ToList();

        while (true)
        {
            Console.WriteLine("\nWhich trader do you want to visit?");
            for (int i = 0; i < traders.Count; i++)
                Console.WriteLine($"{i + 1}. {traders[i]}");
            Console.WriteLine("0. Leave Town");

            Console.Write("Enter choice (number): ");
            if (!int.TryParse(Console.ReadLine(), out int traderChoice))
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            if (traderChoice == 0)
                return; // leave trader session

            if (traderChoice < 1 || traderChoice > traders.Count)
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            var selectedTrader = traders[traderChoice - 1];
            VisitTraderLoop(hero, selectedTrader);
        }
    }

    private static void VisitTraderLoop(IHero hero, Trader selectedTrader)
    {
        while (true)
        {
            Console.WriteLine($"\n--- Visiting {selectedTrader} ---");
            Console.WriteLine("1. Buy Equipment");
            Console.WriteLine("2. Sell Magic Items");
            Console.WriteLine("0. Leave Trader");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BuyEquipment(hero, selectedTrader);
                    break;
                case "2":
                    SellMagicItemsLoop(hero);
                    break;
                case "0":
                    return; // exit trader
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private static void BuyEquipment(IHero hero, Trader selectedTrader)
    {
        var availableEquipment = EquipmentLibrary.GetAllEquipment()
            .Where(e => e.Trader.Contains(selectedTrader) &&
                        (e.Warriors.Contains(hero.Character.HeroCode) || e.Warriors.Contains(HeroCode.All)))
            .ToList();

        if (!availableEquipment.Any())
        {
            Console.WriteLine("No items available for you at this trader.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\nAvailable items:");
            for (int i = 0; i < availableEquipment.Count; i++)
            {
                var eq = availableEquipment[i];
                Console.WriteLine($"{i + 1}. {eq.Name} - Cost: {eq.CostBuy} gold, Stock: {eq.Stock}");
            }
            Console.WriteLine("0. Leave Buy Menu");

            Console.Write("Choose an item to buy (number): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > availableEquipment.Count)
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            if (choice == 0)
                return; // exit buy menu

            var selectedItem = availableEquipment[choice - 1];

            if (hero.Character.Equipment.Any(eq => eq.Name.Equals(selectedItem.Name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"You already own {selectedItem.Name}. Cannot equip it again.");
                continue;
            }

            if (hero.Character.Gold < selectedItem.CostBuy)
            {
                Console.WriteLine("Not enough gold!");
                continue;
            }

            var diceRoll = DiceRoller.Roll2D6();
            if (diceRoll < selectedItem.Stock)
            {
                Console.WriteLine($"Item {selectedItem.Name} not in stock right now. Rolled {diceRoll}, needed {selectedItem.Stock} or more.");
                continue;
            }

            hero.Character.Gold -= selectedItem.CostBuy;
            hero.Character.Equipment.Add(selectedItem);
            Console.WriteLine($"{selectedItem.Name} purchased! Remaining gold: {hero.Character.Gold}");

            HeroSaveManager.SaveHero(hero);
        }
    }

    private static void SellMagicItemsLoop(IHero hero)
    {
        if (!hero.Character.MagicItems.Any())
        {
            Console.WriteLine("No magic items to sell.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\n--- Sell Magic Items ---");
            for (int i = 0; i < hero.Character.MagicItems.Count; i++)
            {
                var item = hero.Character.MagicItems[i];
                Console.WriteLine($"{i + 1}. {item.Name} - Sells for {item.CostSell} gold");
            }
            Console.WriteLine("0. Leave Seller");

            Console.Write("Choose an item to sell (number): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > hero.Character.MagicItems.Count)
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            if (choice == 0)
                return; // exit seller

            var selected = hero.Character.MagicItems[choice - 1];
            hero.Character.Gold += selected.CostSell;
            hero.Character.MagicItems.Remove(selected);
            Console.WriteLine($"{selected.Name} sold for {selected.CostSell} gold. Total gold: {hero.Character.Gold}");

            HeroSaveManager.SaveHero(hero);
        }
    }

    private static void AttemptLevelUp(IHero hero)
    {
        if (hero.Character.BattleLevel >= 10)
        {
            Console.WriteLine("Maximum Battle Level reached.");
            return;
        }

        if (!Hero.GoldCostPerLevel.TryGetValue(hero.Character.BattleLevel + 1, out var nextCost) ||
            hero.Character.Gold < nextCost)
        {
            Console.WriteLine($"Not enough gold to level up. Next level requires {nextCost} gold.");
            return;
        }

        hero.LevelUp();
        HeroSaveManager.SaveHero(hero);
        Console.WriteLine($"Level up successful! {hero.Character.Name} is now Level {hero.Character.BattleLevel}.");
    }

    private static void VisitSpecialLocation()
    {
        Console.WriteLine("\n--- Visiting Special Location ---");
        Console.WriteLine("This is a unique location with special rules. Placeholder text for now.");
        Console.WriteLine("You can add your unique tables, events, or outcomes here later.");
    }
}
