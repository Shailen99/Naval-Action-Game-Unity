﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogHolder1 : MonoBehaviour {

	public string dialogue;
	private DialogueManager dCoconut;

	// Use this for initialization
	void Start () {
		dCoconut = FindObjectOfType<DialogueManager> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			if(Input.GetKeyUp(KeyCode.Space))
			{
				dCoconut.ShowBox (dialogue);
			}
		}
	}
}