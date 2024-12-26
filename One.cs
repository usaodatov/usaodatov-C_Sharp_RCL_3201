using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                                Hi! I'm TASK ONE - NUMBER CLASSIFIER");

            Console.WriteLine(@"
                                       
                                       If you enter a NUMBER,

                                       I will CONCLUDE 

                                       IF your number IS between 0 and 10.5 

                                       or NOT.");

            Console.WriteLine(@"
                                   
                                     Press any key to continue...");
            Console.ReadKey();





            //Flag to determine when to exit the program completely.
            bool exitProgram = false;

            while (!exitProgram) // while loop condition changed to check the flag
            {
                // Request the user to enter a number.
                Console.Write("\n\n\n\n\tYour NUMBER Please: ");

                // Initiate string variable and allocate the user's entry to it. 
                string userInput = Console.ReadLine();

                // Validation of user's entry:
                if (double.TryParse(userInput, out double validNumber))
                {
                    // Test if the number is between 0 and 10.5
                    if (validNumber >= 0 && validNumber <= 10.5)
                    {
                        // Output the result - if the number is between 0 and 10.5
                        Console.WriteLine($"\n\tThe number you entered {userInput}, which IS between 0 and 10.5");
                    }
                    else
                    {
                        // Output the result - if the number is NOT between 0 and 10.5
                        Console.WriteLine($"\n\t The number [ {userInput} ], which you entered IS NOT between 0 and 10.5");
                    }
                }
                else
                {
                    // if [TryParse()] method returns false. - User's entry is not a number. 
                    Console.WriteLine($"\n\tYour ENTRY [{userInput}] is NOT a number! You must enter a NUMBER.");
                }

                // Nested loop - to ensure right entry entered by the user for continuation or end of the program.
                while (true)
                {
                    // Prompt the user to Try again or End the program.
                    Console.WriteLine("\n\n\n\n\tPress 'Y' for another try or 'N' to end!");

                    // Takes the user's choice Y or N
                    Console.Write("\n\tY or N: ");
                    string choice = Console.ReadLine().ToLower();

                    // Test the user's choice against: No / [n], if so, shows a goodbye message and ends the program.
                    if (choice == "n")
                    {
                        Console.WriteLine("\n\tGOOD BYE!");
                        //Set the flag to true to exit the outer loop and end the program.
                        exitProgram = true;
                        break; // Break the inner loop
                    }
                    // Test the user's choice against: Yes / [y], if so, shows a message - and continues the [While loop].
                    else if (choice == "y")
                    {
                        Console.WriteLine("\n\tSure! Give it another GO!");
                        break; // Break the inner loop to allow another try
                    }
                    // If the user's entry is neither [Y]/[y] or [N]/[n], shows ERROR and prompts the user to enter Y/N - y/n
                    else
                    {
                        Console.WriteLine("\n\tInvalid Entry! Please enter 'Y' or 'N'!");
                    }
                }
            }
        }
    }
}
