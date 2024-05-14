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
        }
    }
    }
}
