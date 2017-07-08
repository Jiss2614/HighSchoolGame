using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	public int takasa = 1;
	public float mawaru = 2.5f;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0, takasa, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (mawaru, 0 , 0);
	}
}
