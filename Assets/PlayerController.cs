﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public int forcaEmX;
    public int forcaEmZ = 50;
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forcaEmZ*Time.fixedDeltaTime);
        if (Input.GetKey("a") == true)
        {     
            rb.AddForce(-forcaEmX* Time.fixedDeltaTime, 0, 0);
            Debug.Log("O A esta apertado");
        }

        if (Input.GetKey("d") == true)
        {
            rb.AddForce(forcaEmX*Time.fixedDeltaTime, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Eu colidi co alguma coisa" + collision.collider.name);

        if (collision.collider.CompareTag("Inimigo") == true)
        {
            gameController.GameOver();
        }
    }
}
