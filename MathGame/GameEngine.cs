namespace MathGame
{
    internal class GameEngine
    {

       internal  void DivisionGame(string message)
        {


            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();

                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];



                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("You Are Correct! Press Enter To Continue..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You Are Incorrect Press Enter To Continue..");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game Over");
            }

            switch (score)
            {
                case 0:
                    Console.WriteLine($"You Got {score} Points Bruh...");
                    break;
                case 1:
                    Console.WriteLine($"You Only Got {score} Point, Do Better");
                    break;
                case 2:
                    Console.WriteLine($"{score} Points!! Study And Come Back!");
                    break;
                case 3:
                    Console.WriteLine($"{score}... Decent...Good Job");
                    break;
                case 4:
                    Console.WriteLine($"Your Score is {score} Points! Great Job!");
                    break;
                case 5:
                    Console.WriteLine($"You Got All Questions Right, Excellent! : )");
                    break;
            }
            Helpers.AddGameHistory("Division Game", score);
            Console.WriteLine("Press Enter To Go Back To The Menu");
            Console.ReadLine();
        }

      internal  void MultiplicationGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                int firstNumber = random.Next(0, 100);
                int secondNumber = random.Next(0, 100);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("You Are Correct! Press Enter To Continue..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You Are Incorrect Press Enter To Continue..");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game Over");
            }

            switch (score)
            {
                case 0:
                    Console.WriteLine($"You Got {score} Points Bruh...");
                    break;
                case 1:
                    Console.WriteLine($"You Only Got {score} Point, Do Better");
                    break;
                case 2:
                    Console.WriteLine($"{score} Points!! Study And Come Back!");
                    break;
                case 3:
                    Console.WriteLine($"{score}... Decent...Good Job");
                    break;
                case 4:
                    Console.WriteLine($"Your Score is {score} Points! Great Job!");
                    break;
                case 5:
                    Console.WriteLine($"You Got All Questions Right, Excellent! : )");
                    break;
            }
            Helpers.AddGameHistory("Multiplication Game", score);
            Console.WriteLine("Press Enter To Go Back To The Menu");
            Console.ReadLine();
        }

      internal  void SubtractionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                int firstNumber = random.Next(0, 100);
                int secondNumber = random.Next(0, 100);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("You Are Correct! Press Enter To Continue..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You Are Incorrect Press Enter To Continue..");
                    Console.ReadLine();
                }
                if (i == 4) Console.WriteLine($"Game Over");
            }

            switch (score)
            {
                case 0:
                    Console.WriteLine($"You Got {score} Points Bruh...");
                    break;
                case 1:
                    Console.WriteLine($"You Only Got {score} Point, Do Better");
                    break;
                case 2:
                    Console.WriteLine($"{score} Points!! Study And Come Back!");
                    break;
                case 3:
                    Console.WriteLine($"{score}... Decent...Good Job");
                    break;
                case 4:
                    Console.WriteLine($"Your Score is {score} Points! Great Job!");
                    break;
                case 5:
                    Console.WriteLine($"You Got All Questions Right, Excellent! : )");
                    break;
            }
            Helpers.AddGameHistory("Subtraction Game", score);
            Console.WriteLine("Press Enter To Go Back To The Menu");
            Console.ReadLine();
        }

       internal void AdditionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                int firstNumber = random.Next(0, 100);
                int secondNumber = random.Next(0, 100);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("You Are Correct! Press Enter To Continue..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You Are Incorrect Press Enter To Continue..");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game Over");
            }
            switch (score)
            {
                case 0:
                    Console.WriteLine($"You Got {score} Points Bruh...");
                    break;
                case 1:
                    Console.WriteLine($"You Only Got {score} Point, Do Better");
                    break;
                case 2:
                    Console.WriteLine($"{score} Points!! Study And Come Back!");
                    break;
                case 3:
                    Console.WriteLine($"{score}... Decent...Good Job");
                    break;
                case 4:
                    Console.WriteLine($"Your Score is {score} Points! Great Job!");
                    break;
                case 5:
                    Console.WriteLine($"You Got All Questions Right, Excellent! : )");
                    break;
            }
            Helpers.AddGameHistory("Addition Game", score);
            Console.WriteLine("Press Enter To Go Back To The Menu");
            Console.ReadLine();
        }

    }
}
