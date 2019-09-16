using System;

namespace guessingGameRetry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GUESSING GAME");

            Console.WriteLine("\n Guess a number between 1 and 10. You have 3 turns or the game ends");

            int guessedNumber;

            Console.WriteLine("\n Guess a number ");

            string guessedNumberAsTxt = Console.ReadLine();

            guessedNumber = Convert.ToInt32(guessedNumberAsTxt);

            for (int i = 0; i <2 ; i++)
            {
                if(guessedNumber < 10)
                {
                Console.WriteLine("guess again");

                guessedNumber = Convert.ToInt32 (Console.ReadLine());
                    
                }
              
            }
            if (guessedNumber != 10)
            {
                Console.WriteLine("You ran out of turns");
            }
            if (guessedNumber == 10)
            {
                Console.WriteLine("Lucky guess");
            }


                
                 
                
                        
                    


                
               
        }
    }
}