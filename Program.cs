using System;
using System.Collections.Generic;

namespace Lesson_3_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("~~ Savings Calculator ~~");
            Console.WriteLine();

            // Returning to this project after learning a little more about encapsulation, 
            // I am going to reorganise this with methods so that it is easier to understand
            // for someone else (or even myself!) reading my code.

            // I could structure it like
                // ask for user input (create a list to hold these variables?)
                // perform calculation (need to pass in a parameter from the previous step)
                // return output to the user (parameters, and I could use an if/else statement here)
            // using a different method for each.

            var varList = new List<double>{};
            // this list will store, in order: 
                // initial deposit
                // interest rate 
                // months planned to save for
                // savings goal

            askForUserInput(varList);
            var endBalance = calculateEndBalance(varList);
            checkIfGoalMetAndReturn(varList, endBalance);

        }

            // local methods

            static void askForUserInput(List<double> list)
            {
            
            // obtaining user input
            Console.WriteLine("Initial deposit: ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Monthly interest rate (percentage): ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Number of months you plan to save for: ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Savings goal: ");
            list.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine();    // line for clarity between input and output in the terminal
            
            }



            static double calculateEndBalance(List<double> list)
            {

            // performing and returning calculation
            var balance = list[0];
            for (int i = 0; i < list[2]; i++)
            {
                var x = balance * (list[1]/100);
                // uncomment the lines below to check interest and balance each month
                // Console.WriteLine($"month {i + 1}: ${balance}");
                // Console.WriteLine($"interest ${x}");
                balance += x;

            }
            // Console.WriteLine();    // line for clarity between check and output in the terminal
            return Math.Round(balance, 2);

            }



            static void checkIfGoalMetAndReturn(List<double> list, double endBalance)
            {   
                // here we writeline the amount in the account at the 
                // end of the savings period, check if the savings goal is met 
                // and writeline this information to the terminal for the user

                Console.WriteLine($"After {list[2]} months, you should have ${endBalance}.");
                if (list[3] <= endBalance)
                {
                    Console.WriteLine($"You have achieved your savings goal of ${list[3]}!");
                }
                else
                {       
                    Console.WriteLine($"You have not achieved your savings goal.");
                }

            }
    }
}
