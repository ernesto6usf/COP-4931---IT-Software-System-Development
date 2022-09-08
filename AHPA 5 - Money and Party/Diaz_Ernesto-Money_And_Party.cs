// COP 4931 - IT Software Systems Development
// Instructor - James Anderson
// Student - Ernesto Diaz Collazo
// Assignment - AHPA 5: Money & Party


// Part 1 of assignment - Money
const long usDebt = 22030000000000;
const int yearlyPaymentPerPerson = 1000;
const long usPopulation = 313000000;

// Calculate total yearly payment and time to pay off
long yearlyPayment = yearlyPaymentPerPerson * usPopulation;
int yearsToPayOff = (int)(usDebt / yearlyPayment); // cast to int, we know the result will fit

Console.WriteLine($"It would take approximately {yearsToPayOff} years to pay off the US Debt.");

// Part 2 of assignment - Party
Console.WriteLine();
Console.WriteLine("Part 2 of assignement");
Console.WriteLine("Enter student ID:");

string inputID = Console.ReadLine();

// Make sure string isnt empty or null
if (!string.IsNullOrEmpty(inputID))
{
    if (inputID[0] == 'U' || inputID[0] == 'u')
    {
        Console.WriteLine("Welcome in!");
    }
    else if (inputID[0] == 'F' || inputID[0] == 'f')
    {
        Console.WriteLine("Sorry, you are not cool enough. :(");
    }
    else
    {
        // handle invalid ids
        Console.WriteLine("Invalid ID. Please try again.");
    }
} else
{
    // handle empty or null input
    Console.WriteLine("Invalid input. Please try again.");
}

