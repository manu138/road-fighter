﻿using UnityEngine;
using System.Collections;

public class carSpawner : MonoBehaviour {

    public GameObject [] cars;
    int carNo;


    public float maxPos=2.1f;
    public float delayTimer=1f;
    float timer;

	// Use this for initialization
	void Start () {
        timer = delayTimer;
        
	}

    // Update is called once per frame
    void Update() {

        timer -= Time.deltaTime;
        if (timer <=0)
        { 
        Vector3 carPos = new Vector3(Random.Range(-2.08f, 2.08f), transform.position.y, transform.position.x);
            carNo = Random.Range(0, 5);
        Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
