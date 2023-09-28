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
                 * I made the menu and the game their own methods to make the switch case more neat*/
                 

                switch (difficulty)
                {
                    case "1":
                        NumbersGame(5,21);
                        break;
                    case "2":
                        NumbersGame(4,31);
                        break;
                    case "3":
                        NumbersGame(3,51);
                        break;
                    case "4": //ends the game
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Tack för att du spelade!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Välj någon av kategorierna ovan."); //asks the player to choose 1-4
                        break;
                }
            }
        }
            //Game menu method with three difficulty options + option to quit the game 
            static void UserMenu()
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

            //Method for the game.
            //Difficulty depends on the value of the ints in the in parameter 
            static void NumbersGame(int numberOfTries, int highestRandom)
            {
                /*calls for the Random class 
                 * and saves a random number between 1 and 20 to int randomNumber */

                Random random = new Random();
                int randomNumber = random.Next(1, highestRandom);
                Console.WriteLine(); //empty line to make it look neat
                Console.WriteLine($"Jag tänker på ett tal mellan 1 och {highestRandom-1}, kan du gissa vilket?");

                /* for loop that makes the game run i(5) times
                * and tells the user how many guesses they have left*/

                for (int i = 1; i <= numberOfTries; i++)
                {
                    Console.WriteLine($"Du har {numberOfTries - (i - 1)} försök kvar.");

                    int userGuess;
                    while (int.TryParse(Console.ReadLine(), out userGuess) == false) //converts users string input to int, if it is possible.
                    {
                        Console.WriteLine("Vänligen skriv ett heltal istället."); //If chosenNum is not an integer, user is asked to try again.
                    }

                    /* If-statement that tells if the user guessed too high or too low
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
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Grattis, du vann!");
                        break;
                    }
                    if (i == numberOfTries)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Game over!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Rätt svar var {randomNumber}.");
                    }
                }
            }
            
        }
    }
