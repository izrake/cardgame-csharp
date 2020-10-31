using System;
using Test.Helper;
using Test.Mangers;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string playerOne = Console.ReadLine();
            

            Console.WriteLine($"----------------------WELCOME {playerOne} ------------------------------");
            CardGameManager manager = new CardGameManager(playerOne, "computer");
            string exit = string.Empty;
            while(!string.Equals(exit,"exit",StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(@"Please choose one option(Type number)
                                    1. Play
                                    2. Reshuffle
                                    3. Restart
                                    4. Exit
                                    ");
                var userInput = Console.ReadLine();
                try
                {
                    if (string.Equals(userInput, "1", StringComparison.InvariantCultureIgnoreCase))
                    {
                        manager.PlayTurn();
                    }
                    else if (string.Equals(userInput, "2", StringComparison.InvariantCultureIgnoreCase))
                    {
                        manager.ReShuffle();
                    }
                    else if (string.Equals(userInput, "3", StringComparison.InvariantCultureIgnoreCase))
                    {
                        manager.ReShuffle();
                    }
                    else
                    {
                        Console.WriteLine(@"Please choose valid option(Type number)
                                    1. Play
                                    2. Reshuffle
                                    3. Restart
                                    4. Exit
                                    ");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Restarting game");
                    manager = new CardGameManager(playerOne, "computer");

                }
            }


            Console.WriteLine($"----------------------Thank you for playing {playerOne} ------------------------------");

        }
    }
}
