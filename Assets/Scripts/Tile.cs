using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour
{
    public Worldmap tileMapOfWorld;

    public int xPos;
    public int yPos;

    public bool crimeInProgress;

    public Material defaultMaterial;
    public Material crimeInProgressMaterial;

    float crimeInProgressTimer = 10f;

    TextMeshPro textMeshPro;

    

    // Start is called before the first frame update
    void Start()
    {
        // Make tile aware if the world it is in
        tileMapOfWorld = FindObjectOfType<Worldmap>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (crimeInProgress == true)
        {
            crimeInProgressTimer -= Time.deltaTime;
            textMeshPro = GetComponentInChildren<TextMeshPro>();
            textMeshPro.text = crimeInProgressTimer.ToString();

            if (crimeInProgressTimer <= 0)
            {
                GetComponent<Renderer>().material.color = Color.gray;
                crimeInProgressTimer = 0;
                textMeshPro.text = "Failed to stop crime!";
            }
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
