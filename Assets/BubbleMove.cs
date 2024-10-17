using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMove : MonoBehaviour
{
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float changeY = Random.Range(-1f, -1f); // Upper bound is exclusive
        

        //random x, y, z ( -1 to 1) 
        //goes up down y
        //left right (very small amount)

        //if it hits pikachu destroy (or respawn at initial positon)

    }
}
