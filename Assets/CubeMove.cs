using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    float clock = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        transform.position += new Vector3(Mathf.Cos(clock) * MainCircle.instance.radius, 0, 0);
    }
}
