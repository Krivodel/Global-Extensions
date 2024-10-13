using System.Collections.Generic;

namespace Krivodeling.Extensions
{
    public static class RingListExtensions
    {
        public static IEnumerable<T> Ring<T>(this IList<T> items, int skip, int take)
        {
            bool reverse = take < 0;
            int count = items.Count;

            skip = skip < 0 ? count + skip : skip;
            skip = skip < count ? skip : skip % count;
            take = reverse ? -take : take;

            for (int i = 0; i < take; i++)
            {
                int j = i < count ? i : i % count;
                int index = reverse ? skip - j : skip + j;

                index = index < 0 ? count + index : index;
                index = index < count ? index : index % count;

                yield return items[index];
            }
        }

        public static IEnumerable<T> Ring<T>(this IList<T> items, int skip)
        {
            return Ring(items, skip, items.Count);
        }
    }
}
