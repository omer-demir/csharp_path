namespace assigment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            int number = int.Parse(input);
            //int number = Convert.ToInt32(input);

            int result = number + number;

            result = result + 10;
            result /= 2; // result = result / 2;

            result -= 4; //  result = result - 4;

            Console.WriteLine($"result is {result}");
        }
    }
}
