using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaypointMove : MonoBehaviour
{
    private float speed = 0.1f;                // Speed of movement
    public GameObject[] waypoints;            // Array of waypoints to move towards
    public GameObject currentTarget;         // Current target waypoint
    private int currentIndex = 0;             // Index of the current waypoint
    public float stopDistance = 0.1f;         // Distance threshold to consider the waypoint reached

    public float[] speeds;

    // Called once during run time
    void Start()
    {
        if (waypoints.Length > 0)
        {
            // Set first target to go to
            currentTarget = waypoints[currentIndex]; 
        }
    }

    // Update is called every frame
    void Update()
    {
        if (currentTarget != null)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                speed += 10f;
            }
            if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                speed += 0.1f;
            }
            Vector3 direction = currentTarget.transform.position - transform.position;
            // Use a unit vector (normalized) to ensure constant speed
            //speed = speeds[currentIndex];
            Vector3 moveDirection = direction.normalized * speed;
            transform.position += moveDirection;

            // Check if we are at the current target, (the percentage difference is good enough for us)
            if (direction.magnitude <= stopDistance)
            {
                currentIndex++;
                
                if (currentIndex >= waypoints.Length)
                {
                    currentIndex = 0;
                    speed = speeds[currentIndex];
                }

                currentTarget = waypoints[currentIndex];
            }
        }
    }
}
