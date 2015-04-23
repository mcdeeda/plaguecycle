using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button_press_highlight : MonoBehaviour {
	
	public Text textObject;
	public KeyCode keyToPress;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(keyToPress)) {
			textObject.color = Color.red;

		}
		else {
			textObject.color = Color.black;
		}
	}
}
