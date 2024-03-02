using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter activity number (1-5) or '0' to exit:");
            string input = Console.ReadLine();
            int activityNumber;

            if (!int.TryParse(input, out activityNumber) || activityNumber < 0 || activityNumber > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 5.");
                continue;
            }

            switch (activityNumber)
            {
                case 0:
                    Console.WriteLine("Exiting program...");
                    return;
                case 1:
                    Activity1();
                    break;
                case 2:
                    Activity2();
                    break;
                case 3:
                    Activity3();
                    break;
                case 4:
                    Activity4();
                    break;
                case 5:
                    Activity5();
                    break;
                default:
                    Console.WriteLine("Activity does not exist.");
                    break;
            }
        }
    }

    static void Activity1()
    {
        Console.WriteLine("Enter a Philippine bank note/coin denomination (1, 5, 10, 20, 50, 100, 200, 500, 1000): ");
        double denomination = 0;

        if (double.TryParse(Console.ReadLine(), out denomination))
        {
            switch (denomination)
            {
                case 0.01:
                case 0.05:
                case 0.25:
                    Console.WriteLine("No Person is found on this denomination.");
                    break;
                case 1:
                    Console.WriteLine("Jose Rizal is found in the Php. 1");
                    break;
                case 5:
                    Console.WriteLine("Emilio Aguinaldo is found in the Php. 5");
                    break;
                case 10:
                    Console.WriteLine("Andres Bonifacio, and Apolinario Mabini is found in the Php. 10");
                    break;
                case 20:
                    Console.WriteLine("Manuel L. Quezon is found in the Php. 20");
                    break;
                case 50:
                    Console.WriteLine("Sergio Osmena is found in the Php. 50");
                    break;
                case 100:
                    Console.WriteLine("Manuel Roxas is found in the Php. 100");
                    break;
                case 200:
                    Console.WriteLine("Diosdado Macapagal is found in the Php. 200");
                    break;
                case 500:
                    Console.WriteLine("Benigno Sr. and Corazon Aquino is found in the Php. 500");
                    break;
                case 1000:
                    Console.WriteLine("Jose Abad Santos, Vicente Lim, and Josefa Llanes Escoda is found in the Php. 1000");
                    break;
                default:
                    Console.WriteLine("Invalid Denomination: {0}", denomination);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void Activity2()
    {
        Console.WriteLine("Enter the value of X:");
        int X;
        
        if (!int.TryParse(Console.ReadLine(), out X) || X <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for X.");
            return;
        }

        for (int i = 1; i <= X; i++)
        {
            string output = i.ToString();

            if (i % 3 == 0 && i % 5 == 0)
            {
                output += " - FooBar";
            }
            else if (i % 3 == 0)
            {
                output += " - Foo";
            }
            else if (i % 5 == 0)
            {
                output += " - Bar";
            }

            Console.WriteLine(output);
        }
    }

    static void Activity3()
    {
        string input = "";
        string output = "";

        do
        {
            Console.WriteLine("Enter something:");
            input = Console.ReadLine();
            if (input != "exit")
            {
                output += input + " ";
                Console.WriteLine(output);
            }
        } while (input != "exit");

        Console.WriteLine($"Closing program...");
    }

    static void Activity4()
    {
        int n;

        do
        {
            Console.Write("Enter a value that would show * based on the amount you desire. (enter 0 to exit): ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                continue;
            }
            if (n == 0)
            {
                Console.WriteLine("Closing Program...");
                return;
            }

            PrintTriangle(n);

        } while (true);
    }

    static void PrintTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("  ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void Activity5()
    {
        int sum = 0;
        string message = "";

        Console.WriteLine("Enter something:");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                sum += number;
                Console.WriteLine($"Adding {number} to {sum - number} = {sum}");
            }
            else
            {
                message += input;
                Console.WriteLine($"Current Message: {message}");
            }
        }
    }
}

