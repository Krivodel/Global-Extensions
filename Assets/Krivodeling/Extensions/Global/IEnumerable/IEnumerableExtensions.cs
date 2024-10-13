using System;
using System.Collections.Generic;
using System.Linq;

namespace Krivodeling.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> ToMixed<T>(this IEnumerable<T> enumerable)
        {
            T[] array = enumerable.ToArray();

            array.Mix();

            return array;
        }

        public static void ForEach<T>(this IEnumerable<T> array, Action<T> action)
        {
            foreach (T element in array)
                action(element);
        }

        public static void ForEach<T>(this IEnumerable<T> array, Func<T, bool> func)
        {
            foreach (T element in array)
                if (!func(element))
                    break;
        }
    }
}
