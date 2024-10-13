using System.Linq;
using SystemRandom = System.Random;
using UnityRandom = UnityEngine.Random;

namespace Krivodeling.Extensions
{
    public static class MixArrayExtensions
    {
        public static void Mix<T>(this T[] array, SystemRandom random = null)
        {
            for (int i = array.Length - 1; i > -1; i--)
            {
                int j;

                if (random == null)
                    j = UnityRandom.Range(0, i + 1);
                else
                    j = random.Next(0, i + 1);

                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        public static T[] ToMixed<T>(this T[] array)
        {
            T[] mixedArray = array.ToArray();

            mixedArray.Mix();

            return mixedArray;
        }
    }
}
