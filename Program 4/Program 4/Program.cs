// Program 4
// CIS 199-02-4222
// Due: 4/18/2022
// By: R2215
// SuperHero
using System;
public class SuperHero
{
   
    private String superHeroName; 
    private String birthCity; 
    private String firstSuperpower; 
    private int birthYear; 
    private String firstInitial; 
    private bool plantEarth;

    // 5 parameter 
    public SuperHero(String SuperheroName, String BirthCity, String FirstSuperpower, int BirthYear, String Initial)
    {
        superHeroName = SuperheroName;
        birthCity = BirthCity;
        firstSuperpower = FirstSuperpower;   
        birthYear = BirthYear;
        firstInitial = Initial;
        plantEarth = false;
    }

    // Superhername string prop
    public String Superhername
    {
        get
        {
            return superHeroName;
        }

        set
        {
            superHeroName = value;
        }
    }

    // birthcity string prop
    public String BirthCity
    {
        get
        {
            return birthCity;
        }

        set
        {
            birthCity = value;
        }
    }

    // FirstSuperpower string prop
    public String FirstSuperpower
    {
        get
        {
            return firstSuperpower;
        }

        set
        {
            firstSuperpower = value;
        }
    }

    // BirthYear string prop
    public int BirthYear
    {
        get
        {
            return birthYear;
        }

        set
        {
            birthYear = value;
        }
    }

    // Initial string prop
    public String Initial
    {
        get
        {
            return firstInitial;
        }

        set
        {
            firstInitial = value;
        }
    }

    //see if hero on planet
    public void Earth()
    {
        plantEarth = !plantEarth;
    }

    // if hero has returned to earth
    public void OnEarth()
    {
        plantEarth = !plantEarth;
    }

    //  if off earth
    public bool OffEarth()
    {
        return plantEarth;
    }

    // to string method to show heros info
    public override String ToString()
    {
        String result = "";

        result += "Name: " + superHeroName + Environment.NewLine;
        result += "City: " + birthCity + Environment.NewLine;
        result += "First Super Power: " + firstSuperpower + Environment.NewLine;
        result += "Born in: " + birthYear + Environment.NewLine;
        result += "Second Super Power: " + firstInitial + Environment.NewLine;
        result += "Planet Earth: " + plantEarth + Environment.NewLine;

        return result;
    }
}

class Program
{
    static void Main(string[]args)
    {
        // hero objects
        SuperHero hero1 = new SuperHero("Aquaman", "Atlantis", "Telepathic control of aquatic life", 1941, "Utilizing the Sacred Trident");
        SuperHero hero2 = new SuperHero("Batman", "Gotham City", "Genius-level intellect", 1939, "Master of Martial arts");
        SuperHero hero3 = new SuperHero("Iron Man", "Long Island", "Powered Armor Suit", 1963, "Supersonic Flight");

        // hero data in array
        SuperHero[] heros = {hero1, hero2, hero3};

        //display text at top with method
        Console.WriteLine("Orginal list of super heros");
        Console.WriteLine("---------------------------");
        ShowHeros(heros);

        hero1.FirstSuperpower = "Telepathic control of aquatic life";
        hero1.Earth();

        Console.WriteLine("After Changes");
        Console.WriteLine("---------------------------");
        ShowHeros(heros);

        // earth method usage
        hero1.Earth();
        hero2.Earth();
        hero3.Earth();

        Console.ReadKey();
    }

    
    public static void ShowHeros(SuperHero[] heros)
    {
        for (int j = 0; j < heros.Length; j++)
        {   
            Console.WriteLine(heros[j]);
        }
    }
}