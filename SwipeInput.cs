using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeInput : MonoBehaviour {

	private Vector2 startTouchPos, endTouchPos;
	private Rigidbody2D rb;
	private float swipeForce = 350f;
	private bool swipeAllow = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update(){
		SwipeCheck();
	}

	// Update is called once per frame
	void FixedUpdate () {
		swipeGo();
	}

	private void SwipeCheck(){
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)
			startTouchPos = Input.GetTouch(0).position;
		
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended){
			endTouchPos = Input.GetTouch(0).position;
			if ((endTouchPos.x > startTouchPos.x +15 || endTouchPos.x < startTouchPos.x -15) && rb.velocity.x == 0){
				swipeAllow = true;
			}
		}
	}

	private void swipeGo(){
		if (swipeAllow){
			swipeAllow = false;
			if (endTouchPos.x > startTouchPos.x){
				rb.AddForce(Vector2.right * swipeForce);
			}else if (endTouchPos.x < startTouchPos.x){
				rb.AddForce(Vector2.left * swipeForce);
			}
		}
	}

}
