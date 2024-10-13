using System.Collections.Generic;

namespace Krivodeling.Extensions
{
    public static class AddListExtensions
    {
        public static bool AddIfNotExist<T>(this List<T> list, T value)
        {
            if (list.Contains(value))
                return false;

            list.Add(value);

            return true;
        }

        public static void AddRangeIfNotExist<T>(this List<T> list, params T[] range)
        {
            for (int i = 0; i < range.Length; i++)
                list.AddIfNotExist(range[i]);
        }
    }
}
