using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text currentPetrol;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPetrol.text = "Petrol = " + player.GetComponent<Petrol>().currentPetrol.ToString("F2");  // F2 means 2 decimal places.

    }
}
