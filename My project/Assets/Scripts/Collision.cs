using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    

     private void OnTriggerEnter2D(Collider2D collision)
    {
         // Check if the collided object is an obstacle
        if (collision.tag == "Edges")
        {           
            // Destroy the obstacle
            Destroy(this.gameObject);
        }

        if (collision.tag == "Player")
        {
            // Destroy the player
            Destroy(collision.gameObject);
        }

    }
}
