using UnityEngine;
using System.Collections;

public class destroyText : MonoBehaviour {

	float gameTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		gameTime += Time.deltaTime;
		if( gameTime >= 1){
			Destroy(GameObject.FindWithTag("text_1"));
		}
	}
}
