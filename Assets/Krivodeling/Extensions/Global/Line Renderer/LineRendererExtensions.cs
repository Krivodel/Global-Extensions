using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class LineRendererExtensions
    {
        public static Vector3[] GetAllPositions(this LineRenderer lineRenderer)
        {
            int count = lineRenderer.positionCount;
            Vector3[] positions = new Vector3[count];

            for (int i = 0; i < count; i++)
                positions[i] = lineRenderer.GetPosition(i);

            return positions;
        }
    }
}
