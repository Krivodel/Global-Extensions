using System.Collections.Generic;
using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class ListExtensions
    {
        public static T GetRandomElement<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }

        public static List<T> ToWithoutDuplicates<T>(this List<T> list)
        {
            List<T> result = new();

            for (int i = 0; i < list.Count; i++)
            {
                T t = list[i];

                if (!result.Contains(t))
                    result.Add(t);
            }

            return result;
        }

        public static void ClearDublicates<T>(this List<T> list)
        {
            List<T> tempList = new(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                T element = list[i];

                if (tempList.Contains(element))
                    list.Remove(element);
                else
                    tempList.Add(element);
            }
        }

        public static void DublicateElements<T>(this List<T> list, int dublicateCount)
        {
            int count = list.Count;

            for (int i = 0; i < dublicateCount; i++)
                for (int j = 0; j < count; j++)
                    list.Add(list[j]);
        }
    }
}
