// COP 4931 - IT Software Systems Development
// Instructor - James Anderson
// Student - Ernesto Diaz
// Assignment - AHPA 6: Birthday

// Create array with names and print to console
string[] students = new string[] { "Jen Thompson", "Mike Hatch", "Ryan Jenkins" };
Console.WriteLine("Students:");
foreach(string student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine();

// Capitalize names and print to console with happy birthday messages
foreach(string student in students)
{
    Console.WriteLine($"Happy birthday, {student.ToUpper()}!");
}

Console.WriteLine();

// Ask for date of birth of each student
// Calculate and output days alive
foreach(string student in students)
{
    Console.WriteLine($"In what year was {student} born?");
    
    int birthYear = int.Parse(Console.ReadLine());
    int daysAlive = (DateTime.Today.Year - birthYear) * 365;
    Console.WriteLine($"{student} has been alive for approximately {daysAlive} days.");
}