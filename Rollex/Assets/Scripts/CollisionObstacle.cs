using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            //Debug.Log("Collide with Obstacle");
            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
