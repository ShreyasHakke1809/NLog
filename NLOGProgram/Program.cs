namespace NLOGProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter a first number");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            Addition.SumOfTwoNumbers(firstnum, secondnum);
        }
    }
}