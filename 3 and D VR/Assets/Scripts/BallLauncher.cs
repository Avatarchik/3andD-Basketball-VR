using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown("Tap")) // User input (Spacebar) If pressed...
		{
			//Fire Projectile
			GameObject instance = Instantiate(ballPrefab); // Create instantiation into scene 
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody>(); // Since calling Rigidbody can be renamed (rb)
			Camera camera = GetComponentInChildren<Camera>();
			rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
		}
	}

}