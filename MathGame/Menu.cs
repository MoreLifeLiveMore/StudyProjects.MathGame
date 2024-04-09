namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();

        Helpers helpers = new Helpers();
       internal void ShowMenu(string name, DayOfWeek date)
        {
            Console.WriteLine("------------------------------------------");
            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Hello {name}, it is {date}. Thank you for playing this MathGame and starting the journey of self improvement!\n");
                Console.WriteLine($@"What game would you like to play today? Please choose from below: 
V - View Game History
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit Program"); // string interpolation / verbatim text (@)
                Console.WriteLine("-----------------------------------------");

                var gameChoice = Console.ReadLine(); // variable that holds a READLINE, waiting for user input to continue code
                switch (gameChoice!.Trim())
                {
                    case "v":
                    case "V":
                        helpers.GameHistory();
                        break;
                    case "a":
                    case "A":
                        engine.AdditionGame("Addition Game");
                        break;
                    case "s":
                    case "S":
                        engine.SubtractionGame("Subtraction Game");
                        break;
                    case "m":
                    case "M":
                        engine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                    case "D":
                        engine.DivisionGame("Division Game");
                        break;
                    case "q":
                    case "Q":
                        isGameOn = false;
                        helpers.QuitGame("Goodbye For Now");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (isGameOn);

        }
    }
}
