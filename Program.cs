namespace PracticeRepoWithTheATeam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("GOOOOOOOOD MOOOORNING VIETNAM!");
            Console.WriteLine("Hello, my name is Josh");
            Console.Write("Hello World 2 Electric Boogaloo!");
            Console.ReadLine();
            //this is a calculator that workds out the modular division of 2 numbers!
            int num1, num2, answer;
            num1 = 0;
            while (num1 != 999)
            {
                Console.WriteLine("Please enter your first number!");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your second number!");
                num2 = Convert.ToInt32(Console.ReadLine());
                answer = num1 % num2;
                if (answer < 0)
                {
                    answer = answer + num2;
                }
                Console.WriteLine($"\n Your answer was {answer}");
            }
        }
    }
}
