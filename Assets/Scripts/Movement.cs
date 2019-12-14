﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }


    }
}
