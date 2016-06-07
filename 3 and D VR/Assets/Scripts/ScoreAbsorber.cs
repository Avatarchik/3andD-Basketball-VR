using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

	public int Score;

	// Use this for initialization
	void Start () {
		ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
		Score = 1;
		if (oldKeeper) {
			Score = oldKeeper.Score;
			Destroy(oldKeeper.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
