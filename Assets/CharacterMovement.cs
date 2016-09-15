using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	CharacterController cc;
	float speed = 5f;
	Vector3 smVector = new Vector3 ();
	float rotThreshold = 0.001f;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		smVector.x = Input.GetAxis ("Horizontal") * speed;
		smVector.z = Input.GetAxis ("Vertical") * speed;

		if(Mathf.Abs(smVector.x) > rotThreshold || Mathf.Abs(smVector.y) > rotThreshold)
			transform.rotation = Quaternion.Euler (new Vector3 (0, Mathf.Rad2Deg*Mathf.Atan2(smVector.x,smVector.z), 0));

		cc.SimpleMove (smVector);
		if (Input.GetKey (KeyCode.Space)) {
			smVector.y = 7f;
			cc.Move (smVector * Time.deltaTime);
			smVector.y = 0f;
		}
	
	}
}
