﻿using UnityEngine;
using System.Collections;

public class MeteorMover : MonoBehaviour {

	public float speed = -2f;
	private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		// Give Meteor an initial downward velocity
		rigidBody.velocity = new Vector2 (0, speed);
	}

}
