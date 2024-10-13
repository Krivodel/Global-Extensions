namespace Krivodeling.Extensions
{
    public static class TakeArrayExtensions
    {
        public static T[] Take<T>(this T[] array, int startIndex, int count)
        {
            T[] takedElements = new T[count];

            for (int i = startIndex, j = 0; j < count; i++, j++)
                takedElements[j] = array[i];
            
            return takedElements;
        }

        public static T[] Take<T>(this T[] array, int count)
        {
            return array.Take(0, count);
        }
    }
}
