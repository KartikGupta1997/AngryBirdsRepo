using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    public GameObject birdSpawn;
    public int birdCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R) && birdCount>=2)
        {
            Instantiate(birdSpawn);
        }
	}
}
