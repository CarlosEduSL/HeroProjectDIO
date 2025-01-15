using System;

class Hero
{
    // Properties of the Hero class
    public string Name { get; set; }  // Hero's name
    public int Age { get; set; }      // Hero's age
    public string Type { get; set; }  // Hero's type (e.g., Mago, Guerreiro, etc.)

    // Constructor to initialize the hero's attributes
    public Hero(string name, int age, string type)
    {
        Name = name;
        Age = age;
        Type = type;
    }

    // Method to simulate an attack
    public void Attack()
    {
        string attackDescription = "ataque"; // Default attack description

        // Check the hero's type and define the attack description accordingly
        switch (Type.ToLower())
        {
            case "mago":
                attackDescription = "magia";
                break;
            case "guerreiro":
                attackDescription = "espada";
                break;
            case "monge":
                attackDescription = "artes marciais";
                break;
            case "ninja":
                attackDescription = "shuriken";
                break;
        }

        // Display the formatted message
        Console.WriteLine($"O {Type} atacou usando {attackDescription}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating two objects of the Hero class
        Hero mage = new Hero("Harry Potter", 22, "Mago");
        Hero warrior = new Hero("He-man", 200, "Guerreiro");
        Hero monk = new Hero("Shaolin", 30, "Monge");
        Hero ninja = new Hero("Jackie Chan", 70, "Ninja");

        // Call the Attack method for each object
        mage.Attack();       // Output: O Mago atacou usando magia
        warrior.Attack();    // Output: O Guerreiro atacou usando espada
        monk.Attack();       // Output: O Monge atacou usando artes marciais
        ninja.Attack();      // Output: O Ninja atacou usando shuriken
    }
}