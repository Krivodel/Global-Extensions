using System.Linq;
using UnityRandom = UnityEngine.Random;
using SystemRandom = System.Random;
using System;

namespace Krivodeling.Extensions
{
    public static class RandomElementArrayExtensions
    {
        public static T GetRandomElement<T>(this T[] array, bool throwIfEmpty = true, SystemRandom random = null)
        {
            if (array.Length == 0)
            {
                if (throwIfEmpty)
                    throw new ArgumentException("Array length must be greater than 0.");
                else
                    return default;
            }

            int index;

            if (random == null)
                index = UnityRandom.Range(0, array.Length);
            else
                index = random.Next(0, array.Length);

            return array[index];
        }

        public static T[] GetRandomElementsWithoutDublicates<T>(this T[] array, int count, bool throwIfEmpty = true, SystemRandom random = null)
        {
            T[] elements = new T[count];

            for (int i = 0; i < count; i++)
            {
                T newElement;

                do
                {
                    newElement = array.GetRandomElement(throwIfEmpty, random);
                }
                while (elements.Contains(newElement));

                elements[i] = newElement;
            }

            return elements;
        }
    }
}
