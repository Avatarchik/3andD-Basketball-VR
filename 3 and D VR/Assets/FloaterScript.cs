using UnityEngine;
using System.Collections;

public class FloaterScript : MonoBehaviour {

	public float floatStrength;
	public float RandomRotStrength;

	// Update is called once per frame
	void Update () {
		transform.GetComponent<Rigidbody>().AddForce(Vector3.right * floatStrength);
		transform.Rotate (RandomRotStrength, RandomRotStrength, RandomRotStrength);
	}
}
