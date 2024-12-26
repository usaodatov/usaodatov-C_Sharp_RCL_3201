using System;

class HistogramProgram
{
    static void Main(string[] args)
    {

        Console.WriteLine(@"
                                C# program which based on the entry of a number
                                between 1 and 190 determines which of the 19 Spins it belongs to.
                                Let's start: ");


        bool infiniteRun = true; // Flag to control the loop

        while (infiniteRun)
        {
            Console.Write(@"
                               
                                Enter a number between 1 and 190:   ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number >= 1 && number <= 190)
                {
                    int spinNumber = matchSpin(number);
                    Console.Write($@"
                                The number {number} belongs to Spin {spinNumber}.");
                }
                else
                {
                    Console.Write(@"
                                The number is out of the allowed range. Please enter a number between 1-190.");
                }
            }
            else
            {
                Console.Write(@"
                                Invalid input. Please enter a valid number.");
            }

            // Enhanced input validation for continuation
            bool correctEntry = false;
            while (!correctEntry)
            {
                Console.Write(@"
                               
                              


                                Do you want to enter another number? (yes/no) :  ");
                string continueInput = Console.ReadLine().Trim().ToLower();

                if (continueInput == "yes")
                {
                    correctEntry = true; // Correct entry, continue the program
                }
                else if (continueInput == "no" )
                {
                    Console.WriteLine(@"
                                Exiting the program. Goodbye!");    
                    infiniteRun = false; // Exit the program
                    correctEntry = true; // Input is correct, exiting
                }
                else
                {
                    Console.WriteLine(@"
                                Invalid entry. Please enter 'yes', 'no'");
                    // Loop will continue until a correct entry is provided
                }
            }
        }
    }

    static int matchSpin(int number)
    {
        int[] spinRanges = { 9, 29, 49, 69, 89, 109, 129, 149, 169, 189 };

        for (int i = 0; i < spinRanges.Length; i++)
        {
            if (number <= spinRanges[i])
            {
                return i;  // Spin number starts from 0
            }
        }
        return -1; // Default return value for out of range numbers
    }
}
