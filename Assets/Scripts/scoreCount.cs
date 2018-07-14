using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCount : MonoBehaviour {

    public GameObject[] pigsObject;
    public int pigsLength;
    private int lastPigCount;
    // Use this for initialization
    void Start () {
        lastPigCount = pigsLength;
	}
	
	// Update is called once per frame
	void Update () {
        if(lastPigCount>pigsLength)
        pigsObject = GameObject.FindGameObjectsWithTag("pig");
        pigsLength = pigsObject.Length;
        lastPigCount = pigsLength;
    }
}
