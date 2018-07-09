using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {

    public Rigidbody rb;
    [SerializeField]private Vector3 forcePos, localForcePos;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        localForcePos = transform.InverseTransformPoint(forcePos);

    }
    private void Update()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(localForcePos, ForceMode.Impulse);
          

        }
    }

}
