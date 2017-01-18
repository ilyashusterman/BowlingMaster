﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //public float launchSpeed=150f;
    public Vector3 launchVelocity;
    private Rigidbody ballRigidBody;
    private AudioSource ballSound;
	// Use this for initialization
	void Start () {
        ballRigidBody = GetComponent<Rigidbody>();
        ballSound = GetComponent<AudioSource>();
        ballRigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnMouseDown()
    {
        launch(launchVelocity);
    }


    public void launch(Vector3 launchVelocity)
    {
        ballRigidBody.useGravity = true;
        //  ballRigidBody.velocity = new Vector3(0f,0f, launchSpeed);
        ballSound.Play();
        ballRigidBody.velocity = launchVelocity;
    }
}
