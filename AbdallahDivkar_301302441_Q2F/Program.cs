namespace AbdallahDivkar_301302441_Q2F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double petrolPrice;
            string petrolType;

            Console.Write("Enter the price of petrol : $");
            petrolPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter type: ");
            petrolType = Console.ReadLine();

            Console.WriteLine($"The cost of 25 litres of {petrolType} grade petrol will be ${petrolPrice * 25:F2} ");
            Console.ReadLine();
        }
    }
}

//12 Marks
