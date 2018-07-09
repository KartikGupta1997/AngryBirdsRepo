using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour {
    private float yval;
    [Range(3f, 7f)] public float xval;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
  
        
	}
	
	// Update is called once per frame
	void Update () {
  
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            this.rb.AddRelativeForce(new Vector3(xval, 0, 0), ForceMode.Impulse);


        }
   
    }
}
