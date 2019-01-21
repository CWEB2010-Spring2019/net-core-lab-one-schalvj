using System;
using System.Collections.Generic;
using static System.Console;


namespace lab_one
{
    class Program
    {
        // Start of the main method
        static void Main(string[] args)
        {
            // Declare an array that holds the questions
            string[] quizQuestions = { "1) When was .NET core released?",
                                       "2) What is the current version of .NET core?",
                                       "3) Which languages can be used to write applications and libraries for .NET Core?",
                                       "4) How is .NET Core supported by Microsoft?",
                                       "5) .NET Core is an _______ framework.",
                                       "6) Which operating systems does .NET Core run on?",
                                       "7) Which app-model(s) does .NET Core support?",
                                       "8) How often is .NET Core updated for security and quality?",
                                       "9) Which of the following is .NET Core compatible with via .NET Standard?",
                                       "10) What are some characteristics of .NET Core?"
                                      };
            
            // Declare a multi-dimensional array that holds options for each of the questions
            string[,] quizQuestionOptions = new string[,]{
                                     { "A) 2019","B) 2014","C) 2003","D) 1990" },
                                     { "A) 1.0","B) 2.2","C) 10.0","D) 3.0" },
                                     { "A) C#","B) Visual Basic","C) A, B, & D","D) F#" },
                                     { "A) .NET Core Support","B) Microsoft Windows Help","C) .NET Framework Support","D) Geek Squad" },
                                     { "A) Licensed","B) Obsolete","C) UI","D) Open-sourced" },
                                     { "A) All Three","B) Windows","C) macOS","D) Linux" },
                                     { "A) ASP.NET Core MVC","B) ASP.NET Web Forms","C) ASP.NET MVC","D) All Three" },
                                     { "A) Every other year","B) Every 5 years","C) Several times a year, typically monthly","D) Daily" },
                                     { "A) .NET Framework","B) Xamarin","C) Mono","D) All Three" },
                                     { "A) All product scenarios can be exercised at the command-line","B) It is closed source","C) It is for use specifically with Windows OS","D) It is supported by Microsoft, per .NET Framework Support" },

                                 };
            
            // Declare an array that holds the correct answers
            string[] correctAnswers = new string[10] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            // Declare an array to hold end-user selections
            string[] userSelection = new string[10];  //NOT SURE ON THIS ONE...


            string selection;
            int exit = 1;

            List<string> correct = new List<string>() ;
            List<string> wrong = new List<string>() ;

            Greetings();


            while (exit != 0)
            {
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    WriteLine("-----------------------------------------");
                    WriteLine("");
                    WriteLine(quizQuestions[x]);
                    WriteLine("");
                    for (int i = 0; i < quizQuestionOptions.GetLength(1); i++)
                    {
                        WriteLine(quizQuestionOptions[x, i]);
                    }
                    WriteLine("");
                    WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                    selection = ReadLine();
                    userSelection[x] = selection;

                    if (selection == correctAnswers[x])
                    {
                        correct.Add(selection);
                    }
                    else
                    {
                        wrong.Add("Question: " + (x +1) + ") " + selection);
                        
                    }
                }

                WriteLine("-----------------------------------------");
                WriteLine("");
                WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length + " correct.");
                WriteLine("");
                

                if (wrong.Count <= 3)
                {
                    WriteLine("You Passed The Quiz!");
                }
                else if (wrong.Count >= 4)
                {
                    WriteLine("Unfortunately you did not pass this time.  Please try again when you are ready.");
                    WriteLine("");
                    
                }
                
                if(wrong.Count > 0)
                {
                    WriteLine("-----------------------------------------");
                    WriteLine("Listed below are the questions you got wrong and the answer you gave:");
                    WriteLine(String.Join(", ", wrong));
                    WriteLine("");

                }
                
                // User option to retake the quiz or exit
                WriteLine("-----------------------------------------");
                WriteLine("");
                WriteLine("Please enter 0 to exit");
                WriteLine("");
                WriteLine("Please enter 1 to retake the quiz");

                exit = Convert.ToInt32(Console.ReadLine());

            }
        }
        private static void Greetings()
        {
            int response;
            string inputString;
            WriteLine("Welcome, this program will assess your knowledge of .NET Core.  You must answer atleast 7 questions correctly to pass.");
            WriteLine("To get started, please enter any number to start the quiz.");
            inputString = ReadLine();
            response = Convert.ToInt32(inputString);
        }
            
    }
}
