using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
		GoalConfirm trigger = GetComponentInChildren<GoalConfirm> ();
		trigger.ExpectCollider(collider);
	}
}
