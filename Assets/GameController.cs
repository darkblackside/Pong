using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject Ball;
	public Text PointsCounter;

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
		PointsCounter.text = Points1 + " :: " + Points2;
	}

	public void ResetBall()
	{
		Ball.transform.position = ResetPosition;

		Ball.GetComponentInParent<Rigidbody>().velocity = new Vector3(Random.value * 10, 0, Random.value * 10);
	}

	public void AddPoint(int player)
	{
		switch (player) {
		case 1:
			Points1++; break;
		default:
			Points2++; break;
		}
	}
}
