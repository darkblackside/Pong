using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject Ball;
	private Vector3 ResetPosition;

	private int Points1;
	private int Points2;

	// Use this for initialization
	void Start () {
		ResetPosition = Ball.transform.position;

		ResetBall ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ResetBall()
	{
		Ball.transform.position = ResetPosition;
		Ball.GetComponentInParent<Rigidbody>().velocity = new Vector3(10, 0, 5);
	}

	public void AddPointForPlayer1()
	{
		Points1++;
	}

	public void AddPointForPlayer2()
	{
		Points2++;
	}
}
