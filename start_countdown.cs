using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class start_countdown : MonoBehaviour {
	
	public Text count_1;
	public Text count_2;
	public Text count_3;
	float gameTime = 0;
	
	// Use this for initialization
	void Start () {
		count_3.color = new Color(1,1,1,1);
		if(gameTime >= 1) {
			count_3.color = new Color(1,1,1,0);
			count_2.color = new Color(1,1,1,1);
		}

		if (gameTime >= 2) {
			count_2.color = new Color(1,1,1,0);
			count_1.color = new Color(1,1,1,1);
		}

		if (gameTime >=3) {
			count_1.color = new Color(1,1,1,0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameTime <=5) {
			gameTime += Time.deltaTime;
		}

	}
}
