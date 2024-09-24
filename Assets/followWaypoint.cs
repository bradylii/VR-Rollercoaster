using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followWaypoint : MonoBehaviour
{
    // Start is called before the first frame update
    public WaypointMove waypointMoveScript; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waypointMoveScript.currentTarget != null)
        {
            Transform targetTransform = waypointMoveScript.currentTarget.transform;
            this.transform.LookAt(targetTransform);
        }
    }
}
