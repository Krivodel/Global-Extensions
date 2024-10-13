using System.Collections.Generic;
using System.Linq;

namespace Krivodeling.Extensions
{
    public static class ArrayExtensions
    {
        public static T[] RemoveDuplicates<T>(this T[] array)
        {
            List<T> result = new();

            for (int i = 0; i < array.Length; i++)
            {
                T t = array[i];

                if (!result.Contains(t))
                    result.Add(t);
            }

            return result.ToArray();
        }

        public static T[][] Split<T>(this T[] array, int fragmentSize)
        {
            int fragmentCount = array.Length / fragmentSize;
            T[][] newArray = new T[fragmentCount][];

            for (int i = 0; i < fragmentCount; i++)
                newArray[i] = array.Skip(i * fragmentSize).Take(fragmentSize).ToArray();

            return newArray;
        }

        public static T GetNextAfter<T>(this T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    if (i < array.Length - 1)
                        return array[i + 1];

                    return array[0];
                }
            }

            return default;
        }

        public static T GetPreviousAfter<T>(this T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    if (i == 0)
                        return array[^1];

                    return array[i - 1];
                }
            }

            return default;
        }
    }
}
