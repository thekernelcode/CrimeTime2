using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Worldmap tileMapOfWorld;

    public int xPos;
    public int yPos;

    public Material defaultMaterial;
    public Material crimeInProgressMaterial;

    // Start is called before the first frame update
    void Start()
    {
        // Make tile aware if the world it is in
        tileMapOfWorld = FindObjectOfType<Worldmap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
