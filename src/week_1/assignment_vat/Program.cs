namespace assignment_vat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a price:");

            string input = Console.ReadLine();
            double number = double.Parse(input);
            
            const double vatValue = 0.21;

            double calculatedVat = number * vatValue;

            double total = calculatedVat + number;

            Console.WriteLine($"price:{number}, vat:{calculatedVat}, total:{total}");



        }
    }
}
