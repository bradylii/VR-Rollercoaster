using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoint : MonoBehaviour
{
    private static int count;
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        count++;
        Debug.Log(count);
    }
}
