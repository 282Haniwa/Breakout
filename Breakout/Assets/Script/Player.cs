using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	// speedを制御する
	public float speed = 10;
	public float limit_top = 0;
	public float limit_bottom = 0;
	public float limit_left = 0;
	public float limit_right = 0;

	void FixedUpdate ()
	{
		Vector3 tmp = GameObject.Find<Player>.transform.position;
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		// xとyにspeedを掛ける
		if (x > 0 && tmp.x <= limit_right) {
			transform.Translate(x * speed, 0, 0);
		} else if (x < 0 && tmp.x >= limit_left) {
			transform.Translate(x * speed, 0, 0);
		}

		if (z > 0 && tmp.z <= limit_top) {
			transform.Translate(0, 0, z * speed);
		} else if (z < 0 && tmp.z >= limit_bottom){
			transform.Translate(0, 0, z * speed);
		}
	}
}