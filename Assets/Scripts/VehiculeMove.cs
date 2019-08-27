using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeMove : MonoBehaviour
{
    /// <summary>
    /// Reference to the Rigidbody component called "rb"
    /// </summary>
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    /// <summary>
    /// Mess with physics
    /// </summary>
    void FixedUpdate()
    {
        // Add forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
