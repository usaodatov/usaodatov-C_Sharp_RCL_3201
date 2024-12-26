using System;


namespace TaskThree
{



class Task_Three_MarkToGradeConverter
        {
            static void Main(string[] args)
            {
                // Program introduction using a verbatim string.
                Console.WriteLine(@"This is Mark to Grade Converter.
This will takes a numerical mark between 0 and 100. Will convert it to a letter grade (A-F).
Based on the grade, a message regarding this marks calssification (pass/fail) will be displayed.");

                //initiate bool variable
                bool continueRunning = true;

               
                while (continueRunning)
                {
                    Console.WriteLine("\nEnter your mark (0-100):");
                    string input = Console.ReadLine();
                    int mark;

                    // Check input is a number within 0-100.
                    if (!int.TryParse(input, out mark) || mark < 0 || mark > 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0-100.");
                        continue; // Skip the rest of this loop iteration and prompt again
                    }

                    // Convert mark to grade.
                    string grade = ConvertMarkToGrade(mark);

                    // Output message based on grade.
                    switch (grade)
                    {
                        case "A":
                        case "B":
                        case "C":
                            Console.WriteLine($"Grade: {grade}. You Have Passed.");
                            break;
                        case "D":
                        case "E":
                            Console.WriteLine($"Grade: {grade}. You have failed: You must resit the exam.");
                            break;
                        case "F":
                            Console.WriteLine($"Grade: {grade}. You have failed: You cannot resit the exam.");
                            break;
                        default:
                            Console.WriteLine("Unknown result.");
                            break;
                    }

                    // Offer retry or exit option.
                    continueRunning = AnotherTry();
                }
            }

            // Map mark to grade.
            static string ConvertMarkToGrade(int mark)
            {
                if (mark >= 70) return "A";
                if (mark >= 60) return "B";
                if (mark >= 50) return "C";
                if (mark >= 40) return "D";
                if (mark >= 30) return "E";
                if (mark < 30) return "F";
                return "Invalid"; // Fallback, should not be reached
            }

            // Prompt to retry.
            static bool AnotherTry()
            {
                while (true) // Loop for valid yes/no response.
                {
                    Console.WriteLine("Do you want to try another number? (yes/no):");
                    string response = Console.ReadLine().Trim().ToLower();

                    if (response == "yes") return true;
                    if (response == "no") return false;

                    Console.WriteLine("Invalid entry. Please type 'yes' or 'no'.");
                }
            }
        }

    }


