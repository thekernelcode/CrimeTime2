using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    Vector3 currentLocation;
    Vector3 newLocation;

	// Use this for initialization
	void Start () {
        currentLocation = gameObject.transform.position;
        newLocation = currentLocation;
        Debug.Log(currentLocation);
	}
	
	// Update is called once per frame
	void Update () {


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
