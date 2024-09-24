using System;

class Program
{
    static void Main(string[] args)
    {
        AccessoryManager manager = new AccessoryManager();
        manager.LoadFromFile();  // Load existing accessories from the file at startup

        while (true)
        {
            Console.WriteLine("1. Add Accessory");
            Console.WriteLine("2. Delete Accessory");
            Console.WriteLine("3. Display All Accessories");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter accessory ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter accessory name: ");
                string name = Console.ReadLine();
                Console.Write("Enter accessory description: ");
                string description = Console.ReadLine();

                var accessory = new Accessory(id, name, description);
                manager.AddAccessory(accessory);
            }
            else if (option == "2")
            {
                Console.Write("Enter accessory ID to delete: ");
                int id = int.Parse(Console.ReadLine());
                manager.DeleteAccessory(id);
            }
            else if (option == "3")
            {
                manager.DisplayAccessories();
            }
            else if (option == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}
