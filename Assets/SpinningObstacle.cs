using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    public float rotSpeed=1;
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up,rotSpeed);
    }
}
