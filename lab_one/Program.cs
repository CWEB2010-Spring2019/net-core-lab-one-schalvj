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
            // Declare an array that holds the correct answers
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A"};
            // Declare an array to hold end-user selections
            string[] userSelection = new string[10] ;  //NOT SURE ON THIS ONE...
            // Declare an array that holds the questions
            string[] quizQuestions = { "When was .NET core released?",
                                       "What is the current version of .NET core?",
                                       "Which languages can be used to write applications and libraries for .NET Core?",
                                       "How is .NET Core supported by Microsoft?",
                                       ".NET Core is an _______ framework.",
                                       "Which operating systems does .NET Core run on?",
                                       "Which app-model(s) does .NET Core support?",
                                       "How often is .NET Core updated for security and quality?",
                                       "Which of the following is .NET Core compatible with via .NET Standard?",
                                       "What are some characteristics of .NET Core?"
                                      };

            // Declare a multi-dimensional array that holds options for each of the questions
            string[,] quizQuestionOptions = new string[10, 4]{
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

            
            

            WriteLine("Hello Class!");
        }
    }
}
