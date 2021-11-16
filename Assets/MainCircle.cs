using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircle : MonoBehaviour
{
    public static MainCircle instance;

    public int trigFunction;
    public float amplitude;
    public float radius;
    public int angleCoefficient;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        switch (trigFunction)
        {
            case 0:
                radius = amplitude * Mathf.Sin(angleCoefficient * SceneManager.i.clock);
                break;
            case 1:
                radius = amplitude * Mathf.Cos(angleCoefficient * SceneManager.i.clock);
                break;
        }

    }
}
