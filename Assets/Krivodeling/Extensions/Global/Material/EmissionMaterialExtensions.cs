using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class EmissionMaterialExtensions
    {
        private static readonly int s_emissiveColorId = Shader.PropertyToID("_EmissiveColor");
        private static readonly Color s_clearColor = Color.clear;

        public static void SetEmission(this Material material, Color color)
        {
            material.SetColor(s_emissiveColorId, color);
        }

        public static void SetEmission(this Material material, Color color, float intensity)
        {
            material.SetEmission(color * intensity);
        }

        public static void DisableEmission(this Material material)
        {
            material.SetEmission(s_clearColor);
        }

        public static Color GetEmissionColor(this Material material)
        {
            return material.GetColor(s_emissiveColorId);
        }
    }
}
