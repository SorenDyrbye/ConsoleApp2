

public class Hund
{
    public string Race { get; set; }
    public string Name { get; }
    public int Age { get; set; }
    public bool IsGoodBoy { get; set; }

    public Hund (string name, string race, int age)
    {
        Name = name;
        Race = race;
        Age = age;
        IsGoodBoy = true;
    }
    public void noice ()
    {
        System.Console.WriteLine("Wuff Wuff");
    }

    public string IsTheDogAGoodBoy()
    {
        return true ? "This dog is a good boy" : "This dog is not a good boy";
    }

}

