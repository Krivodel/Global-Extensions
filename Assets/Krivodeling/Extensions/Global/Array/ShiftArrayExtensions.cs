namespace Krivodeling.Extensions
{
    public static class ShiftArrayExtensions
    {
        public static T[] ShiftRight<T>(this T[] array)
        {
            if (array.Length == 0)
                return array;

            T last = array[^1];

            for (int i = array.Length - 2; i >= 0; i--)
                array[i + 1] = array[i];

            array[0] = last;

            return array;
        }

        public static T[] ShiftLeft<T>(this T[] array)
        {
            if (array.Length == 0)
                return array;

            T first = array[0];

            for (int i = 1; i < array.Length; i++)
                array[i - 1] = array[i];

            array[^1] = first;

            return array;
        }
    }
}
