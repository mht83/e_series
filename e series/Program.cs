namespace e_series
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            return n == 0 ? 1 : n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            decimal sum = 0;
            for (int indexer = 0; indexer <= 33; indexer++)
            {
                sum += 1 / (decimal)Factorial(indexer);
            }
            Console.WriteLine(sum);
            Console.WriteLine(Math.E);
        }

    }
}




