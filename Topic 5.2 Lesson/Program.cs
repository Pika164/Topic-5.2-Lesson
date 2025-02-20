namespace Topic_5._2_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("Welcome to this short quiz:");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.WriteLine();
            Console.WriteLine("Question 1: Can a computer crash?");
            Console.WriteLine();
            Console.WriteLine("A: I dont know         " + "B: Yes");
            Console.WriteLine("C: I will have to find out   " + "D: No");
            if (choice == "A")
            {
                Console.WriteLine("I dont know doesnt cut it bud");
            }
            else if (choice == "B")
            {
                Console.WriteLine("You are correct!");
            }
        }
    }
}
