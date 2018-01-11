﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingDoor : MonoBehaviour {

public GameObject HiddenWall;
public GameObject EnemyHolder;

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{
if(other.gameObject.name == "Player")
{
	HiddenWall.SetActive(true);
	EnemyHolder.SetActive(true);
}
	}
}
