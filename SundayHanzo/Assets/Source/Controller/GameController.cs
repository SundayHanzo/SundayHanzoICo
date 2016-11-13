using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	private static GameController sharedInstance = null;

	public static GameController getInstance(){
		if (sharedInstance == null) {
			sharedInstance = new GameController ();
		}
		return sharedInstance;
	}

	public GameObject[] ArrowPrefab;
	public GamePlayView gamePlayView;
	private GameObject nowArrow = null;



	// Use this for initialization
	void Start () {
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
		gamePlayView.showArrowInInitializePosition (nowArrow);
	}

	public void fireArrow(){
		if (nowArrow == null) {
			Debug.Log ("Now Arrow is not setting yet");
		}
		Arrow arrowSource = nowArrow.GetComponent<Arrow> ();
		arrowSource.fire ();
	}
}
