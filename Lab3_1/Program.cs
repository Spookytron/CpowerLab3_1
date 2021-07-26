using System;

namespace Lab3_1
{
    class Program
    {

        static bool KeepGoing()
        {

            
            while (true)
            {
               

                Console.WriteLine("Would you like to try again? (y/n)");

                string response = Console.ReadLine();
                response = response.ToLower();
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "no" || response == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n.");


                }
            }

        }
        static void Main(string[] args)
        {
            string[] names = { "Bill", "Frank", "Ted" };
            string[] food = { "Candy", "Pizza", "Steak" };
            string[] title = { "Workman", "Coolguy", "Intern" };
            do
            {
                Console.WriteLine("Welcome to our DevBuild class! Which student would you like to learn more about? (Enter a number 1-3)");
                int entry = int.Parse(Console.ReadLine());
                if (entry == 1)
                {
                    Console.WriteLine($"{names[entry-1]}");
                    Console.WriteLine("Would you like to know more about this student? y/n");
                    string input = Console.ReadLine();
                    if (input == "y" || input == "Y")
                    {
                        Console.WriteLine("Do you want to know the favorite food (1) or the previous title (2)?");
                        int entry2 = int.Parse(Console.ReadLine());
                        if (entry2 == 1)
                        {
                            Console.WriteLine($"{names[0]} loves {food[0]}.");
                        }
                        else if(entry2==2)
                        {
                            Console.WriteLine($"{names[0]} was formerly a {title[0]}");
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 1 or 2");
                            return false;
                        }

                    }
                }
                else if(entry == 2)
                {
                    Console.WriteLine($"{names[entry-1]}");
                    Console.WriteLine("Would you like to know more about this student? y/n");
                    string input = Console.ReadLine();
                    if (input == "y" || input == "Y")
                    {
                        Console.WriteLine("Do you want to know the favorite food (1) or the previous title (2)?");
                        int entry2 = int.Parse(Console.ReadLine());
                        if (entry2 == 1)
                        {
                            Console.WriteLine($"{names[entry-1]} loves {food[entry-1]}.");
                        }
                        else if(entry2==2)
                        {
                            Console.WriteLine($"{names[entry-1]} was formerly a {title[entry-1]}");
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 1 or 2");
                        }

                    }

                }
                else if(entry==3)
                {
                    Console.WriteLine($"{names[entry - 1]}");
                    Console.WriteLine("Would you like to know more about this student? y/n");
                    string input = Console.ReadLine();
                    if (input == "y" || input == "Y")
                    {
                        Console.WriteLine("Do you want to know the favorite food (1) or the previous title (2)?");
                        int entry2 = int.Parse(Console.ReadLine());
                        if (entry2 == 1)
                        {
                            Console.WriteLine($"{names[entry - 1]} loves {food[entry - 1]}.");
                        }
                        else if(entry2==2)
                        {
                            Console.WriteLine($"{names[entry - 1]} was formerly a {title[entry - 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 1 or 2");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number 1-3");
                }
            }
            while (KeepGoing());   
            

            
        }
    }
}
