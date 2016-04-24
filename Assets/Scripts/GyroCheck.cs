using UnityEngine;
using System.Collections;

public class GyroCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.gyro.enabled == false) {
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
