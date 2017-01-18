using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Ball))]
public class DragLaunch : MonoBehaviour {

    private Ball ball;
	// Use this for initialization
	void Start () {
        ball = GetComponent<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
