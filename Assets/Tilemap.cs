using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilemap : MonoBehaviour {

    public int mapWidth = 10;
    public int mapHeight = 10;
    public GameObject tilePrefab;
    public GameObject[,] tiles;
    public Transform tilemap;

	// Use this for initialization
	void Start () {
        tiles = new GameObject[mapWidth, mapHeight];

        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                GameObject go = Instantiate(tilePrefab, new Vector3(x, 0, y), Quaternion.identity);
                go.name = (x + " , " + y);
                go.transform.SetParent(tilemap);
            }
        }
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
