using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class TransformExtensions
    {
        public static void SetPositionAndRotation(this Transform transform, Transform source)
        {
            transform.SetPositionAndRotation(source.position, source.rotation);
        }
    }
}
