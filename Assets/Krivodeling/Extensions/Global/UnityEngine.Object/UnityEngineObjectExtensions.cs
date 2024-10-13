using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Krivodeling.Extensions
{
    public static class UnityEngineObjectExtensions
    {
        public static List<T> FindObjectsByInterface<T>(this Object obj, bool includeInactive = false) where T : class
        {
            List<T> list = new();
            GameObject[] rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();

            for (int i = 0; i < rootObjects.Length; i++)
                list.AddRange(rootObjects[i].GetComponentsInChildren<T>(includeInactive));

            return list;
        }

        public static T FindAnyObjectByInterface<T>(this Object obj) where T : class
        {
            GameObject[] rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();
            T component;

            for (int i = 0; i < rootObjects.Length; i++)
            {
                component = rootObjects[i].GetComponentInChildren<T>();

                if (component != null)
                    return component;
            }

            return default;
        }
    }
}
