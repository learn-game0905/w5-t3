using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour
{
    public float speed;
    
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //Quaternion rotation = Quaternion.Euler(0f, speed, 0f);
        //rb.MoveRotation(rb.rotation * rotation);

        //transform.Rotate(new Vector3(0f, speed, 0f));

        rb.AddTorque(new Vector3(0f, 200f, 0f), ForceMode.Acceleration);
    }
}
