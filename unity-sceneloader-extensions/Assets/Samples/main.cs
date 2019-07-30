using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneManagerExtensions;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneLoader.LoadScenesSequentially("SampleScene1", "SampleScene2"));
    }
}
