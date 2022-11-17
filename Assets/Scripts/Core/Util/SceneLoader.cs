using System;
using UnityEngine.SceneManagement;

namespace LogiBotClone.Runtime.Core.Util
{
    public static class SceneLoader
    {
        public static void Load(string sceneName)
        {
            if (sceneName == null)
            {
                throw new ArgumentException("scene name is empty", nameof(sceneName));
            }

            SceneManager.LoadScene(sceneName);
        }
    }
}