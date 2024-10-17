using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Oculus.Haptics;

public class WaypointMove : MonoBehaviour
{
    private float speed;                // Speed of movement
    public GameObject[] waypoints;            // Array of waypoints to move towards
    public GameObject currentTarget;         // Current target waypoint
    private int currentIndex = 0;             // Index of the current waypoint
    public float stopDistance = 0.1f;         // Distance threshold to consider the waypoint reached

    public float[] speeds;

    public HapticClip clip;
    private HapticClipPlayer hapticPlayer;

    public AudioSource audioSource;

    // Called once during run time
    void Start()
    {
        if (waypoints.Length > 0)
        {
            // Set first target to go to
            currentTarget = waypoints[currentIndex]; 
            speed = speeds[currentIndex];
        }

        hapticPlayer = new HapticClipPlayer(clip);
    }

    // Update is called every frame
    void Update()
    {
        Debug.Log(speed);
        if (currentTarget != null)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                speed += 10f;
                hapticPlayer.Play(Controller.Left);
                audioSource.Play();
                Debug.Log("working");
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
                    
                }
                speed = speeds[currentIndex];
                currentTarget = waypoints[currentIndex];
            }
        }
    }
}
