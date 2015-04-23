using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.YieldInstruction;

public class button_press_highlight : MonoBehaviour {
	
	public Text count_1;
	public Text count_2;
	public Text count_3;
	public KeyCode keyToPress;
	
	// Use this for initialization
	void Start () {
		count_3.color = Color(256,256,256,1);
		yield WaitforSeconds(1);
		count_3.color = Color(256,256,256,0);
		count_2.color = Color(256,256,256,1);
		yield WaitforSeconds(1);
		count_2.color = Color(256,256,256,0);
		count_1.color = Color(256,256,256,1);
		yield WaitforSeconds(1);
		count_1.color = Color(256,256,256,0);

	}
	
	// Update is called once per frame
	void Update () {

	}
}
