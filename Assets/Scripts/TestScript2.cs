using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour {
    private float yval;
    [Range(3f, 7f)] public float xval;
    [Range(0.267f,2.74f)]public float rotValue;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
  
        
	}
	
	// Update is called once per frame
	void Update () {
  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            yval = rotValue * xval;
            this.rb.AddForce(new Vector3(xval, yval, 0), ForceMode.Impulse);


        }
   
    }
}
