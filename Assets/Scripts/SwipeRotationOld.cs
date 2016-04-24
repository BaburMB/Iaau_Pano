using UnityEngine;
using System.Collections;

public class SwipeRotationOld : TouchLogic {
	public float rotateSpeed = 100.0f;
	public int invertPitch = 1;
	// Use this for initialization
	private float pitch = 0.0f,
	yaw = 0.0f;

	void OnTouchMovedAnywhere(){
		if (Input.touchCount == 1) {
			//deltaPosition change frequency causes acceleration
			pitch -= Input.GetTouch (0).deltaPosition.y * rotateSpeed * invertPitch * Time.deltaTime;
			yaw -= Input.GetTouch (0).deltaPosition.x *  rotateSpeed * invertPitch * Time.deltaTime;
			pitch = Mathf.Clamp (pitch, -80, 80);
			//do the rotations of our camera
			this.transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
		}
	}}
