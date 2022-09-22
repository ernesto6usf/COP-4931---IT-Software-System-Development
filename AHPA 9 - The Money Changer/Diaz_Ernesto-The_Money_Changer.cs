// COP 4931 - IT Software Systems Development
// Instructor - James Anderson
// Student - Ernesto Diaz
// Assignment - AHPA 9: The Money Changer

// Instantiate a currency converter
CurrencyConverter currencyConverter = new CurrencyConverter();

// Dictionary to display right currency symbol
Dictionary<int, char> currencySymbols = new Dictionary<int, char>()
{
    { 1, '\u00A5' },
    { 2, '\u00A5' },
    { 3, '\u20AC' },
};

while (true)
{
    // Get amount to convert
    Console.WriteLine("Eneter amount to convert:");
    float amount = int.Parse(Console.ReadLine());

    // Get the currency to convert to 
    Console.WriteLine("Enter the number of the currency you wish to convert to: (1)Yen (2)Yuan (3)Euro");
    int currency = int.Parse(Console.ReadLine());

    // Attempt to perform conversion and provide feedback
    float convertedAmount;
    switch (currency) {
        case 1:
            convertedAmount = currencyConverter.Yen(amount);
            DisplayOutput(convertedAmount, amount, currency);
            break;
        case 2:
            convertedAmount = currencyConverter.Yuan(amount);
            DisplayOutput(convertedAmount, amount, currency);
            break;
        case 3:
            convertedAmount = currencyConverter.Euro(amount);
            DisplayOutput(convertedAmount, amount, currency);
            break;
        default:
            Console.WriteLine("Please enter a valid option");
            break;
    }
}

// Helper function
void DisplayOutput(float convertedAmount, float amount, int currency)
{
    if (convertedAmount < 0)
    {
        Console.WriteLine("No funds");
    } else
    {
        Console.WriteLine("Succesfully converted $" + amount + " to " + currencySymbols[currency] + convertedAmount);
    }
}

// Currency Converter definition
public class CurrencyConverter
{
    private float yen;
    private float yuan;
    private float euro;

    private const int initialBalance = 5000;

    private float yenRate = 142.96f;
    private float yuanRate = 6.97f;
    private float euroRate = 1;

    public CurrencyConverter()
    {
        yen = yuan = euro = initialBalance;
    }

    public float Yen (float amount)
    {
        if (yen >= amount)
        {
            yen -= amount;
            return (amount * yenRate);
        } else
        {
            return -1;
        }
    }

    public float Yuan(float amount)
    {
        if (yuan >= amount)
        {
            yuan -= amount;
            return (amount * yuanRate);
        }
        else
        {
            return -1;
        }
    }

    public float Euro(float amount)
    {
        if (euro >= amount)
        {
            euro -= amount;
            return (amount * euroRate);
        }
        else
        {
            return -1;
        }
    }
}