using System.ComponentModel.Design;

namespace Topic_5._2_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice, name;
            int temp, age;

            Console.WriteLine("Welcome to this short quiz:");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 1: Can a computer crash?");
            Console.WriteLine();
            Console.WriteLine("A: I dont know         " + "B: Yes");
            Console.WriteLine("C: I will have to find out   " + "D: No");
            Console.WriteLine();
            Console.Write("Your answer? ");
            choice = Console.ReadLine();
            Console.WriteLine();
            if (choice == "A")
            {
                Console.WriteLine("I dont know doesn't know if it's right");
            }
            else if (choice == "B")
            {
                Console.WriteLine("You are correct!");
            }
            else if (choice == "C")
            {
                Console.WriteLine("It's best not to find out on a personal computer, fyi. :)");
            }
            else if (choice == "D")
            {
                Console.WriteLine("Nothing funny here, you just got it wrong.");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();
            //End of Task 1

            //Task 2 Below here

            Console.Write("Please enter the temperature of water: ");
            Console.WriteLine();
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                if (temp <= 0)
                    Console.WriteLine("You have a solid!");
                else if (temp <= 100)
                    Console.WriteLine("You have a liquid");
                else
                    Console.WriteLine("You have a gas!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.ReadLine();
            Console.Clear();
            //End of Task 2

            //Start of Task 3
            Console.Write("Hey, what's your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Okay " + name + ", " + "How old are you? ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine();
                if (age <= 0)
                {
                    Console.WriteLine("I didn't know things that arent born yet could use computers");
                }
                else if (age <= 16)
                {
                    Console.WriteLine("You can't drive.");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("You can't vote.");
                }
                else if (age <= 25)
                {
                    Console.WriteLine("You can't rent a car.");
                }
                else
                {
                    Console.WriteLine("You can do anything that is legal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Numeric Input");
            }
        }
    }
}
