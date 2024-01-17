using System;

class Program
{
    static void Main(string[] args)
    {
        // CONVERT POUNS TO KILOGRAMS
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = pounds * 0.453592;
        Console.WriteLine($"Weight in pounds: {pounds}");
        Console.WriteLine($"Weight in kilograms: {kilograms}");

        Console.WriteLine("====================");

        // CONVERT MILES TO KILOMETERS
        Console.Write("Enter distance in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.60934;
        Console.WriteLine($"Distance in miles: {miles}");
        Console.WriteLine($"Distance in kilometers: {kilometers}");

        Console.WriteLine("====================");

        // CONVERT FAHRENHEIT TO CELSIUS
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
        Console.WriteLine($"Temperature in Celsius: {celsius}");

        Console.WriteLine("====================");

        // CALCULATE AVERAGE AGE OF STUDENTS
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter age of student {i}: ");
            int age = Convert.ToInt32(Console.ReadLine());
            sum += age;
        }
        double averageAge = (double)sum / 10;
        Console.WriteLine("Ages of all students:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Student {i}: {i} years old");
        }
        Console.WriteLine($"Average age of students: {averageAge}");

        Console.WriteLine("====================");

        // Fantasy story
        string chosen1 = "Lavinia";
        string chosen2 = "Galadriel";
        string chosen3 = "Aslan";
        string chosen4 = "Nyssa";
        string faction1 = "Firestorm";
        string faction2 = "Frostborn";
        string faction3 = "Stormbringer";
        string faction4 = "Earthshaker";

        Console.WriteLine("In a world where magic and technology coexist, there are people who possess extraordinary powers, abilities, equipment, and items. They are called the Chosen, and they are the guardians of peace and justice.");
        Console.WriteLine("The Chosen are divided into four factions, each with its own specialty and philosophy. ");
        Console.WriteLine($"{chosen4}, the chose {faction1} who focuses on offensive and destructive magic, using weapons like flamethrowers, grenades, and rockets.");
        Console.WriteLine($"{chosen1}, the chosen {faction2} who specialized in defensive and supportive magic, using items like shields, potions, and crystals.");
        Console.WriteLine($"{chosen3}, the chosen {faction3} who excels in speed and mobility, using abilities like teleportation, flight, and invisibility.");
        Console.WriteLine($"{chosen2}, the chosen {faction3} who masters the power of nature and life, using equipment like plants, animals, and golems.");
        Console.WriteLine($"{chosen2}, the chosen {faction4} who masters the power of nature and life, using equipment like plants, animals, and golems.");
        Console.WriteLine("Will they able to succeed? Only time will tell...");
        Console.ReadLine();
    }
}
