using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyFinger : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform finger;
    public GameObject hand;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finger = hand.transform.Find("Bones/Hand_WristRoot/Hand_Thumb0/Hand_Thumb1/Hand_Thumb2/Hand_Thumb3");
        int randomInt = UnityEngine.Random.Range(1, 4);

        if (finger != null)
        {
            if (finger.localScale.x < 3)
            {
                finger.transform.localScale += new Vector3(.01f, 0, 0);
                Debug.Log(finger.localScale.x);
            }
            if (finger.localScale.x > 3)
            {
                finger.transform.localScale = new Vector3(1, 1, 1);
                Debug.Log(finger.localScale.x);
            }

        }


    }
}
