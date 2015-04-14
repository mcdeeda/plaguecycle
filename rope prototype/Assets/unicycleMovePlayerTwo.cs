using UnityEngine;
using System.Collections;

public class unicycleMovePlayerTwo : MonoBehaviour {

	// ASSUMPTIONS: 3D Object is a Cyclinder that has rotations: X:0, Y:0, Z:90
	
	// -------------------------------------------------------------------------------
	// USE THIS CODE IF WE ARE MOVING WITH ACCELERATION  
	
	Rigidbody rBody;
	public float moveSpeed = 15f;  //for us to adjust the speed
	
	// Use this for initialization
	void Start () {
		rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if( Input.GetKeyDown (KeyCode.P)){  //GetKeyDown is used instead of GetKey so it relies on constant button presses instead of continuous presses
			//rBody.AddForce (transform.forward * Input.GetAxis ("Vertical") * moveSpeed);  //scrap work
			rBody.AddForce (Vector3.forward * moveSpeed);
		}
		if( Input.GetKeyDown (KeyCode.O)){
			rBody.AddForce (Vector3.back * moveSpeed);
		}	
	}
	//--------------------------------------------------------------------------------
	// USE THIS CODE IF WE ARE NOT MOVING WITH ACCELERATION
	
	//	public float speed = 0.5f;   //for us to adjust the speed
	//			
	//	void Update () {
	//		if( Input.GetKeyDown (KeyCode.W)){
	//			transform.position += new Vector3( 0f, 0f, speed );
	//		}	
	//		if( Input.GetKeyDown (KeyCode.Q)){
	//			transform.position += new Vector3( 0f, 0f, -speed );
	//		}	
	//	}
}