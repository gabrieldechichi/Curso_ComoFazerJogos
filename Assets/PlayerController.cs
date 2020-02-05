using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public int forcaEmX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
}
