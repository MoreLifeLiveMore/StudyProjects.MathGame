namespace MathGame.Models;

internal class Game
{
    private int _score;

    public int Score
    { 
        get { return _score; } 
        set { _score = value; }
    }

    public DateTime date { get; set; }

    public GameType Gametype { get; set; }

}
internal enum GameType
{
    Addition,
    Subtraction,
    Division,
    Multiplication
}
