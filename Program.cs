using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int Score = 0;
        int Round = 1;
        int boolPlayerGuess = 0;
        Random Hidden = new Random();

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string Name = Console.ReadLine();

        Console.WriteLine("Welcome " + Name + " Do you want to do the COIN FLIP CHALLENGE? Yes/No");

        string Response = Console.ReadLine();

        if (Response == "Yes")
        {
            
            while (Round <= 5)
            {
                Console.WriteLine("Heads or Tails?");
                string playerGuess = Console.ReadLine();
                int coin = Hidden.Next(1, 3);

                if (playerGuess == "Heads")
                {
                    boolPlayerGuess = 1;
                  
                }
                else
                {
                    boolPlayerGuess = 0;
                }

                if ( boolPlayerGuess == (coin % 2 ) )
                {
                    Console.WriteLine("That is Correct!");
                    Round += 1;
                    Score += 1;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not correct");
                    Round += 1;
                }

                Console.WriteLine( "Score " + Score );
            }

            Console.WriteLine("Thank you " + Name + ". You got a score of " + Score + "!");
        }
        else
        {
            Console.WriteLine("You are a coward " + Name);
            Round = 6;
        }
    }
}