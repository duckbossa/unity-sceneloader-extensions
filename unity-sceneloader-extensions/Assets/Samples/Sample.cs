using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;

public class Sample : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(SceneLoader.LoadScenesSequentially("SampleScene1", "SampleScene2"));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(SceneLoader.LoadScenesInParallel("SampleScene1", "SampleScene2"));
            
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(SceneLoader.UnloadScenesSequentially("SampleScene1", "SampleScene2"));

        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(SceneLoader.UnloadScenesInParallel("SampleScene1", "SampleScene2"));
        }
    }
}
