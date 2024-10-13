using UnityEngine;

namespace Krivodeling.Extensions
{
    public static class AudioSourceExtensions
    {
        public static void Toggle(this AudioSource audioSource)
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
            else
                audioSource.Play();
        }
    }
}
