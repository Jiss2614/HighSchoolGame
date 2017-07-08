using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("left")) {
			transform.Translate (-1, 0, 0);
		}
		if (Input.GetKeyDown ("right")) {
			transform.Translate (1, 0, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (-1, 0, 0);
	}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (1, 0, 0);
		}		
  }
}
