using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneManagerExtensions
{
    public static class SceneLoader
    {
        /// <summary>
        /// Loads scenes according to the order specified by the strings provided in the parameter.
        /// All scenes will be loaded as additive.
        /// </summary>
        /// <param name="sceneNames">Scene names to be loaded.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IEnumerator LoadScenesSequentially(params string[] sceneNames)
        {
            if (sceneNames.Length <= 0) throw new ArgumentOutOfRangeException();
            for (int i = 0; i < sceneNames.Length; i++)
            {
                yield return SceneManager.LoadSceneAsync(sceneNames[i], LoadSceneMode.Additive);
            }
        }

        /// <summary>
        /// Load scenes in parallel to one another. All scenes will be loaded as additive.
        /// </summary>
        /// <param name="sceneNames">Scene names to be loaded.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IEnumerator LoadScenesInParallel(params string[] sceneNames)
        {
            if (sceneNames.Length <= 0) throw new ArgumentOutOfRangeException();
            AsyncOperation[] sceneToLoad = new AsyncOperation[sceneNames.Length];
            
            for (int i = 0; i < sceneToLoad.Length; i++)
            {
                sceneToLoad[i] = SceneManager.LoadSceneAsync(sceneNames[i], LoadSceneMode.Additive);
            }

            for (int i = 0; i < sceneToLoad.Length; i++)
            {
                yield return sceneToLoad[i];
            }
        }
    }
}