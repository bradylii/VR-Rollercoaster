using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject head;
    public GameObject controller;
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        lineRenderer.SetPosition(0, controller.transform.position);
        if (Physics.Raycast(new Ray(controller.transform.position, controller.transform.forward), out hit))
        {
            lineRenderer.SetPosition(1, new Vector3(hit.point.x, 1, hit.point.z));
            lineRenderer.SetPosition(2, hit.point);
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
            {
                head.transform.position = new Vector3(hit.point.x, head.transform.position.y, hit.point.z);
                //this.transform.position = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
            }

        }
        
        else
        {
            Vector3 forNow = controller.transform.position + controller.transform.forward;
            lineRenderer.SetPosition(1, new Vector3(forNow.x, forNow.y + 1, forNow.z));
            lineRenderer.SetPosition(2, new Vector3(forNow.x, 0, forNow.z));

        }

    }
}
