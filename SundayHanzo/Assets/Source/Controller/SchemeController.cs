using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SchemeController : MonoBehaviour {

	public static GameController gameController;

	public GameObject traceCamera;
	public WebCamTexture camTexture;
	public GameObject planeOB;
	private Renderer plane;
	public Camera mainCamera;





	// Use this for initialization
	void Start () {
		GameController.schemeController = this;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void ChangeToMainSchene(){
		SceneManager.LoadScene ("MainScene");
	}

	public void ChangeToGameScene(){
		SceneManager.LoadScene ("GameScene");
		TurnOnWebCam ();
	}

	public void ShowMoveCamera(){
		traceCamera.SetActive(true);
	}
	public void TurnOnWebCam(){

		if (planeOB != null) {
			plane = planeOB.GetComponent<Renderer> ();
			WebCamTexture camTexture = new WebCamTexture ();
			plane.material.mainTexture = camTexture;
			camTexture.Play ();
		}
	}
}
