﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_3D : MonoBehaviour {
	public bool localDebug = false;	
	public GameObject debugTextPrefab;
	private GameObject text;
	public Transform lookTarget;
	public string prefix;
	public Vector3 rotationOffset;
	public Vector3 positionOffset;
	public float scale = 1.0f;

	void Start() {
		if (localDebug) {
			text = Instantiate(debugTextPrefab, transform.position + positionOffset, transform.rotation);
			text.transform.localScale = new Vector3(scale, scale, scale);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(localDebug) {
			text.GetComponent<TextMesh>().text = prefix + ": " + transform.localEulerAngles.ToString();
			text.transform.position = transform.position;
			text.transform.LookAt(lookTarget);
			text.transform.Rotate(rotationOffset);
		}
	}
}