using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public Transform[] Waypoints;
    public float moveSpeed;
    private int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Waypoints[0].position;
        currentIndex++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position == Waypoints[currentIndex].position)
            currentIndex++;
        
        if(currentIndex >= Waypoints.Length) currentIndex = 0;

        transform.position = Vector3.MoveTowards(transform.position,Waypoints[currentIndex].position,moveSpeed/10);
    }
}
