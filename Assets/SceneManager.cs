using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager i;
    public float clock;

    private void Start()
    {
        i = this;
    }

    private void Update()
    {
        clock += Time.deltaTime;
    }
}
