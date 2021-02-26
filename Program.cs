using System;

namespace Lesson_3_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("~~ Savings Calculator ~~");
            Console.WriteLine();

            // obtaining inputs
            Console.WriteLine("Initial deposit: ");
            var deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Monthly interest rate: ");
            var interestRate = double.Parse(Console.ReadLine());
            interestRate = (100 + interestRate)/100;
            Console.WriteLine("Number of months you plan to save for: ");
            var months = double.Parse(Console.ReadLine());
            Console.WriteLine("Savings goal: ");
            var goal = double.Parse(Console.ReadLine());
            Console.WriteLine("Extra deposits every month: ")
            var extra = double.Parse(Console.ReadLine());
            Console.WriteLine();
            

            // performing calculation
            var maturity = (deposit + extra) * (Math.Pow(interestRate, months));
            var calculation = goal <= maturity;
            Console.WriteLine($"After {months} months, you should have ${maturity}.");
            Console.WriteLine($"Will you achieve your savings goal? {calculation}");
            Console.WriteLine();
        }
    }
}
