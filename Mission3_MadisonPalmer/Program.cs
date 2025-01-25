namespace Mission3_MadisonPalmer;

class Program
{
    private static readonly List<FoodItem?> FoodItems = new List<FoodItem?>();

    static void Main()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Food Items");
            Console.WriteLine("4. Exit");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddFoodItem();
                    break;
                case "2":
                    DeleteFoodItem();
                    break;
                case "3":
                    PrintFoodItems();
                    break;
                case "4":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddFoodItem()
    {
        Console.Write("Enter Food Name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter Category: ");
        string? category = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        int quantity;
        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
        {
            Console.WriteLine("Invalid quantity. Please enter a non-negative number.");
        }

        Console.Write("Enter Expiration Date (yyyy-mm-dd): ");
        DateTime expirationDate;
        while (!DateTime.TryParse(Console.ReadLine(), out expirationDate))
        {
            Console.WriteLine("Invalid date format. Please enter in yyyy-mm-dd format.");
        }

        FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
        FoodItems.Add(newItem);

        Console.WriteLine("Food item added successfully!\n");
    }

    static void DeleteFoodItem()
    {
        if (FoodItems.Count == 0)
        {
            Console.WriteLine("No food items to delete.\n");
            return;
        }

        Console.WriteLine("Enter the name of the food item to delete:");
        string? nameToDelete = Console.ReadLine();

        FoodItem? itemToRemove = FoodItems.Find(item => item?.Name != null && item.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));
        if (itemToRemove != null)
        {
            FoodItems.Remove(itemToRemove);
            Console.WriteLine("Food item deleted successfully!\n");
        }
        else
        {
            Console.WriteLine("Food item not found.\n");
        }
    }

    static void PrintFoodItems()
    {
        if (FoodItems.Count == 0)
        {
            Console.WriteLine("No food items in the inventory.\n");
            return;
        }

        Console.WriteLine("Current Food Items:");
        foreach (FoodItem? item in FoodItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
