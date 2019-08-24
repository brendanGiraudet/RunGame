using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag.Equals("Obstacle"))
        {
            movement.enabled = false;
        }
    }
}
