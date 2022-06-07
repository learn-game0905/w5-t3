using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllBall : MonoBehaviour
{
    public float speed;

    private float movX, movZ;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CheckInput();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }
    private void CheckInput()
    {
        movX = Input.GetAxisRaw("Horizontal");
        movZ = Input.GetAxisRaw("Vertical");
    }

    void ApplyMovement()
    {
        rb.velocity = new Vector3 (movX * speed, rb.velocity.y, movZ * speed);
    }
}
