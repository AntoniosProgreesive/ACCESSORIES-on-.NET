using System;

public class Accessory
{
    public int Id { get; set; }       // Unique identifier for each accessory
    public string Name { get; set; }   // The name of the accessory
    public string Description { get; set; }  // A short description of the accessory

    // Constructor to initialize the accessory object
    public Accessory(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    // Returns a string representation of the accessory
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Description: {Description}";
    }
}
