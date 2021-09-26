using System;
namespace interpolateApp
{
    public class Interpolation
    {
        public static double Interpolate(double[,] f, double z)
        {
            for (int i = 1; i <= f.GetUpperBound(0); i++)
            {

                if (z < f[i, 0] && z > f[i-1, 0]) return LinearApproximation(f[i - 1, 0], f[i, 0], f[i - 1, 1], f[i, 1], z);
                
            }
            throw new ArgumentException("z is not in (min(x), max(x)");
        }

        private static double LinearApproximation(double x1, double x2, double y1, double y2, double x)
        {
            double slope = (y2 - y1) / (x2 - x1);
            return y1 + slope * (x - x1);
        }
    }
}
