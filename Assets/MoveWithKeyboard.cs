using UnityEngine;
using System.Collections;

public class MoveWithKeyboard : MonoBehaviour
{
	public KeyCode KeyUp;
	public KeyCode KeyDown;
	public ParticleSystem ps;

	private Vector3 lastPosition;
	
	// Update is called once per frame
	void Update () {
		lastPosition = this.transform.position;

		if (Input.GetKey (KeyUp)) {
			Vector3 toTransform = this.transform.position;
			toTransform.z += 0.1f;
			this.transform.position = toTransform;
		}
		else if(Input.GetKey (KeyDown)) {
			Vector3 toTransform = this.transform.position;
			toTransform.z -= 0.1f;
			this.transform.position = toTransform;
		}
	}

	void OnCollisionEnter (Collision col)
	{

		this.transform.position = lastPosition;

		if (col.gameObject.name.Equals ("Ball")) {
			ps.Play ();
		}
	}
}
