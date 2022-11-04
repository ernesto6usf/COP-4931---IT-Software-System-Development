using System.Diagnostics;
using System;

namespace Buying_A_House
{
    class Program
    {
        private static decimal ReadPositiveDecimal(string prompt)
        {
            Console.WriteLine(prompt);
            decimal result;
            while (true)
            {
                string principalText = Console.ReadLine();
                bool success = decimal.TryParse(principalText, out result);
                if (!success)
                    Console.WriteLine(prompt);
                else if (result < 0.0m)
                    Console.WriteLine("Please enter a positive value.");
                else
                    break;
            }
            return result;
        }
        static decimal TotalInterest(decimal principal, decimal interestRate, decimal monthlyPayment)
        {
            if (principal < 0.0m)
                throw new ArgumentException("principal must be positive", "principal");
            if (interestRate < 0.0m)
                throw new ArgumentException("interest rate must be positive", "interestRate");
            if (monthlyPayment < 0.0m)
                throw new ArgumentException("monthly payment must be positive", "monthlyPayment");
            if ((principal * interestRate) / 1200 >= monthlyPayment)
                throw new ArgumentException("monthly payment does not cover interest", "monthlyPayment");

            // Every month there will be a payment that will reduce
            // the principal and pays interest. This repeats until
            // the principal is gone.
            decimal totalInterest = 0.0m;
            decimal currentPrincipal = principal;
            while (0.0m < currentPrincipal)
            {
                decimal currentInterest = currentPrincipal * ((interestRate / 100.0m) / 12);
                decimal reduction = monthlyPayment - currentInterest;
                Debug.Assert(reduction > 0.0m);
                currentPrincipal = currentPrincipal - reduction;
                totalInterest = totalInterest + currentInterest;
            }
            return totalInterest;
        }
        static int PayoffMonths(decimal principal, decimal interestRate, decimal monthlyPayment)
        {
            if (principal < 0.0m)
                throw new ArgumentException("principal must be positive", "principal");
            if (interestRate < 0.0m)
                throw new ArgumentException("interest rate must be positive", "interestRate");
            if (monthlyPayment < 0.0m)
                throw new ArgumentException("monthly payment must be positive", "monthlyPayment");
            if ((principal * interestRate) / 1200 >= monthlyPayment)
                throw new ArgumentException("monthly payment does not cover interest", "monthlyPayment");

            int totalMonths = 0;
            decimal currentPrincipal = principal;
            while (0.0m < currentPrincipal)
            {
                decimal currentInterest = currentPrincipal * ((interestRate / 100.0m) / 12);
                decimal reduction = monthlyPayment - currentInterest;
                Debug.Assert(reduction > 0.0m);
                currentPrincipal = currentPrincipal - reduction;
                totalMonths += 1;
            }
            return totalMonths;
        }
        static void Main(string[] args)
        {
            decimal principal;
            decimal interestRate;
            decimal downPayment;
            decimal totalInterest;
            decimal fifteenYears;
            decimal thirtyYears;
            principal = ReadPositiveDecimal("Please enter the price of the house: ");
            downPayment = ReadPositiveDecimal("Please enter the your down payment: ");
            interestRate = ReadPositiveDecimal("Please enter the current interest rate: ");
            totalInterest = TotalInterest(principal, interestRate, downPayment);

            fifteenYears = (principal - downPayment + totalInterest) / 180m;
            thirtyYears = (principal - downPayment + totalInterest) / 360m;

            Console.WriteLine("You monthly payment on a 15-year mortgage would be {0:C2}.", fifteenYears);
            Console.WriteLine("You monthly payment on a 30-year mortgage would be {0:C2}.", thirtyYears);
        }
    }
}
