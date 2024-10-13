using System;

namespace Krivodeling.Extensions
{
    public static class SystemRandomExtensions
    {
        public static float NextFloat(this Random random, float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}
