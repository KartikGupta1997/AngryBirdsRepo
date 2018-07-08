using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {

    public Rigidbody rb;
    [SerializeField] private float xval, yval;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(xval,yval,0, ForceMode.Impulse);

        }
    }

}
