using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Vector3 currentLocation;
    Vector3 newLocation;
    bool unitIsActive = false;
    bool playerIsActive = false;

	// Use this for initialization
	void Start () {
        currentLocation = gameObject.transform.position;
        newLocation = currentLocation;
        Debug.Log(currentLocation);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.U))
        {
            unitIsActive = true;
            playerIsActive = false;
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            unitIsActive = false;
            playerIsActive = true;
        }

        if (playerIsActive == true && gameObject.tag == ("Player"))
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                newLocation.x = currentLocation.x - 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                newLocation.x = currentLocation.x + 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                newLocation.z = currentLocation.z + 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                newLocation.z = currentLocation.z - 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.Space) && playerIsActive == true)
            {
                Unit u = (Unit)FindObjectOfType(typeof(Unit));
                u.health -= 1;
            }
        }
        else if (unitIsActive == true && gameObject.tag == ("Unit"))
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                newLocation.x = currentLocation.x - 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                newLocation.x = currentLocation.x + 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                newLocation.z = currentLocation.z + 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                newLocation.z = currentLocation.z - 1;
                gameObject.transform.position = newLocation;
                currentLocation = newLocation;
            }
        }

        
    }
}
