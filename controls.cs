using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public Rigidbody self;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            self.AddForce(-speed, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            self.AddForce(0, 0, speed);
        }
        if (Input.GetKey("d"))
        {
            self.AddForce(speed, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            self.AddForce(0, 0, -speed);
        }
    }
}
