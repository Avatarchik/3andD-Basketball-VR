using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotSpeed;
		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation; //Transforms cam rotation per frame
		Camera camera = GetComponentInChildren<Camera>();
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;


	}
}
