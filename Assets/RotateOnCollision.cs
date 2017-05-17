using UnityEngine;
using System.Collections;

public class RotateOnCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		/*
		Vector3 actualVelocity = this.gameObject.GetComponentInParent<Rigidbody>().velocity;

		if (col.gameObject.transform.position.x > this.gameObject.transform.position.x) {
			actualVelocity.z = -actualVelocity.z;
		} 

		if (col.gameObject.transform.position.x < this.gameObject.transform.position.x) {
			actualVelocity.z = -actualVelocity.z;
		} 

		if (col.gameObject.transform.position.z < this.gameObject.transform.position.z) {
			actualVelocity.x = -actualVelocity.x;
		} 

		if (col.gameObject.transform.position.z > this.gameObject.transform.position.z) {
			actualVelocity.x = -actualVelocity.x;
		}

		this.gameObject.GetComponentInParent<Rigidbody> ().velocity = actualVelocity;*/

		//this.gameObject.transform.RotateAround (this.gameObject.transform.position, new Vector3 (0, 1, 0), 90);
	}
}
