using UnityEngine;
using System.Collections;

public class destroyCounter : MonoBehaviour {


	//void OnCollisionEnter (Collision col)
	//{
	//	if(col.gameObject.name == "trashSphere")
	//	{
	//		Destroy(col.gameObject);
	//	}
	//}
	Collision col;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( col.gameObject.name == "trashSphere" ) {
			Destroy ( col.gameObject );
		}
	}
}
