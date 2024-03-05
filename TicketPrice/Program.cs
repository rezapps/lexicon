namespace TicketPrice
{
    public class Program
    {
        static void Main()
        {
            // Add color to the console output (welcome message)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to movie theater. Your main menu options are:\n");
            Console.ResetColor();
            
            // make an instance of the Menu class
            Menu menu = new Menu();

            // call menu display method
            menu.Display();
        }
    }

    public class Menu
    {
        private string userInput = " ";

        public void Display()
        {
            // make an instance of the Utils class to use helper methods
            Utils utils = new Utils();

            do
            {
                // Add color to the console output (menu options)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlease choose an option from the menu below:");
                Console.ResetColor();
                Console.WriteLine("#################################################");
                Console.WriteLine("###                                           ###");
                Console.WriteLine("###   0: To exit the program.                 ###");
                Console.WriteLine("###   1: To buy a single ticket.              ###");
                Console.WriteLine("###   2: To buy tickets for a group.          ###");
                Console.WriteLine("###   3: Type a text to see it 10 times       ###");
                Console.WriteLine("###   4: Type a text to see the 3:rd word     ###");
                Console.WriteLine("###                                           ###");
                Console.WriteLine("#################################################");


                // take user input
                userInput = Console.ReadLine() ?? "";

                // switch statment to act on users selected option
                switch (userInput)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the theater. Welcome back!");
                        return;
                    case "1":
                        Console.WriteLine("Please enter your age: ");

                        // getting user age, calculating ticket price,
                        // and displaying ticket price are divided into different
                        // helper methods so that methods are not aware of each others context

                        // call helper method to get user age
                        int age = utils.GetUserAge();

                        // send user age to helper method to calculate ticket price
                        int ticketPrice = utils.CalculateSinglePrice(age);

                        // send ticket price to helper method to display ticket price
                        DisplaySinglePrice(ticketPrice);
                        break;
                    case "2":
                        Console.WriteLine("How many people are in your group? (Please enter a number):");

                        // get group size as string
                        string groupSizeInput = Console.ReadLine() ?? "";

                        // send group size to helper method to get an array of integer ages
                        int[] groupAges = utils.GetGroupAges(groupSizeInput);
                        
                        // send group ages array to helper method to calculate total price
                        int groupPrice = utils.CalculateGroupPrice(groupAges);

                        // send group price to helper method to display group price
                        DisplayGroupPrice(groupAges.Length, groupPrice);
                        break;
                    case "3":
                        // call helper method to display 10 times the text
                        Console.WriteLine("Type a text to see it repeated 10 times: ");
                        string tenx = utils.Display10Times();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\n{tenx}\n");
                        Console.ResetColor();
                        break;
                    case "4":
                        Console.WriteLine("Type a text to see the 3:rd word: ");

                        // call helper method to display 3rd word
                        string thirdWord = utils.Display3rdWord();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\nThird word is: {thirdWord}\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
        }

        // display single ticket price
        private void DisplaySinglePrice(int price)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n###########################################");
            Console.WriteLine($"\tYour total price is: {price} SEK");
            Console.WriteLine("###########################################\n");
            Console.ResetColor();
        }

        // display group ticket price
        private void DisplayGroupPrice(int groupSize, int totalPrice)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n################################################");
            Console.WriteLine($"\tTotal price for {groupSize} people: {totalPrice} SEK");
            Console.WriteLine("################################################\n");
            Console.ResetColor();
        }
    }

    // Utils, helper methods
    public class Utils
    {
        private string userInput = " ";
        // helper method to get user age
        public int GetUserAge()
        {
            // if user input does not parse to integer, keep asking for input
            while (true)
            {
                // take user input and add default value 0
                userInput = Console.ReadLine() ?? "0";
                if (int.TryParse(userInput, out int age))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        
        // helper method to get group ages
        public int[] GetGroupAges(string sizeInput)
        {
            int[] groupAges = new int[0];
            if (int.TryParse(sizeInput, out int groupSize))
            {
                groupAges = new int[groupSize];
            }
            

            for (int i = 0; i < groupSize; i++)
            {
                Console.WriteLine($"Please enter age for person {i + 1}");
                groupAges[i] = GetUserAge();
            }

            return groupAges;
        }

        // helper method to calculate single price
        public int CalculateSinglePrice(int userAge)
        {
            const int AdultPrice = 120;
            const int YoungPrice = 80;
            const int PensionerPrice = 90;
            const int PensionerAge = 64;
            const int YoungAge = 20;

            if (userAge >= PensionerAge)
            {
                return PensionerPrice;
            }
            else if (userAge >= YoungAge)
            {
                return YoungPrice;
            }
            else
            {
                return AdultPrice;
            }
        }

        // helper method to calculate group price
        public int CalculateGroupPrice(int[] groupAges)
        {
            int totalPrice = 0;
            foreach (int age in groupAges)
            {
                totalPrice += CalculateSinglePrice(age);
            }
            return totalPrice;
        }


        // helper method to display 3rd word
        public string Display3rdWord()
        {
            userInput = Console.ReadLine() ?? "";
            string thirdWord = userInput.Split(' ')[2];
            return thirdWord;
        }
        
        // helper method to display a text 10 times
        public string Display10Times()
        {
            userInput = Console.ReadLine() ?? "";
            string tenx = "";
            for (int x = 0; x < 10; x++)
            {
                tenx += x + 1 + ". " + userInput + ", ";
            }

            return tenx;
        }
    }
}
