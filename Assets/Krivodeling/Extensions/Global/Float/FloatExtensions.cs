using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class FloatExtensions
    {
        public static void FixNans(this ref float value)
        {
            if (float.IsNaN(value))
                value = 0f;
        }

        public static float TakePercent(this float value, float percent)
        {
            return value / 100f * Mathf.Abs(percent);
        }
    }
}
