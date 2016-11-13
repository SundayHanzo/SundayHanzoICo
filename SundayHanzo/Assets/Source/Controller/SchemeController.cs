using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SchemeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeToMainSchene(){
		SceneManager.LoadScene ("MainScene");
	}

	public void ChangeToGameScene(){
		SceneManager.LoadScene ("GameScene");
	}
}
