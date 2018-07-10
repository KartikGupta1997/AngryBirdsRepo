using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitController : MonoBehaviour {
    public int maxHits;
    public int maxScore;
    public int hits;
    public int test;

    private void Awake()
    {
        test = 10;
    }
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        if (hits >= maxHits) {
            //if (this.gameObject.CompareTag("pig"))
            //{
            //    maxScore = maxScore + 50;

            //}
            //else
            //if (this.gameObject.CompareTag("wall")) 
            //this code will not work because this script is attached  to each component, each has its own maxScore, which initialises to zero for each deactivated objects 
                
            //{
            //    maxScore = maxScore + 10;
                
            //}
            this.gameObject.SetActive(false);
         
        }
    }
}
