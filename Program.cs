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


            //Josh's code to convert Miles to Kilometres
            const double MILES_FACTOR = 1.609344;
            double miles, kilometres;
            string temp;
            Console.Write("Please enter the value to Miles you would like to convert to kilometres ");
            temp = Console.ReadLine();
            miles = Convert.ToDouble(temp);
            kilometres = miles * MILES_FACTOR;
            Console.WriteLine($"The value you entered as miles converted to kilometres is equal to {kilometres:F2}km ");
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
