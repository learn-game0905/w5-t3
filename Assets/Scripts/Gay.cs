using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gay : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //Quaternion rotation = Quaternion.Euler(0f, speed, 0f);
        //_rigidbody.MoveRotation(_rigidbody.rotation * rotation);

        //transform.Rotate(new Vector3(0f, speed, 0f));

        _rigidbody.AddTorque(new Vector3(0f, 200f, 0f), ForceMode.Acceleration);
        
        // _rigidbody.rotation = Quaternion.identity;
    }
}
