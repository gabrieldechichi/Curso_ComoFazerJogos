using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 200, 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
