// COP 4931 - IT Software Systems Development
// Instructor - James Anderson
// Student - Ernesto Diaz
// Assignment - AHPA 8: The Stamp Collector


// Create instances
ForeignStamp[] fStamps = new ForeignStamp[3];
fStamps[0] = new ForeignStamp() { country = "Britain", price = 75, used = true, dateOfIssue = DateTime.Today };
fStamps[1] = new ForeignStamp() { country = "France", price = 125, used = false, dateOfIssue = DateTime.Today };
fStamps[2] = new ForeignStamp() { country = "Poland", price = 90, used = false, dateOfIssue = DateTime.Today };

DomesticStamp[] dStamps = new DomesticStamp[2];
dStamps[0] = new DomesticStamp() { state = "Ohio", price = 15, used = true, dateOfIssue = DateTime.Today };
dStamps[1] = new DomesticStamp() { state = "Texas", price = 35, used = false, dateOfIssue = DateTime.Today };


// Write data to console in formatted table
Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,15}|", "Origin", "Price", "Used", "Date of issue"));
Console.WriteLine("----------------------------------------------------");
foreach (ForeignStamp f in fStamps)
{
    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,15}|", f.country, f.price, f.used, f.dateOfIssue.Date.ToShortDateString()));
}
foreach (DomesticStamp d in dStamps)
{
    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,15}|", d.state, d.price, d.used, d.dateOfIssue.Date.ToShortDateString()));
}
Console.WriteLine();
Console.WriteLine("Total foreign stamps: " + ForeignStamp.Count);
Console.WriteLine("Total domestic stamps: " + DomesticStamp.Count);



// Class definitions
public class Stamp
{
    public DateTime dateOfIssue;
    public int price;
    public bool used;
}

public class ForeignStamp : Stamp
{
    public static int Count = 0;
    public string country;

    public ForeignStamp()
    {
        Count++;
    }
}

public class DomesticStamp : Stamp
{
    public static int Count = 0;
    public string state;

    public DomesticStamp()
    {
        Count++;
    }
}