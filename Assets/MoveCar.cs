using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0f, 0f, 0.01f);

        if (this.transform.position.z > 30f) 
        {
            this.transform.position = Vector3.zero;
        }
    }
}
