using System.Collections.Generic;
using System.Linq;
using SystemRandom = System.Random;
using UnityRandom = UnityEngine.Random;

namespace Krivodeling.Extensions
{
    public static class MixListExtensions
    {
        public static void Mix<T>(this List<T> list, SystemRandom random = null)
        {
            for (int i = list.Count - 1; i > 2; i--)
            {
                int j;

                if (random == null)
                    j = UnityRandom.Range(0, i + 1);
                else
                    j = random.Next(0, i + 1);

                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        public static void Mix<T>(this List<T> list, int[] except, SystemRandom random = null)
        {
            for (int i = list.Count - 1; i > 2; i--)
            {
                int j;

                if (random == null)
                    j = UnityRandom.Range(0, i + 1);
                else
                    j = random.Next(0, i + 1);

                bool hasExcept = false;

                for (int q = 0; q < except.Length; q++)
                {
                    if (i == except[q] || j == except[q])
                    {
                        hasExcept = true;

                        break;
                    }
                }

                if (hasExcept)
                    continue;

                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        public static List<T> ToMixed<T>(this List<T> list)
        {
            List<T> mixedList = list.ToList();

            mixedList.Mix();

            return mixedList;
        }
    }
}
