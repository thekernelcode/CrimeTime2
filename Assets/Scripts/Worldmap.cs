using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Worldmap : MonoBehaviour {

    public int mapWidth = 10;  
    public int mapHeight = 10;
    public GameObject tilePrefab;

    public GameObject[,] tiles;
    public List<GameObject> tileGameObjects;

    public float crimeInProgressCooldown;

	// Use this for initialization
	void Start () {

        tiles = new GameObject[mapWidth, mapHeight];
        tileGameObjects = new List<GameObject>();

        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                GameObject go = Instantiate(tilePrefab, new Vector3(x, 0, y), Quaternion.identity);
                go.GetComponent<Tile>().xPos = x;       
                go.GetComponent<Tile>().yPos = y;       
                go.name = (x + " , " + y);
                go.transform.SetParent(this.transform);
                
                tileGameObjects.Add(go);
                tiles[x, y] = go;
            }
        }

        crimeInProgressCooldown = 5f;
	}

	
	// Update is called once per frame
	void Update () 
    
    {
        crimeInProgressCooldown -= Time.deltaTime;
        if (crimeInProgressCooldown < 0)
        {
            CrimeInProgress();
        }

	}

    public Tile GetTileAt (int x, int y)
    {
        foreach (GameObject tileGameObject in  tileGameObjects)
        {
            if (tileGameObject.transform.position.x == x && tileGameObject.transform.position.z == y)
            {
                Tile t = tileGameObject.GetComponent<Tile>();
                return t;
            }
        }

        return null;
    }

    public void CrimeInProgress()
    {
        int randomX = Random.Range(0, mapWidth);
        int randomY = Random.Range(0, mapHeight);

        Debug.Log("Crime in progress at " + randomX + ", " + randomY);
        Tile t = GetTileAt(randomX, randomY);

        t.GetComponent<Renderer>().material = t.crimeInProgressMaterial;
        t.crimeInProgress = true;

        

        crimeInProgressCooldown = 5f;
    }
}
