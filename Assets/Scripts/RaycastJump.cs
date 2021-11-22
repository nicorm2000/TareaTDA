using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJump : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    private Rigidbody rb;
    [SerializeField] LayerMask groundLayer;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded())
            {
                Jump();
            }
        }
    }
    private void Jump()
    {
        rb.AddForce(0, 1 * jumpForce, 0);
    }


    private bool IsGrounded()
    {
        if (Physics.Raycast(transform.position, Vector3.down, 0.5f, groundLayer))
        {
            return true;
        }
        else return false;
    }
}
