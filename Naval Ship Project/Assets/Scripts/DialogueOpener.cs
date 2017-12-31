﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueOpener : MonoBehaviour {

	public GameObject dialogBox;
	public bool dialogActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
if(dialogActive && Input.GetKeyDown(KeyCode.Space))
{
	dialogBox.SetActive(false);
	dialogActive = false;
}
	}
public void ShowBox(string dialogue)
{
	dialogActive=true;
	dialogBox.SetActive(true);
}

void OnTriggerEnter2D(Collider2D other)
{

}

}
