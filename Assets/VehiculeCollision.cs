﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeCollision : MonoBehaviour
{
    public VehiculeMove movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Obstacle"))
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
