namespace GuessingGame
{
    internal class Program
    {
        public int lives;
        public int chosenNumber;
        public bool hasWon = false;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.GuessingGameStart();
        }

        void GuessingGameStart()
        {
            lives = 5;

            // Chooses the random number
            int randNum = new Random().Next(0, 25);

            //the game loop
            while (lives > 0)
            {


                Console.WriteLine($"Guess a number between 1 and 25, lives left: {lives}");

                var input = Console.ReadLine();
                try
                {
                    chosenNumber = int.Parse(input);

                    if (chosenNumber == randNum)
                    {
                        Console.WriteLine("You guessed it well done!");
                        hasWon = true;
                        break;
                    }
                    else
                    {
                        if (chosenNumber > randNum)
                        {
                            Console.WriteLine("too big!");
                        }
                        else if (chosenNumber < randNum)
                        {
                            Console.WriteLine("Too small!");
                        }

                        lives--;
                        Console.WriteLine("try Again");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("That is not a valid input!");    
                        
                }
            }
            if (!hasWon) 
            {
                Console.WriteLine("You lost!");
            }
            else
            {
                Console.WriteLine("You won!");
            }

            
        }
    }
}
