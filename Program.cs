// driver (Main() method)
using CodeExample;

// declare Pokemon object using no-arg constructor
Pokemon bulbasaur = new Pokemon();

// 0.5M is not necessary, because the TakeDamage method
// parameter "modifier" has a default value of 1.0M
bulbasaur.TakeDamage(12, 0.5M);

// declare Pokemon object using the parameterized constructor
Pokemon squirtle = new Pokemon(7, "Squirtle", new string[] {"Water"}, 15);

// declare Pokemon object using object initializer syntax
Pokemon charmander = new Pokemon { Name = "Charmander",
    DexNumber = 5,
    HP = 25, 
    Types = new string[] { "Fire" } };

Pokemon tyranitar = new Pokemon(251, "Tyranitar", new string[] { "Rock", "Dark" }, 100);

// ToString() is implied when you print an object of a class in which you
// have a ToString() method
Console.WriteLine(squirtle);
Console.WriteLine(tyranitar);

tyranitar.TakeDamage(100, 0.50M);

Console.WriteLine($"\nTyranitar took {100 * .50M} damage!\n");

Console.WriteLine(tyranitar);

