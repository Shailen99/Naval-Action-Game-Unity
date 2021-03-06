﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;


	private Animator anim;
	private Rigidbody2D myRigidBody;

	private bool playerMoving;
	private Vector2 LastMove;

	private bool attacking;
	public float attackTime;
	private float attackTimeCounter;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myRigidBody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		playerMoving = false;
		if (!attacking) {
			if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {
				//transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f ));
				myRigidBody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * moveSpeed, myRigidBody.velocity.y);

				playerMoving = true;
				LastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);

			}
			if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw ("Vertical") < -0.5f) {
				//transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, Input.GetAxisRaw ("Vertical") * moveSpeed);

				playerMoving = true;
				LastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
			}
			if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) {
				myRigidBody.velocity = new Vector2 (0f, myRigidBody.velocity.y);
			}
			if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) {
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, 0f);
			}
			if (Input.GetKeyDown (KeyCode.J)) {
				attackTimeCounter = attackTime;
				attacking = true;
				myRigidBody.velocity = Vector2.zero;
				anim.SetBool ("Attack", true);
			}
		}
		if (attackTimeCounter >= 0) {
			attackTimeCounter -= Time.deltaTime;
		}
		if(attackTimeCounter <= 0)
		{
			attacking = false;
			anim.SetBool ("Attack", false);
		}

		anim.SetFloat("Move X", Input.GetAxisRaw("Horizontal"));
		anim.SetFloat("Move Y", Input.GetAxisRaw("Vertical"));
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", LastMove.x);
		anim.SetFloat ("LastMoveY", LastMove.y);

	}
}
