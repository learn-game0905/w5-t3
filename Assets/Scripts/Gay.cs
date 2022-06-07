using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gay : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Vector3 test;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Quaternion rotation = Quaternion.Euler(0f, speed, 0f);
        // _rigidbody.MoveRotation(_rigidbody.rotation * rotation);
        
        // transform.Rotate(new Vector3(0f, speed, 0f));
        
        // _rigidbody.rotation = Quaternion.identity;
        
        _rigidbody.AddTorque(test, ForceMode.Acceleration);
    }
}
