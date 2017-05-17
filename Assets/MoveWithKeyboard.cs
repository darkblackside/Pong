using UnityEngine;
using System.Collections;

public class MoveWithKeyboard : MonoBehaviour
{
	public KeyCode KeyUp;
	public KeyCode KeyDown;

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
		System.Console.WriteLine (col.gameObject.name);

		this.transform.position = lastPosition;
	}
}
