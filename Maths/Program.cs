using System;

namespace Maths
{
    class Program
    {

        static void SetAppInfo()
        {
            // set title with app info
            Console.Title = "Maths - version: 1.0.0 by Dad";

            // get user information
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine(); // Capitalise first letter

            Console.WriteLine("Now enter your age: ");
            string userAge = Console.ReadLine();

            // Clear console and write user details in green
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello {0}, age {1} - Welcome to Dads' Maths Game", userName, userAge);
            Console.ResetColor();
        }

        static int GenerateQuestion(int currentScore)
        {
            int newScore = currentScore;
            // Create random number
            Random a = new Random();

            // Setup numbers and operators
            string[] operators = { "+", "-", "x", "÷" };
            int rndOperator = a.Next(0, 3);
            int rndFirstNum = a.Next(0, 11);
            int rndSecondNum = a.Next(0, 11);
            int total = 0;

                // Display question
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} {1} {2} = ?", rndFirstNum, operators[rndOperator], rndSecondNum);
                Console.ResetColor();

                switch (rndOperator)
                {
                    case 0:
                        total = rndFirstNum + rndSecondNum;
                        break;
                    case 1:
                        total = rndFirstNum - rndSecondNum;
                        break;
                    case 2:
                        total = rndFirstNum * rndSecondNum;
                        break;
                    case 3:
                        total = rndFirstNum / rndSecondNum;
                        break;
                    default:
                        break;

                }

                // get input
                string input = Console.ReadLine();
                int inputInt = 0;

                // check it's an integer and not alphanumeric
                if (!int.TryParse(input, out inputInt))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} is not a number, please enter a number", input);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} {1} {2} = ?", rndFirstNum, operators[rndOperator], rndSecondNum);
                    Console.ResetColor();
            
                }
                else inputInt = Int32.Parse(input);

                // check if answer is correct
                if (total != inputInt)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} is incorrect, your score is now reset back to 0", inputInt);
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The correct answer is {0}", total);
                    newScore = 0;
                    Console.ResetColor();
                }
                else if (total == inputInt){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} is correct!", inputInt);
                Console.ResetColor();
                newScore++;
                }
            Console.Clear();
            Console.WriteLine("Current score: {0}", newScore);
            return newScore;
        }

        static void Main(string[] args)
        {
            SetAppInfo();
            int highScore = 0;
            int currentScore = 0;
          while (true)
            {
                Console.Title = "Maths - version: 1.0.0 by Dad - High score: " + highScore;
                currentScore = GenerateQuestion(currentScore);
                if(highScore < currentScore)
                {
                    highScore = currentScore;
                }
                
            }
            
        }
    }
}
