﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Time.deltaTime * transform.forward * 2;
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameOver.fault++;
        Destroy(gameObject);
    }
}
