using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        MoveInCircle();
    }

    void MoveInCircle()
    {
        Vector3 move = new Vector3(Mathf.Cos(SceneManager.i.clock) * MainCircle.instance.radius, Mathf.Sin(SceneManager.i.clock) * MainCircle.instance.radius);
        transform.position = move;
    }
}
