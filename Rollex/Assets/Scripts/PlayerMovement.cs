using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardspeed = 50f;
    public float sidespeed = 10f;
    private Rigidbody rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0f,0f,forwardspeed*Time.deltaTime),ForceMode.Impulse);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce (sidespeed * Time.deltaTime,0f,0f,ForceMode.Impulse);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidespeed * Time.deltaTime, 0f, 0f, ForceMode.Impulse);
        }
        if (rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
