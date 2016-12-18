using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public static SchemeController schemeController;

	public GameObject[] ArrowPrefab;
	public GamePlayView gamePlayView;
	private GameObject nowArrow = null;
	public GameObject ARCameraObject;



	// Use this for initialization
	void Start () {
		SchemeController.gameController = this;
		showArrow ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showArrow(){
		if (nowArrow != null) {
			GameObject.Destroy (nowArrow);
			nowArrow = null;
		}
		nowArrow = Object.Instantiate (ArrowPrefab [0]);
		nowArrow.transform.parent = ARCameraObject.transform;
		nowArrow.transform.position = ArrowPrefab [0].transform.position;
		nowArrow.transform.rotation = ArrowPrefab [0].transform.rotation;
		gamePlayView.showArrowInInitializePosition (nowArrow);
	}

	public void fireArrow(){
		if (nowArrow == null) {
			Debug.Log ("Now Arrow is not setting yet");
		}
		Arrow arrowSource = nowArrow.GetComponent<Arrow> ();
		Quaternion arCameraRotation = ARCameraObject.transform.rotation;
		arrowSource.fire (arCameraRotation);
		schemeController.ShowMoveCamera ();
	}
}
