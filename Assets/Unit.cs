using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public int health;

	// Use this for initialization
	void Start () {
        health = Random.Range(2, 4);
	}
	
	// Update is called once per frame
	void Update () {
	}

    public int GetHealth()
    {
        return health; 
    }

    public bool SetHealth(int h)
    {
        health = health - h;
        if (health == 0)
        {
            Die();
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Die()
    {
        Debug.Log("Commence die script");
        GameObject go = transform.root.gameObject;
        Debug.Log("Name of Gameobject I have hold of is " + go );
        Destroy(go);
    }
}
