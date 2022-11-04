//
// COP4931 – Fall Semester, 2022
//
// Homework #1: The Four Way Stoplight Problem
//
// Ernesto Diaz
//
//

namespace Homework_1 {
    Stoplight north = new Stoplight("North", "red");
    Stoplight south = new Stoplight("South", "red");
    Stoplight east = new Stoplight("East", "green");
    Stoplight west = new Stoplight("West", "green");

    Stoplight[] stoplights = new Stoplight[] { north, south, east, west };

    DisplayNames(stoplights);
    DisplayConf(stoplights);


    east.SetColor("yellow");
west.SetColor("yellow");
DisplayConf(stoplights);

    east.SetColor("red");
west.SetColor("red");
DisplayConf(stoplights);

    north.SetColor("green");
south.SetColor("green");
DisplayConf(stoplights);

    north.SetColor("yellow");
south.SetColor("yellow");
DisplayConf(stoplights);

    north.SetColor("red");
south.SetColor("red");
DisplayConf(stoplights);

    east.SetColor("green");
DisplayConf(stoplights);

    west.SetColor("green");
DisplayConf(stoplights);

    east.SetColor("yellow");
west.SetColor("yellow");
DisplayConf(stoplights);

    east.SetColor("red");
west.SetColor("red");
DisplayConf(stoplights);


    //
    // Method Name: DisplayNames
    // Description: Displays the names of the stoplights
    void DisplayNames(Stoplight[] stoplights)
    {
        foreach (Stoplight stoplight in stoplights)
        {
            Console.Write(String.Format("| {0, 6} |", stoplight.GetName()));
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
    }

    //
    // Method Name: DisplayConf
    // Description: Displays the current configuration
    void DisplayConf(Stoplight[] stoplights)
    {
        foreach (Stoplight stoplight in stoplights)
        {
            Console.Write(String.Format("| {0, 6} |", stoplight.GetColor()));
        }
        Console.WriteLine();
    }


}


