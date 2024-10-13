using System;

namespace Krivodeling.Extensions
{
    public static class ForEachArrayExtensions
    {
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            for (int i = 0; i < array.Length; i++)
                action(array[i]);
        }

        public static void ForEach<T>(this T[] array, Func<T, bool> func)
        {
            for (int i = 0; i < array.Length; i++)
                if (!func(array[i]))
                    break;
        }
    }
}
