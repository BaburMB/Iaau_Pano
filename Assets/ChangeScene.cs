using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Used this for change scene
	public void ChangeToScene (string where){
		Application.LoadLevel (where);
	}

}
