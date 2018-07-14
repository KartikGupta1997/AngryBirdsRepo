using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreCount : MonoBehaviour {
    public GameObject[] pigsObject;
    public int pigsLength;
	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        pigsObject = GameObject.FindGameObjectsWithTag("pig");
        pigsLength = pigsObject.Length;
        if (pigsLength <= 0)
        {


            int totalScenes = SceneManager.sceneCountInBuildSettings;
            Debug.Log("Total scenes are:" + totalScenes);
            int index = (SceneManager.GetActiveScene().buildIndex + 1) % totalScenes; 
            //when index becomes equal to total scenes, due to %totalScenes, index value becomes 0, that is the game restarts 
            SceneManager.LoadScene(index, LoadSceneMode.Single); //LoadSceneMode.Single Closes all current loaded scenes and loads a scene
        }
	}
}
