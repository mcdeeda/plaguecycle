using UnityEngine;
using System.Collections;

public class unicycleAnimation : MonoBehaviour {

	public float speed;
	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		animator.SetFloat("speed", speed);
		if( Input.GetKeyDown (KeyCode.W)){  
			speed = 1;
			
		}
		if( Input.GetKeyDown (KeyCode.Q)){
			speed = -1;
		}	
	}