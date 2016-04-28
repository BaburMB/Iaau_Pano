#pragma strict

function Start () {
 gameObject.GetComponent.<Animation>().wrapMode = WrapMode.Loop; 
 gameObject.GetComponent.<Animation>().Play("Logo_flip"); 
}

function Update () {

}