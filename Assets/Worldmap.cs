using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worldmap : MonoBehaviour {

    public int mapWidth = 10;  
    public int mapHeight = 10;
    public GameObject tilePrefab;
    public GameObject[,] tiles;

	// Use this for initialization
	void Start () {

        tiles = new GameObject[mapWidth, mapHeight];

        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                GameObject go = Instantiate(tilePrefab, new Vector3(x, 0, y), Quaternion.identity);
                go.GetComponent<Tile>().xPos = x;       
                go.GetComponent<Tile>().yPos = y;       
                go.name = (x + " , " + y);
                go.transform.SetParent(this.transform);
            }
        }
	}

	
	// Update is called once per frame
	void Update () {

	}

    public Tile GetTileAt (int x, int y)
    {
        GameObject go = tiles[x, y];
        Tile t = go.GetComponent<Tile>();
        return t;
    }
}
