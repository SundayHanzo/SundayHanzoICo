using UnityEngine;
using System.Collections;

public class GamePlayView : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showArrowInInitializePosition(GameObject arrowObject){
		arrowObject.transform.position = new Vector3 (0, 0, 0);
	}
}
