using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BallMovementController : MonoBehaviour {

    //public GameObject plane;
    //float speed = 5f;

    Rigidbody2D ball;
    float lockPos = 0;

    // Use this for initialization
    void Start () {
	    ball = this.GetComponent<Rigidbody2D>();
        //ball.transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
	
	// Update is called once per frame
	void Update ()
	{
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        //print(x);
	    float y = CrossPlatformInputManager.GetAxis("Vertical");
	    //print(y);

        Vector3 movement = new Vector3(x, 0f, y);
	    //ball.transform.right = null;

    }
}
