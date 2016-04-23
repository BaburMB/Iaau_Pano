using UnityEngine;
using System.Collections;

public class ChangeViewMode : MonoBehaviour {
	public GameObject c1;
	public GameObject c2;


	void Click(string camera1, string camera2) {

		c1.SetActive (true);
		c2.SetActive (false);
	}

	}
