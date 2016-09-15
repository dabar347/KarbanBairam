using UnityEngine;
using System.Collections;

public class KillController : MonoBehaviour {

	GameObject sheep;
	NavMeshAgent nav;

	// Use this for initialization
	void Start () {
		sheep = GameObject.Find ("SheepContainer");
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() { 
		sheep.GetComponent<DathController> ().Die ();
		nav.enabled = false;
	}
}
