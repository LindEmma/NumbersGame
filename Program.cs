//Emma Lind, Edugrade .NET23
namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop that outputs a menu as long as the user don't press "4"

            string difficulty = "";

            while (difficulty != "4")
            {
                UserMenu();

                difficulty = Console.ReadLine();

                /* switch case that lets user choose from the menu
                 * and makes a clear overview of the flow 
                 * I made the menu and games their own methods to make the switch case more neat*/

                switch (difficulty)
                {
                    case "1":
                        NumbersGame1();
                        break;
                    case "2":
                        NumbersGame2();
                        break;
                    case "3":
                        NumbersGame3();
                        break;
                    case "4": //ends the game
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Tack för att du spelade!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Välj någon av kategorierna ovan."); //asks the player to choose 1-4
                        Console.ReadKey();
                        break;
                }
            }

            //Game menu method with three difficulty options + option to quit the game 
            void UserMenu()
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue; //Makes the title a blue colour
                Console.WriteLine("******NUMBERS GAME******");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Välj en svårighetsgrad: ");
                Console.WriteLine();
                Console.WriteLine("(1) Lätt");
                Console.WriteLine("(2) Mellan");
                Console.WriteLine("(3) Svår");

                Console.WriteLine("(4) Avsluta spelet");
                Console.WriteLine();
            }

            //Method for easy mode (1), random number between 1-20, 5 tries. 
            void NumbersGame1()
            {
                /*calls for the Random class 
                 * and saves a random number between 1 and 20 to int randomNumber */
                Random random = new Random();
                int randomNumber = random.Next(1, 21);
                Console.WriteLine(); //empty line to make it look neat
                Console.WriteLine("Jag tänker på ett tal mellan 1-20, kan du gissa vilket?");

                /* for loop that makes the game run i(5) times
                * and tells the user how many guesses they have left*/
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Du har {5 - (i - 1)} försök kvar.");

                    int userGuess;
                    while (int.TryParse(Console.ReadLine(), out userGuess) == false) //converts users string input to int, if it is possible.
                    {
                        Console.WriteLine("Vänligen skriv ett heltal istället."); //If chosenNum is not an integer, user is asked to try again.
                    }

                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("För högt!");
                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Grattis, du vann!");
                        break;
                    }
                    if (i == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Game over!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Rätt svar var {randomNumber}.");
                    }
                }
            }

            // method for medium mode(2), random number between 1-30, 4 tries.
            void NumbersGame2()
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 31);
                Console.WriteLine("Jag tänker på ett tal mellan 1-30, kan du gissa vilket?");

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Du har {4 - (i - 1)} försök kvar.");

                    int userGuess;
                    while (int.TryParse(Console.ReadLine(), out userGuess) == false) //converts users string input to int, if it is possible.
                    {
                        Console.WriteLine("Vänligen skriv ett heltal istället."); //If chosenNum is not an integer, user is asked to try again.
                    }

                    /* If-statement that says if the user guessed too high or too low
                     * If user guessed correctly loop ends and user win.
                     * If all five rounds are up, user gets a "game over"*/

                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("För högt!");

                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    else
                    {
                        Console.WriteLine("Grattis, du vann!");
                        break;
                    }
                    if (i == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Game over!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Rätt svar var {randomNumber}.");
                        break;
                    }
                }
            }

            // method for hard mode(3): random number between 1-50, 3 tries.
            void NumbersGame3()
            {
                //Same code as NumberGame1 except differences in some numbers 
                Random random = new Random();
                int randomNumber = random.Next(1, 51);
                Console.WriteLine("Jag tänker på ett tal mellan 1-50, kan du gissa vilket?");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Du har {3 - (i - 1)} försök kvar.");

                    int userGuess;
                    while (int.TryParse(Console.ReadLine(), out userGuess) == false) 
                    {
                        Console.WriteLine("Vänligen skriv ett heltal istället.");
                    }

                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("För högt!");

                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    else
                    {
                        Console.WriteLine("Grattis, du vann!");
                        break;
                    }
                    if (i == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Game over!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Rätt svar var {randomNumber}.");
                    }
                }
            }
        }
    }
}
