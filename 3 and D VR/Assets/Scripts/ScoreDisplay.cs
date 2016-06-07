﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;
	ScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		scoreKeeper = FindObjectOfType<ScoreKeeper>();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Score: " + scoreKeeper.Score;
	}
}
