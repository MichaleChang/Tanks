﻿using UnityEngine;
using System.Collections;

public class DestroyForTime : MonoBehaviour {

    public float destroyTime;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
