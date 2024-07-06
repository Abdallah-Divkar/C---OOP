namespace AbdallahDivkar_301302441_Q3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1;

            Console.Write("Enter a letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"The number {(decimal)letter1:F1} is equivalent to the letter {letter1}");

            Console.ReadLine();
        }
    }
}

//6 marks

