

public class Hund
{
    public string Race { get; set; }
    public string Name { get; }
    public int Age { get; set; }

    public Hund (string name, string race, int age)
    {
        Name = name;
        Race = race;
        Age = age;
    }
    public void noice ()
    {
        System.Console.WriteLine("Wuff Wuff");
    }
   
}

