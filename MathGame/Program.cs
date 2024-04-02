using static System.Formats.Asn1.AsnWriter;
using System;

var date = DateTime.UtcNow.DayOfWeek;

string name = GetName();
Menu(name);
static string GetName()
{
    Console.WriteLine("Please Enter Your Name");

    string name = Console.ReadLine(); // Console.READLINE waits for user input before moving on 
    return name;
}
void Menu(string name)
{
    Console.WriteLine("------------------------------------------");
    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}, it is {date}. Thank you for playing this MathGame and starting the journey of self improvement!\n");
        Console.WriteLine($@"What game would you like to play today? Please choose from below: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit Program"); // string interpolation / verbatim text (@)
        Console.WriteLine("-----------------------------------------");

        var gameChoice = Console.ReadLine(); // variable that holds a READLINE, waiting for user input to continue code
        switch (gameChoice.Trim())
        {
            case "a":
            case "A":
                AdditionGame("Addition Game");
                break;
            case "s":
            case "S":
                SubtractionGame("Subtraction Game");
                break;
            case "m":
            case "M":
                MultiplicationGame("Multiplication Game");
                break;
            case "d":
            case "D":
                DivisionGame("Division Game");
                break;
            case "q":
            case "Q":
                isGameOn = false;
                QuitGame("Goodbye For Now");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    while(isGameOn);
   
}
void QuitGame(string message) // method with a local string variable named message
{
    Console.WriteLine(message);
    
}

void DivisionGame(string message)
{


    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();

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
    Console.WriteLine("Press Enter To Go Back To The Menu");
    Console.ReadLine();
}

void MultiplicationGame(string message)
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
    Console.WriteLine("Press Enter To Go Back To The Menu");
    Console.ReadLine();
}

void SubtractionGame(string message)
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
    Console.WriteLine("Press Enter To Go Back To The Menu");
    Console.ReadLine();
}

void AdditionGame(string message)
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
    Console.WriteLine("Press Enter To Go Back To The Menu");
    Console.ReadLine() ;
}

int[] GetDivisionNumbers()
{
    var random = new Random();

    int firstNumber = random.Next(0, 100);
    int secondNumber = random.Next(0, 100);

    var result = new int[2];


    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(0, 100);
        secondNumber = random.Next(0, 100);

    }

    result[0] = firstNumber; result[1] = secondNumber;



    return result;
}

	