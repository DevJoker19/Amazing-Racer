using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landmine : MonoBehaviour {

    public GameObject explosionPrefab;
    public Transform respawnPoint;
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            explosionPrefab.SetActive(true);
            other.gameObject.transform.position = respawnPoint.position;
            
        }
    }

   

   
}
     
