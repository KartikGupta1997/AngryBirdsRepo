﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bird2 : MonoBehaviour
{

    public Rigidbody rb;
    private float xPow;
    public int scoreTotal;
    public int canJump;
    public int destroyTime;
    public Text powerText;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
        xPow = 10f;
        powerText = GameObject.Find("Canvas/powerText").GetComponent<Text>(); //Finds the textUI element in 
        powerTextFunc();

    }
    // Update is called once per frame
    private void Update()
    {

        powerTextFunc();
        if (Input.GetKey(KeyCode.UpArrow) && canJump == 2)
        {
            transform.Rotate(new Vector3(0, 0, 3));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && canJump == 2)
        {
            transform.Rotate(new Vector3(0, 0, -3));
        }



        if (Input.GetKeyDown(KeyCode.W) && xPow <= 15) //Mathf.Clamp not working here 
        {
            xPow++;
            Debug.Log(xPow);

        }
        else
        if (Input.GetKeyDown(KeyCode.S) && xPow >= 10) //Mathf.Clamp not working here 
        {
            xPow--;
            Debug.Log(xPow);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump >= 0)
        {

            this.rb.AddRelativeForce(new Vector3(xPow, 0, 0), ForceMode.Impulse);
            Destroy(gameObject, destroyTime); //Destroys gameobject after "destroyTime" seconds
            canJump--;
        }
    }
    void powerTextFunc() // For displaying power value
    {
        powerText.text = "Power: " + xPow.ToString();
    }
}