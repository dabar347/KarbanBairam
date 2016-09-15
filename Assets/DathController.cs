using UnityEngine;
using System.Collections;

public class DathController : MonoBehaviour {

	public GameObject aliveModel;
	public GameObject deadModel;
	CharacterMovement cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){

	}

	public void Die() {
		aliveModel.SetActive (false);
		deadModel.SetActive (true);
		cc.enabled = false;
	}

}
