using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float playerSpeed = 10f;
    public float jumpForce = 5f;
    public float groundDistance = 0.4f;

    public LayerMask groundMask;
    public Transform groundCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool groundCheck = Physics.Raycast(groundCheckpoint.position, Vector3.down, groundDistance, groundMask);
        Debug.Log("Ground Check: " + groundCheck);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * playerSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * playerSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * playerSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * playerSpeed);
        }
        
        if (Input.GetKey(KeyCode.Space) && groundCheck)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(groundCheckpoint.position, groundCheckpoint.position + Vector3.down * groundDistance);
    }
}
