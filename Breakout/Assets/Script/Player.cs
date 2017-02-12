using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	// speedを制御する
	public float speed = 10;
	public float limit_top = 0;
	public float limit_bottom = 0;
	public float limit_right = 0;
	public float limit_left = 0;

	void FixedUpdate ()
	{
		float x = this.transform.position.x;
		float z = this.transform.position.z;

		float deltax = Input.GetAxis ("Horizontal");
		float deltaz = Input.GetAxis ("Vertical");

		// xとyにspeedを掛ける
		if (limit_right != limit_left) {
			if (deltax > 0 && x <= limit_right) {
				transform.Translate (deltax * speed, 0, 0);
			} else if (deltax < 0 && x >= limit_left) {
				transform.Translate (deltax * speed, 0, 0);
			}
		}
		if (limit_top != limit_bottom) {
			if (deltaz > 0 && z <= limit_top) {
				transform.Translate (0, 0, deltaz * speed);
			} else if (deltaz < 0 && z >= limit_bottom) {
				transform.Translate (0, 0, deltaz * speed);
			}
		}
	}
}