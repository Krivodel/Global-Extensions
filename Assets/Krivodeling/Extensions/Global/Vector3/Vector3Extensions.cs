using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class Vector3Extensions
    {
        public static void FixNans(this ref Vector3 vector)
        {
            if (float.IsNaN(vector.x))
                vector.x = 0f;

            if (float.IsNaN(vector.y))
                vector.y = 0f;

            if (float.IsNaN(vector.z))
                vector.z = 0f;
        }
    }
}
