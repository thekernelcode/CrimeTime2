using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    float moveSpeed = 3f;
    public bool isMoving = false;

    Petrol petrol;

    // Start is called before the first frame update
    void Start()
    {
        petrol = GetComponentInParent<Petrol>();
    }

    // Update is called once per frame
    void Update()
    {
        if (petrol.currentPetrol > 0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                isMoving = true;
            }

            if (Input.GetKey(KeyCode.S))
            {
                //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
                isMoving = true;
            }

            if (Input.GetKey(KeyCode.D))
            {
                //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                isMoving = true;
            }

            if (Input.GetKey(KeyCode.W))
            {
                //transform.position = new Vector3(-1, transform.position.y, transform.position.z);

                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                isMoving = true;
            }

            if (!Input.anyKey)
            {
                isMoving = false;
            }
        }
        else
        {
            isMoving = false;
        }
        
    }
}
