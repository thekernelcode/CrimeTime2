using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petrol : MonoBehaviour
{
    
    public float petrolTankCapacity = 50f;
    public float currentPetrol = 50f;

    Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponentInParent<Movement>();
        if (movement != null)
        {
            Debug.Log("Found movement script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.isMoving == true)
        {
            
            currentPetrol -= Time.deltaTime;
        }
    }
}
