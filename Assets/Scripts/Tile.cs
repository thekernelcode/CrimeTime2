using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Worldmap tileMapOfWorld;

    public int xPos;
    public int yPos;

    public bool crimeInProgress;

    public Material defaultMaterial;
    public Material crimeInProgressMaterial;

    public float crimeInProgressTimer = 10f;

    CrimeInProgressUI crimeInProgressUI;

    // Start is called before the first frame update
    void Start()
    {
        // Make tile aware if the world it is in
        tileMapOfWorld = FindObjectOfType<Worldmap>();
        crimeInProgressUI = FindObjectOfType<CrimeInProgressUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (crimeInProgress == true)
        {
            crimeInProgressTimer -= Time.deltaTime;
            crimeInProgressUI.startCountdown = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && crimeInProgress == true)
        {
            crimeInProgress = false;
            Debug.Log("Player tagged this crime!, resetting state");
            GetComponent<Renderer>().material = defaultMaterial;
        }
    }
}
