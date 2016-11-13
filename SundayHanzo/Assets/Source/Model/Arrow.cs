using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour{
	public int speed;
	public int power;
	public GameObject arrow;
	private Rigidbody arrowRigidBody;
	public int angle;
	private bool isStop;

	// Use this for initialization
	void Start () {
		arrowRigidBody = arrow.GetComponent<Rigidbody> ();
		isStop = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void fire(){
		isStop = false;
		arrowRigidBody.useGravity = true;
		float xforce = power * Mathf.Cos (angle * Mathf.Deg2Rad);
		float yforce = power * Mathf.Sin (angle * Mathf.Deg2Rad);

		Debug.Log ("Force : " + xforce + " , " + yforce);
		arrowRigidBody.AddForce (0, yforce , xforce);

		StartCoroutine ("moveCurve");
	}

	IEnumerator moveCurve(){
		while (!isStop) {
			arrow.transform.LookAt (arrow.transform.position + arrowRigidBody.velocity);
			arrow.transform.Rotate (-90, 0, 0); // angle * Mathf.Deg2Rad
			yield return null;
		}
		yield return null;
	}

	void OnTriggerEnter(Collider col){
		Debug.Log ("Trigger");
		if (col.gameObject.tag == "Target") {
			Debug.Log ("Trigger Target");
			isStop = true;
			arrowRigidBody.velocity = Vector3.zero;
			arrowRigidBody.useGravity = false;
		}
	}

}
