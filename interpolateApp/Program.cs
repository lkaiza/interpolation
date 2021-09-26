using System;


namespace interpolateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] f = new double[,] { { 1, 2 }, { 3, -1 }, { 5, 6 }, { 7, 8 } };
            Console.WriteLine("Enter value from (1,7):");
            double z = double.Parse(Console.ReadLine());
            try
            {
                double res = Interpolation.Interpolate(f, z);
                Console.WriteLine($"f(z) = {res}");
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(value: err.Message);
            }
        }
    }
}
