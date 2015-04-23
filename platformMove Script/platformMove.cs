using UnityEngine;
using System.Collections;

public class platformMove : MonoBehaviour {

	float gameTime;

	// Update is called once per frame
	void Update () {

		gameTime += Time.deltaTime;

		//if (Input.GetKey (KeyCode.A) ) {
		if( gameTime >= 3){
			transform.position += new Vector3( -10f, 0f, 0f );
		}
	}
}