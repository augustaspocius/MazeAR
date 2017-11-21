using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BallMovementController : MonoBehaviour {

    //public GameObject plane;
    //float speed = 5f;
    Rigidbody ball;

	// Use this for initialization
	void Start () {
	    ball = this.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update ()
	{
	    float x = CrossPlatformInputManager.GetAxis("Horizontal");
	    float y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        
	    ball.velocity = movement * 10f;
	    if (x != 0 && y != 0)
	    {
	        transform.eulerAngles = new Vector3(transform.eulerAngles.x,Mathf.Atan2(x,y) * Mathf.Rad2Deg,transform.eulerAngles.z);
	    }
    }
}
