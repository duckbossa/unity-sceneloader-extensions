# unity-sceneloader-extensions

A simple collection of static methods that allow you to un/load multiple scenes in order and in parallel.


# Sample Usage

``` csharp
using System;
using UnityEngine;

// add this namespace to use the static methods.

public class SampleUsage : MonoBehaviour
{
    private void Awake()
    {
        // all SceneLoader static methods return an IEnumerator.
        StartCoroutine(SceneLoader.LoadScenesSequentially(
            "SoundContainer",
            "ObjectPool",
            "Environment",
            "LevelUI"
            ));
    }

    private IEnumerator UnloadMainGame()
    {
        Debug.Log("Unload Scenes");
        yield return SceneLoader.UnloadScenesSequentially(
            "SoundContainer",
            "ObjectPool",
            "Environment",
            "LevelUI"
        );

        yield return SceneLoader.LoadScenesSequentially(
            "MainMenuUI",
            "OtherScene1",
            "OtherScene2"
        );

    }
}
```

An example can be found in the Unity Project(`Assets/Samples/Scenes/main`).



