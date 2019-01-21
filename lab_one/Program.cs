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
            

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            Greetings();


            while ( != -1)
            {
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    WriteLine("-----------------------------------------");
                    WriteLine(quizQuestions[x]);
                    for (int i = 0; i < quizQuestionOptions.GetLength(1); i++)
                    {
                        WriteLine(quizQuestionOptions[x, i]);
                    }
                    WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                    selection = ReadLine();
                    userSelection[x] = selection;

                    if (selection == correctAnswers[x])
                    {
                        correct.Add(selection);
                    }
                    else
                    {
                        wrong.Add("Question: " + (x + 1) + ") " + selection);
                    }
                }
                WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);
                var results = (correct.Count >= 1) ? "You passed the quiz " : " You didn't pass ";

                if (wrong.Count > 0)
                {
                    WriteLine("Listed below are the questions you got wrong:");
                    WriteLine(wrong);
                }
                else
                {
                    wrong.Clear();
                    correct.Clear();
                    WriteLine("To take the quiz again, enter any value other than -1.  To exit enter -1");
                    ReadLine();
                }
            }
        }
        private static void Greetings()
        {
            int response;
            string inputString;
            WriteLine("Welcome, this program will assess your knowledge of .NET Core.");
            WriteLine("To get started, please enter a number other than -1 to start the quiz.");
            inputString = ReadLine();
            response = Convert.ToInt32(inputString);
        }
            
    }
}
       
                /*
                // Question 1 Answer = B
                WriteLine("-----------------------------------------");
                WriteLine("1) " + quizQuestions[0]);
                WriteLine("    " + quizQuestionOptions[0, 0]);
                WriteLine("    " + quizQuestionOptions[0, 1]);
                WriteLine("    " + quizQuestionOptions[0, 2]);
                WriteLine("    " + quizQuestionOptions[0, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[0] = ReadLine();

                if (userSelection[0] == correctAnswers[0])
                {
                    WriteLine("***** " + quizQuestionOptions[0, 1] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 2 Answer = B
                WriteLine("-----------------------------------------");
                WriteLine("2) " + quizQuestions[1]);
                WriteLine("    " + quizQuestionOptions[1, 0]);
                WriteLine("    " + quizQuestionOptions[1, 1]);
                WriteLine("    " + quizQuestionOptions[1, 2]);
                WriteLine("    " + quizQuestionOptions[1, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[1] = ReadLine();

                if (userSelection[1] == correctAnswers[1])
                {
                    WriteLine("***** " + quizQuestionOptions[1, 1] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 3 Answer = C
                WriteLine("-----------------------------------------");
                WriteLine("3) " + quizQuestions[2]);
                WriteLine("    " + quizQuestionOptions[2, 0]);
                WriteLine("    " + quizQuestionOptions[2, 1]);
                WriteLine("    " + quizQuestionOptions[2, 2]);
                WriteLine("    " + quizQuestionOptions[2, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[2] = ReadLine();

                if (userSelection[2] == correctAnswers[2])
                {
                    WriteLine("***** " + quizQuestionOptions[2, 2] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 4 Answer = A
                WriteLine("-----------------------------------------");
                WriteLine("4) " + quizQuestions[3]);
                WriteLine("    " + quizQuestionOptions[3, 0]);
                WriteLine("    " + quizQuestionOptions[3, 1]);
                WriteLine("    " + quizQuestionOptions[3, 2]);
                WriteLine("    " + quizQuestionOptions[3, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[3] = ReadLine();

                if (userSelection[3] == correctAnswers[3])
                {
                    WriteLine("***** " + quizQuestionOptions[3, 0] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 5 Answer = D
                WriteLine("-----------------------------------------");
                WriteLine("5) " + quizQuestions[4]);
                WriteLine("    " + quizQuestionOptions[4, 0]);
                WriteLine("    " + quizQuestionOptions[4, 1]);
                WriteLine("    " + quizQuestionOptions[4, 2]);
                WriteLine("    " + quizQuestionOptions[4, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[4] = ReadLine();

                if (userSelection[4] == correctAnswers[4])
                {
                    WriteLine("***** " + quizQuestionOptions[4, 3] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 6 Answer = A
                WriteLine("-----------------------------------------");
                WriteLine("6) " + quizQuestions[5]);
                WriteLine("    " + quizQuestionOptions[5, 0]);
                WriteLine("    " + quizQuestionOptions[5, 1]);
                WriteLine("    " + quizQuestionOptions[5, 2]);
                WriteLine("    " + quizQuestionOptions[5, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[5] = ReadLine();

                if (userSelection[5] == correctAnswers[5])
                {
                    WriteLine("***** " + quizQuestionOptions[5, 0] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 7 Answer = A
                WriteLine("-----------------------------------------");
                WriteLine("7) " + quizQuestions[6]);
                WriteLine("    " + quizQuestionOptions[6, 0]);
                WriteLine("    " + quizQuestionOptions[6, 1]);
                WriteLine("    " + quizQuestionOptions[6, 2]);
                WriteLine("    " + quizQuestionOptions[6, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[6] = ReadLine();

                if (userSelection[6] == correctAnswers[6])
                {
                    WriteLine("***** " + quizQuestionOptions[6, 0] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 8 Answer = C
                WriteLine("-----------------------------------------");
                WriteLine("8) " + quizQuestions[7]);
                WriteLine("    " + quizQuestionOptions[7, 0]);
                WriteLine("    " + quizQuestionOptions[7, 1]);
                WriteLine("    " + quizQuestionOptions[7, 2]);
                WriteLine("    " + quizQuestionOptions[7, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[7] = ReadLine();

                if (userSelection[7] == correctAnswers[7])
                {
                    WriteLine("***** " + quizQuestionOptions[7, 2] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 9 Answer = D
                WriteLine("-----------------------------------------");
                WriteLine("9) " + quizQuestions[8]);
                WriteLine("    " + quizQuestionOptions[8, 0]);
                WriteLine("    " + quizQuestionOptions[8, 1]);
                WriteLine("    " + quizQuestionOptions[8, 2]);
                WriteLine("    " + quizQuestionOptions[8, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[8] = ReadLine();

                if (userSelection[8] == correctAnswers[8])
                {
                    WriteLine("***** " + quizQuestionOptions[8, 3] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Question 10 Answer = A
                WriteLine("-----------------------------------------");
                WriteLine("10) " + quizQuestions[9]);
                WriteLine("    " + quizQuestionOptions[9, 0]);
                WriteLine("    " + quizQuestionOptions[9, 1]);
                WriteLine("    " + quizQuestionOptions[9, 2]);
                WriteLine("    " + quizQuestionOptions[9, 3]);
                WriteLine("");
                WriteLine("Please enter A, B, C, or D. This program is case sensative.");
                WriteLine("");
                userSelection[9] = ReadLine();

                if (userSelection[9] == correctAnswers[9])
                {
                    WriteLine("***** " + quizQuestionOptions[9, 0] + ", is correct!" + " *****");
                }
                else
                {
                    WriteLine("***** " + "Incorrect Answer" + " *****");
                }

                // Retake or Exit Quiz
                WriteLine("");
                WriteLine("-----------------------------------------");
                WriteLine("Do you want to retake the quiz?");
                WriteLine("");
                WriteLine("Please enter a number to retake the quiz, or -1 to EXIT the quiz:");

                EXIT = Convert.ToInt32(ReadLine());
                
            }
        }
    }
}
*/
            /*
            // PSEUDO CODE BELOW //
            string[] selection;
            num start;
            int num = -1; //Sentinel Value

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            start = greetings(); //Calling or invoking method

            while start != EXIT
                FOR(num x = 0; x < quizQuestions.Length; x++){
                    OUTPUT quizQuestions[x]
                    FOR(num i = 0; i < quizQuestionOptions.GetLength(1); i++){
                            OUTPUT quizQuestionOptions[x, i]
                    }
                    OUTPUT "Please enter an option"
                    INPUT selection
                    userSelection[x] = selection

                    //Need to determine if the user's selection is the correct answer
                    IF( selection == correctAnswers[x] ) THEN
                        correct.Add(selection)
                    ELSE
                        wrong.Add("Question: " + (x + 1) + ") " + selection)
                    ENDIF
                }
                OUTPUT "You answered " + correct.Count + " out of " + quizQuestions.Length

                //Determine if they passed (7/10 or higher is passing)
                var results = (correct.Count >= 1) ? "You passed the assessment " : " You didn't pass ";

                //OUTPUT the wrong questions
                IF (wrong.Count > 0) THEN 
                    OUTPUT "Listed below are the questions you got wrong"
                    wrong.ForEach(x => { OUTPUT x });
                ENDIF

                wrong.Clear()
                correct.Clear()

                OUTPUT "To take the quiz again, enter any value other than -1.  To exit enter -1."
                INPUT start
            
            ENDWHILE
            
            OUTPUT "Program has concluded"
        
    
            }
        }//End of main method
        static num greetings() //Method header
            num start
            OUTPUT "Welcome, this program will assess your knowledge of .NET Core"
            OUTPUT "To get started, please enter a number other -1 to start the program"
            INPUT start
        RETURN start
    }
}
*/