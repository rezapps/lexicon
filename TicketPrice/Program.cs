namespace TicketPrice
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWelcome to movie theatre. Your main menu options are:\n");
            Console.ResetColor();

            Menu menu = new Menu();
            menu.Display();
        }
    }

    public class Menu
    {
        private string userInput;

        public void Display()
        {
            Utils utils = new Utils();

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlease chose an option from the menu below:");
                Console.ResetColor();
                Console.WriteLine("###########################################");
                Console.WriteLine("###                                     ###");
                Console.WriteLine("###   0: To exit the program.           ###");
                Console.WriteLine("###   1: To buy a single ticket.        ###");
                Console.WriteLine("###   2: To buy tickets for a group.    ###");
                Console.WriteLine("###                                     ###");
                Console.WriteLine("###########################################");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the theatre. Welcome Back!");
                        return;
                    case "1":
                        Console.WriteLine("Please Enter Your Age: ");
                        int age = utils.GetAgeInput();
                        int price = utils.CalculateTicketPrice(age);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n###########################################");
                        Console.WriteLine($"\tYour total price is: {price} SEK");
                        Console.WriteLine("###########################################\n");
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.WriteLine("Enter the ages of all members, separated by commas (e.g., 25, 30, 68):");
                        string agesInput = Console.ReadLine() ?? "";
                        int[] groupAges = utils.ParseAgesInput(agesInput);
                        int totalPrice = utils.CalculateGroupPrice(groupAges);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n####################################");
                        Console.WriteLine($"\tYour total price is: {totalPrice} SEK");
                        Console.WriteLine("####################################\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
        }
    }

    public class Utils
    {
        public int GetAgeInput()
        {
            while (true)
            {
                string userInput = Console.ReadLine() ?? "0";
                int age;
                if (int.TryParse(userInput, out age))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        public int[] ParseAgesInput(string agesInput)
        {
            string[] stringAges = agesInput.Split(',');
            int[] ages = new int[stringAges.Length];

            for (int i = 0; i < stringAges.Length; i++)
            {
                int.TryParse(stringAges[i].Trim(), out ages[i]);
            }

            return ages;
        }

        public int CalculateTicketPrice(int userAge)
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

        public int CalculateGroupPrice(int[] groupAges)
        {
            int totalPrice = 0;
            foreach (int age in groupAges)
            {
                totalPrice += CalculateTicketPrice(age);
            }
            return totalPrice;
        }
    }
}