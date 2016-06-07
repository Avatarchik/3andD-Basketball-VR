using UnityEngine;
using System.Collections;

public class BobScript : MonoBehaviour {
	Vector3 startPos;
	public int dir;
	public float floatDistance;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		startPos = transform.position;

		dir = 1;
	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y >= startPos.y + floatDistance || transform.position.y < startPos.y - floatDistance) dir = -dir;
		Vector3 tmpPos = transform.position; tmpPos.y += speed * Time.deltaTime * dir; transform.position = tmpPos;

		// Float
		transform.position = new Vector3(transform.position.x,transform.position.y + Time.deltaTime*dir,transform.position.z);
	}
}
