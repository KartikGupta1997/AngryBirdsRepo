using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {

    public Rigidbody rb;
    [Range(10,16)][SerializeField]private float xPow;
    public int scoreTotal;
    public bool canJump;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        canJump = true;
       
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
        Debug.Log("Score is: " + scoreTotal);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            this.rb.AddRelativeForce(new Vector3(xPow, 0,0), ForceMode.Impulse);
            Destroy(gameObject, 3); //Destroys gameobject after 3 seconds
            canJump = false;
        }
    }

    
}
