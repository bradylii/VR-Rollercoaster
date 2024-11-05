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
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(new Ray(this.transform.position, this.transform.forward), out hit))
        {
            lineRenderer.SetPosition(0, this.transform.position);

        }

    }
}
