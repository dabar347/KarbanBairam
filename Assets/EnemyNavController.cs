using UnityEngine;
using System.Collections;

public class EnemyNavController : MonoBehaviour {

	NavMeshAgent nav;
	Transform target;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
		target = GameObject.Find ("SheepContainer").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(nav.enabled)
			nav.SetDestination(target.position);
	}
}
