using UnityEngine;
using System.Collections;

public class spinnyControl : MonoBehaviour {

	Rigidbody rbody;
	public float speed = 190f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rbody.AddForce ( transform.forward * speed * Input.GetAxis ("Vertical") );
	
	}
}
