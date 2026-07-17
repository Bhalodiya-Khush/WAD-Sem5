using System;
namespace Program2
{
    class numberGame
    {
        static void Main(String[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            random.Next(0, 101);
            int attempt = 0;

            while (true)
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                int userGuess = int.Parse(Console.ReadLine());
                attempt++;

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Number is too low, try again");
                }
                else if(userGuess > randomNumber)
                {
                    Console.WriteLine("Number is too high, try again");
                }
                else
                {
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {attempt} attempts.");
                        break;
                    }
                }
            }
        }
    }
}