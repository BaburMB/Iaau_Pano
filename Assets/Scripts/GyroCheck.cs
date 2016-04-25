using UnityEngine;
using System.Collections;

public class GyroCheck : MonoBehaviour {
	// bool check = true;
	private float a;
	void Start () {
		Input.gyro.enabled = true;
		//if (Input.gyro.enabled == false){
		//	check = false;
		//} 
		a = Input.gyro.userAcceleration.x;
	}
	
	// Update is called once per frame
	void Update () {
		a = Input.gyro.userAcceleration.x;
		if (a == 0){
			gameObject.SetActive(true);
		}
		else{
			gameObject.SetActive(false);
		}
}
}
