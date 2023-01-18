

namespace DemoProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to new Project C sharp basic programs");
            Console.WriteLine("Please eter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Calculator2 myObj = new Calculator2(first,second);
            myObj.Addition();

            Console.WriteLine("Please enter the first number");
            int first1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second1 = Convert.ToInt32(Console.ReadLine());

            Calculator2 myObj1 = new Calculator2(first1, second1);
            myObj1.Subtraction();

            Console.WriteLine("Please enter the first number");
            int first2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second2 = Convert.ToInt32(Console.ReadLine());

            Calculator2 myObj2 = new Calculator2(first2, second2);
            myObj2.Multiplication();

            Console.WriteLine("Please enter the first numbert");
            int first3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese enter the second number");
            int first4 = Convert.ToInt32(Console.ReadLine());

            Calculator2 myObj3 = new Calculator2(first3, first4);
            myObj3.Dividing();
            Console.ReadLine();
        }
    }
}