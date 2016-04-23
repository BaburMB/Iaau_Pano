#pragma strict

var cam1 : GameObject;
var cam2 : GameObject;

 /*
 function Start() {
     cam1.enabled = true;
     cam2.enabled = false;
 }
 
 function Update() {
 
 }
     if (Input.GetTouch(0).phase == TouchPhase.Ended && Input.GetTouch(0).position == cam1.GetComponentsInChildren) {
         cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
     }
     */
  function ChangeCam(){
  cam1.SetActive(false);
cam2.SetActive(false);

  }
  /*cam1 = cam2; 
  Debug.Log (Camera.main.ToString);
 }
 function ChangeCamBack(){
  cam1.enabled = false;
  cam2.enabled = true;
 }
 */