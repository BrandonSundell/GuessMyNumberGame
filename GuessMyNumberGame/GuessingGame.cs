using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumberGame
{
    class GuessingGame
    {
        public static Random rand = new Random();

        public static void ComputerGuess()
        {
            Console.WriteLine("You're going to pick a number between 1 and 100! I'll try to guess what it is!");
            Console.WriteLine("You'll let you know if my guess is to high or to low until I guess it!");
            Console.WriteLine("Press Enter and I'll start guessing!");
            Console.ReadLine();

            bool right = false;
            int min = 1;
            int max = 100;
            int comGuess = 0;
            int timesGuessed = 0;
            string userRespone = "";

            while(right == false)
            {
                comGuess = rand.Next(min, max + 1);
                Console.WriteLine($"Is your number {comGuess}? Yes[Y] To low[L] To high[H]");
                userRespone = Console.ReadLine().ToLower();
                while( userRespone != "y" && userRespone != "l" && userRespone != "h")
                {
                    Console.WriteLine("Error: Not a valid answer. Try again");
                    userRespone = Console.ReadLine().ToLower();
                }

                if(userRespone == "y")
                {
                    right = true;
                }
                if(userRespone == "l")
                {
                    min = comGuess + 1;
                }
                if(userRespone == "h")
                {
                    max = comGuess - 1;
                }
                timesGuessed++;
            }
            Console.WriteLine($"I finaly guessed your number {comGuess}! It took me {timesGuessed} times to get it right.");

        }
        public static void PlayerGuess()
        {
            int comNum = rand.Next(1, 1001);
            Console.WriteLine("I'm going to pick a number between 1 and 1000! Try to guess what it is!");
            Console.WriteLine("I'll let you know if your guess is to high or to low until you guess it!");
            Console.WriteLine("Start guessing!");
            int userGuess = Int32.Parse(Console.ReadLine());

            while(userGuess != comNum)
            {
                if(comNum > userGuess)
                {
                    Console.WriteLine("Your guess is to low. Try again.");
                    userGuess = Int32.Parse(Console.ReadLine());
                }
                if(comNum < userGuess)
                {
                    Console.WriteLine("Your guess is to high. Try again.");
                    userGuess = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Hey you got it right! Nice job! Thanks for playing!");
        }
    }
}
