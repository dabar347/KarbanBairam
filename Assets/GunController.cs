using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	GameObject[] dzhigits;
	// Use this for initialization
	public GameObject sosiska;
	bool reloaded = true;
	float sosiskaSpeed = 10f;
	// Use this for initial
	void Start () {
		dzhigits = GameObject.FindGameObjectsWithTag ("Dzhigit");
	}

	float GetDistance(GameObject obj){
		return Vector3.Distance (transform.position, obj.transform.position);
	}

	// Update is called once per frame
	void Update () {
		int j = 0;
		float min = GetDistance (dzhigits [0]);
		for (int i = 1; i < dzhigits.Length; i++) {
			float t = GetDistance (dzhigits [i]);
			if (t < min) {
				min = t;
				j = i;
			}
		}

		Vector3 relativePosition = dzhigits [j].transform.position - transform.position;
		transform.rotation = Quaternion.Euler (new Vector3 (0, Mathf.Rad2Deg*Mathf.Atan2(relativePosition.x,relativePosition.z), 0));

		if (Input.GetKey (KeyCode.Z) && reloaded) {
			sosiska.SetActive (true);
			sosiska.GetComponent<Rigidbody> ().AddForce (relativePosition.normalized * sosiskaSpeed);
		}
		if (Input.GetKey (KeyCode.X)) {
			sosiska.transform.position = transform.position;
			sosiska.transform.rotation = transform.rotation;
			sosiska.SetActive (false);
		}

	}
}
