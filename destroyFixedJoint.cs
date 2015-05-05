using UnityEngine;
using System.Collections;

public class destroyFixedJoint : MonoBehaviour {

	bool shouldIPlayASound;

	public AudioClip screamSound1;
	//to add Tag look at inspector and go to Tag -> Add Tag
	//Tags used: Sphere_1, Sphere_2, rope_1, rope_2 
	void OnTriggerEnter(Collider activator){
		Debug.Log ("something entered the trigger!!! omg");
		activator.GetComponent<Rigidbody>();
		if (activator.gameObject.tag.Equals("Sphere_1")){
			Destroy(GameObject.FindWithTag("rope_1"));
			Destroy (this.gameObject); //self - destruct so this barrier is gone
			AudioSource.PlayClipAtPoint( screamSound1, transform.position, 1f );
			//Invoke ( "StartGame", 3f );
		}
		if (activator.gameObject.tag.Equals("Sphere_2")){
			Destroy(GameObject.FindWithTag("rope_2"));
			Destroy (this.gameObject); //self - destruct so this barrier is gone
			//AudioSource.PlayClipAtPoint( screamSound1, transform.position, 1f );
			//Invoke ( "StartGame", 3f );
		}
	}
}