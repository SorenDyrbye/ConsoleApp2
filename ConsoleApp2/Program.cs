
Console.WriteLine("Upload to GitHub");


Console.WriteLine("Denne skal også ligge i github");
Hund dog = new Hund("Fido", "Labrador", 3);
dog.noice();
Console.WriteLine($"Dog Name: {dog.Name}");
Console.WriteLine($"Dog Race: {dog.Race}");
Console.WriteLine($"Dog Age: {dog.Age}");

Hund Sofus = new Hund("Sofus", "Dansk Svensk", 5);
Console.WriteLine($"Dog Name: {Sofus.Name}");
Sofus.noice();
Console.WriteLine("Dette er en ændring lavet i github");
Console.WriteLine($"Dog Name: {Sofus.Name}");
Console.WriteLine(dog.IsTheDogAGoodBoy());