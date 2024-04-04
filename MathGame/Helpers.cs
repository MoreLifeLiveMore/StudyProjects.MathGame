﻿namespace MathGame
{
    internal class Helpers
    {
       static List<string> games = new List<string>();
       internal static string GetName()
        {
            Console.WriteLine("Please Enter Your Name");

            string name = Console.ReadLine(); // Console.READLINE waits for user input before moving on 
            return name;
        }

       internal void GameHistory()
        {
            Console.Clear();
            Console.WriteLine("Previously Played Games");
            Console.WriteLine("---------------------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Press Enter To Go Back To The Menu");
            Console.ReadLine();

        }

       internal void QuitGame(string message) // method with a local string variable named message
        {
            Console.WriteLine(message);

        }

       internal static int[] GetDivisionNumbers()
        {
            var random = new Random();

            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);

            var result = new int[2];


            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);

            }

            result[0] = firstNumber; result[1] = secondNumber;



            return result;
        }

       internal static void AddGameHistory(string gameType, int score)
        {
            games.Add($"{DateTime.Now}   {gameType} - Score: {score}");
        }


    }
}