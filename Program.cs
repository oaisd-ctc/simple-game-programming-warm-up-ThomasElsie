using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        //
        Intro();
        MainGameplay();
    }
    public static void Intro()
    {
        Console.WriteLine("Dice Game");

        Console.WriteLine("\nIn this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck!");

        Console.WriteLine("\nPress any key to start...");
        Console.ReadKey(true);
    }
    public static void MainGameplay()
    {
        int userScore = 0;
        int rivalScore = 0;
        int i = 1;
        while (i <= 10)
        {
            Random rnd = new Random();
            int rivalRoll = rnd.Next(1, 7);

            Random rndo = new Random();
            int userRoll = rndo.Next(1, 7);

            Console.WriteLine("\nRound " + i);
            Console.WriteLine("Rival rolled a " + rivalRoll);
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey(true);
            Console.WriteLine("You rolled a " + userRoll);
            if (rivalRoll > userRoll)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
            }
            else if (rivalRoll < userRoll)
            {
                Console.WriteLine("You won this round.");
                userScore++;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
            i++;
        }
        Console.WriteLine("Game over.");
        Console.WriteLine("The score is now - You : " + userScore + ". Rival : " + rivalScore + ".");
        if (rivalScore > userScore)
        {
            Console.WriteLine("You lost!");
        }
        else if (rivalScore < userScore)
        {
            Console.WriteLine("You won!");
        }
        else
        {
            Console.WriteLine("This game is a draw.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
}