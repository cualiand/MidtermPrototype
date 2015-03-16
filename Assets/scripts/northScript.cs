using UnityEngine;
using System.Collections;

public class northScript : MonoBehaviour {

	Collider thingCurrentlyInside;
	public Light lt;

	// Use this for initialization
	void Start () {
		//GameObject lt = GameObject.Find("Directional Light");
		lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( thingCurrentlyInside != null ) {
			// if something enters this block, change directional light color
			lt.color = Color.red;


		}	
	}

	void onTriggerEnter ( Collider activator ) {
		thingCurrentlyInside = activator;
	}

	void onTriggerExit ( Collider exiter ) {
		thingCurrentlyInside = null;
	}
}
