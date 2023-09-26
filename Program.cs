//Emma Lind, Edugrade .NET23
namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string difficulty = "";

            while (difficulty != "4")
            {
                UserMenu();

                difficulty = Console.ReadLine();

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
                    case "4":
                        Console.WriteLine("Tack för att du spelade!");
                        break;
                    default:
                        Console.WriteLine("Välj någon av kategorierna ovan.");
                        break;
                }
            }

            //Game menu with different options for difficulty and an option to quit the game. 
            void UserMenu()
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue; //Makes the title a cyan colour
                Console.WriteLine("******NUMBERS GAME******");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("(1) Lätt");
                Console.WriteLine("(2) Mellan");
                Console.WriteLine("(3) Svår");
                Console.WriteLine("(4) Avsluta spelet");
                Console.WriteLine();
                Console.Write("Välj en svårighetsgrad: ");
            }

            //Numbers game easy, random number between 1-20, 5 tries. 
            void NumbersGame1()
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 21);
                Console.WriteLine();
                Console.WriteLine("Jag tänker på ett tal mellan 1-20, kan du gissa vilket?");

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

            //Difficulty medium, random number between 1-30, 4 tries.
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

            //Difficulty hard: random number between 1-50, 3 tries.
            void NumbersGame3()
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 51);
                Console.WriteLine("Jag tänker på ett tal mellan 1-50, kan du gissa vilket?");

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Du har {3 - (i - 1)} försök kvar.");

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
