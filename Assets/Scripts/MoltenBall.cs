﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoltenBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward);
	}
}
