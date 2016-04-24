using UnityEngine;
using System.Collections;

public class GameButtons : MonoBehaviour {
	public string gotoPlace = "HomeUI";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.LoadLevel (gotoPlace);
	}

}
