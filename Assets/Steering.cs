using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering : MonoBehaviour
{
    public GameObject head;
    public GameObject controller;
    private Vector3 controllerDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controllerDirection = controller.transform.forward;


        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            Debug.Log("Pressed");
            head.transform.position += new Vector3(controllerDirection.x, 0, controllerDirection.z);


        }
    }   
}
