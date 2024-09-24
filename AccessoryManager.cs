using System;
using System.Collections.Generic;
using System.IO;

public class AccessoryManager
{
    private List<Accessory> accessories = new List<Accessory>();  // The list that holds the accessories
    private string filePath = "accessories.txt";  // The file where accessories will be stored

    // Adds a new accessory to the list and saves it to the file
    public void AddAccessory(Accessory accessory)
    {
        accessories.Add(accessory);
        SaveToFile();
    }

    // Deletes an accessory from the list based on its ID and saves the updated list to the file
    public void DeleteAccessory(int id)
    {
        var accessoryToDelete = accessories.Find(a => a.Id == id);
        if (accessoryToDelete != null)
        {
            accessories.Remove(accessoryToDelete);
            SaveToFile();
        }
        else
        {
            Console.WriteLine("Accessory not found.");
        }
    }

    // Saves the list of accessories to a file
    private void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var accessory in accessories)
            {
                writer.WriteLine($"{accessory.Id}|{accessory.Name}|{accessory.Description}");
            }
        }
    }

    // Loads the accessories from the file into the list
    public void LoadFromFile()
    {
        if (File.Exists(filePath))
        {
            accessories.Clear();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                var accessory = new Accessory(int.Parse(parts[0]), parts[1], parts[2]);
                accessories.Add(accessory);
            }
        }
    }

    // Displays all accessories in the list
    public void DisplayAccessories()
    {
        foreach (var accessory in accessories)
        {
            Console.WriteLine(accessory);
        }
    }
}
