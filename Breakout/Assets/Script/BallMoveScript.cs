using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveScript : MonoBehaviour {

	public float speedx = 2;
	public float speedz = 2;
	// Use this for initialization
	void Start () {
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidbodyのx軸（横）とz軸（奥）に力を加える
		rigidbody.AddForce(speedx, 0, speedz);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
