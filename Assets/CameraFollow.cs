﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float cameraSpeed;

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target.transform, Vector3.up);
		transform.Translate(-Time.deltaTime * cameraSpeed ,0,0, Space.Self);
	}
}
