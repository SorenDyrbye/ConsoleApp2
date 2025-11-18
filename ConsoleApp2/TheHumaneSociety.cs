
using System.Diagnostics;
using System.Xml.Linq;

namespace ConsoleApp2;

public class TheHumaneSociety
{
    private Dictionary<int,Hund> _hunde;

    public TheHumaneSociety()
    {
    }

    public void AddADog(int iD,string name, string race, int age)
    {
        Hund nyHund = new Hund(name, race, age);
        _hunde.Add(iD,nyHund);
    }

    public bool SendDogToFamily(int iD)
    {
        if (_hunde.ContainsKey(iD))
        {
            _hunde.Remove(iD);
            return true;
        }
        else
            return false;
    }   
}
