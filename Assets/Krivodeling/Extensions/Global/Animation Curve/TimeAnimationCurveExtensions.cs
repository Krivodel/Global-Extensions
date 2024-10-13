using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class TimeAnimationCurveExtensions
    {
        public static float GetMinTime(this AnimationCurve curve)
        {
            return curve.keys[0].time;
        }

        public static float GetMaxTime(this AnimationCurve curve)
        {
            return curve.keys[^1].time;
        }
    }
}
