using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigController : MonoBehaviour {
    [SerializeField] private int maxHits;
    private int hits;

    
    void Start()
    {
        hits = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        if (hits >= maxHits) {
            this.gameObject.SetActive(false);
        }
    }
}
