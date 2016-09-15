using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

	public GameObject dzhigit;

	// Use this for initialization
	void Start () {
		Instantiate (dzhigit);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
