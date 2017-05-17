using UnityEngine;
using System.Collections;

public class ResetWall : MonoBehaviour {

	public GameController controller;
	public int Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		controller.AddPoint (Player);
		controller.ResetBall ();
	}
}
