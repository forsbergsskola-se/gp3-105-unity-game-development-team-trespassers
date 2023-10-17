using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 0.05f;

    // Update is called once per frame



    void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (Input.GetButton("Horizontal"))
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                transform.Translate(speed, 0 ,0);
            }
            else
            {
                transform.Translate(-speed, 0 ,0);
            }
        } 
        if (Input.GetButton("Vertical"))
        {
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                transform.Translate(0, 0 ,speed);
            }
            else
            {
                transform.Translate(0, 0 ,-speed);
            }
        } 
    }
}