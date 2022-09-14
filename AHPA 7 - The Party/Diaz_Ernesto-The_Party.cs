// COP 4931 - IT Software Systems Development
// Instructor - James Anderson
// Student - Ernesto Diaz
// Assignment - AHPA 7: The Party

// Load data into list
List<Attendee> attendees = new List<Attendee>()
{
    new Attendee("Frank", "pizza", 10),
    new Attendee("Mary", "wings", 8),
    new Attendee("Bob", "cookies", 15),
    new Attendee("Lisa", "dip", 20),
    new Attendee("Mark", "brownies", 12),
    new Attendee("Ann", "burgers", 7),
    new Attendee("Henry", "mints", 30),
    new Attendee("Ruth", "hotdogs", 22)

};

// Display full list in a table
Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|", "Name", "Food", "Servings"));
Console.WriteLine(String.Format("----------------------------------------"));
foreach (Attendee attendee in attendees)
{
    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|", attendee.Name, attendee.Food, attendee.Servings));
}

Console.WriteLine();

// Answering questions

// How many peeps will be bringing food?
Console.WriteLine(attendees.Count + " people will be bringing food."); //8

//What foods will be there?
Console.Write("There will be: ");
foreach(Attendee attendee in attendees)
{
    Console.Write(attendee.Food);
    if(attendees.IndexOf(attendee) == attendees.Count - 1)
    {
        continue;
    }
    Console.Write(", ");
}
Console.WriteLine(".");

// How many people can be fed if Ruth cancels?
int totalServings = 0;
foreach (Attendee attendee in attendees) // 102
{
    if (attendee.Name == "Ruth")
    {
        continue;
    }
    totalServings += attendee.Servings;
}
Console.WriteLine("If Ruth cancels, " + totalServings + " people can be fed.");


// Nice little class to make my life easier
public class Attendee
{
    public string Name { get; set; }
    public string Food { get; set; }
    public int Servings { get; set; }

    public Attendee(string name, string food, int servings)
    {
        Name = name; 
        Food = food; 
        Servings = servings; 
    }
}







