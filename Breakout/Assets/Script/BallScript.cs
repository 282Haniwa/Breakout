using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	public float speedx = 2;
	public float speedz = 2;
	public AudioClip sound1;
	public AudioClip sound2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		if (Input.GetButtonUp ("Jump") && rigidbody.velocity == new Vector3 (0, 0, 0)) {
			rigidbody.AddForce (speedx, 0, speedz);
		}
	}
	void OnCollisionEnter(Collision collision) {
		AudioSource audio = gameObject.GetComponent<AudioSource> ();
		if (collision.gameObject.tag == "Block") {
			audio.PlayOneShot (sound2);
		} else {
			audio.PlayOneShot (sound1);
		}
	}
}
