using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {

    public Rigidbody rb;
    [SerializeField]private float xPow;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0, 0, 5));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(0, 0, -5));
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddRelativeForce(new Vector3(xPow, 0,0), ForceMode.Impulse);
          

        }
    }

}
