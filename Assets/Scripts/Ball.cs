﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Vector3 launchVelocity;
	public bool inPlay = false;

	private Vector3 ballStartPos;
	private Rigidbody rigidBody;
	private AudioSource audioSource;


	// Use this for initialization
	void Start () {
		rigidBody= GetComponent<Rigidbody>();
		rigidBody.useGravity = false;
		ballStartPos = transform.position;
	}

	public void Launch(Vector3 velocity) {

		inPlay = true;
		rigidBody.useGravity = true;
		rigidBody.velocity = velocity;

		audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}

	public void Reset(){
		Debug.Log("Resetting ball");
		inPlay = false;
		transform.position = ballStartPos;
		rigidBody.velocity = Vector3.zero;
		rigidBody.angularVelocity = Vector3.zero;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
