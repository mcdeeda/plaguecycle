using UnityEngine;
using System.Collections;

public class destroyTextTwo : MonoBehaviour {
	
	float gameTime;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		gameTime += Time.deltaTime;
		if( gameTime >= 2){
			Destroy(GameObject.FindWithTag("text_2"));
		}
	}
}