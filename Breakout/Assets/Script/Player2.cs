using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	public float accel = 1000.0f;//加える力の大きさ
	int flag = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//力を加える
		if (Input.GetButtonUp ("Jump")) {
			flag = 1;
		}
		if (flag == 1) {
			this.GetComponent<Rigidbody>().AddForce(transform.right*Input.GetAxisRaw("Horizontal")*accel, ForceMode.Impulse);
		}

	}
}