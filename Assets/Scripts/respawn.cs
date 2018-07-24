using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour {

    public GameObject birdSpawn;
    public int birdCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R) && birdCount > 0)
        {
            Instantiate(birdSpawn);
            birdCount--;
        }
        if (birdCount <= 0) {
            LoadCurrentScene();
        }
	}
    public static void LoadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
