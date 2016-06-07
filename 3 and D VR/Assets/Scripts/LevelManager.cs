using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float levelTimer = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update (){
		if (levelTimer > 0) {
			levelTimer -= Time.deltaTime;
				if (levelTimer < 0) {
					LoadNextScene ();
			}
		}
	}

	public void LoadNextScene() {
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//Load scene 1
		SceneManager.LoadScene (currentIndex + 1);
	}

	public void LoadPreviousLevel(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//Load scene 1
		SceneManager.LoadScene (currentIndex - 1);
	}

	public void LoadMenu(){
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//Load scene 1
		SceneManager.LoadScene (0);
	}
}
