using MathGame.Models;
using System;
using System.Linq;

namespace MathGame
{
    internal class Helpers
    {
       static List<Game> games = new List<Game>();
       internal static string GetName()
        {
            Console.WriteLine("Please Enter Your Name");

            string name = Console.ReadLine()!; // Console.READLINE waits for user input before moving on 
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid Input. Try Again");
                name = Console.ReadLine()!;
            }
            return name!;
        }

       internal void GameHistory()

        {
             //var gamesToPrint = games.Where(x => x.GameType == GameType.Division);
            // var gamesToPrint = games.Where(x => x.date > new DateTime());
            // var gamesToPrint = games.Where(x => x.date > new DateTime() && x.Score > 3);
           // var gamesToPrint = games.Where(x => x.date > new DateTime()).OrderByDescending(x => x.Score);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.date} - {game.GameType}: {game.Score}pts");
            }
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();

        }

       /* internal void Search()
        {
            var search = Console.ReadLine();
            var gamesHistory = games.Where( x => x.GameType.ToString() == search).ToList();

            Console.Clear();
            Console.WriteLine("Search");
            Console.WriteLine("---------------------------");
            foreach (Game game in gamesHistory)
            {
                Console.WriteLine(gamesHistory);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Press Enter To Go Back To The Menu Or S To Search Game History");

            var viewChoice = Console.ReadLine();
        } */

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

       internal static void AddGameHistory(GameType gameType, int score)
        {
            games.Add(new Game
            {
                date = DateTime.Now,
                Score = score,
                GameType = gameType,
            });
        }

        internal static string? ValidateResult( string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Invalid Input. Try Again");
                result = Console.ReadLine()!;
            }
            return result;
        }
    }
}
