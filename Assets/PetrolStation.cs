using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetrolStation : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<Movement>().isMoving == false)
            {
                other.GetComponent<Petrol>().currentPetrol = other.GetComponent<Petrol>().petrolTankCapacity;
            }
        }
    }
}
