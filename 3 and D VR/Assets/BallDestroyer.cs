using UnityEngine;
using System.Collections;

public class BallDestroyer : MonoBehaviour {

	public float lifetime = 10.0f;

	void  Awake ()
	{
		Destroy(gameObject, lifetime);
	}
}
