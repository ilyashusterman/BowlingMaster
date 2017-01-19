using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Ball))]
public class DragLaunch : MonoBehaviour {

    private Ball ball;
    // Use this for initialization
    private float startTime, endTime;
    private Vector3 dragStartPos, dragEndPos;
	void Start () {
        ball = GetComponent<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    //start of drag on press
    public void dragStart()
    {
        startTime = Time.time; // the time that the game started
        dragStartPos = Input.mousePosition; // position Vector3 of the input.mouseposition
    }
    //end of Drag on press
    public void dragEnd()
    {
        endTime = Time.time;
        dragEndPos = Input.mousePosition;
        float durationTime = endTime - startTime;
        float speedX = (dragEndPos.x - dragStartPos.x) / durationTime;
        float speedZ = (dragEndPos.y - dragStartPos.y) / durationTime;
        Vector3 dragPos = new Vector3(speedX, 0, speedZ);
          ball.launch(dragPos); // launch ball at this calculated by time and vector3 between 2 points of drag
    }
}
