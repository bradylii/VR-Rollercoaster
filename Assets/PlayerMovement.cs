using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private float jumpForce;

    private Rigidbody rb;
    private SphereCollider sCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(speed * new Vector3(Input.GetAxisRaw("Horizontal"), 0, 
        Input.GetAxisRaw("Vertical")), ForceMode.Force);

        // this.transform.position += speed * new Vector3(Input.GetAxisRaw("Horizontal"), 0, 
        // Input.GetAxisRaw("Vertical"));


        if (Input.GetKeyDown(KeyCode.Space) && 
        Physics.Raycast(transform.position, Vector3.down, sCollider.radius + 1))
        {
            Debug.Log("hello");
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        }
    }
}
