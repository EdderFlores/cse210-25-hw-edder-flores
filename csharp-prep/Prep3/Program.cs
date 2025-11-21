using System;

class Program
{
    private static Random random = new Random(); 
    static void Main(string[] args)
    {
        string playAgain;
        
        do
        {
            int guess = 0;
            int randomNumber = random.Next(1, 150); 
            int attemptsCounter = 0;
            
            Console.WriteLine("Welcome to the Magic Number Guess Game");
            Console.WriteLine();
            Console.WriteLine("You need to enter a number and I will tell you if you are High or Low near to the number");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter Your Guess: ");
                guess = int.Parse(Console.ReadLine());
                attemptsCounter++;

                if (guess < randomNumber)
                {
                    Console.WriteLine("No, it is Higher");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("No, it is Lower");
                }
                else
                {
                    Console.WriteLine("Congratulations, you got it right!");
                    Console.WriteLine($"It took you {attemptsCounter} attempts to guess the number");
                    break;
                }
            }
            
            Console.WriteLine();
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();
            
        } while (playAgain == "yes" || playAgain == "y");
        
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}