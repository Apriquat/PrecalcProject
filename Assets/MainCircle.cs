using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircle : MonoBehaviour
{
    public static MainCircle instance;

    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
