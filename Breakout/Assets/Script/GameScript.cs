using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour {
	// Use this for initialization
	public static bool gameFlag = false;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("q")) {
			Application.Quit();
		}
		if (gameFlag) {
			if (Input.GetButtonUp ("Jump")) {
				gameFlag = false;
				BottomScript.outCounter = 0;
				BlockScript.destroyCounter = 0;
				SceneManager.LoadScene("StartScene");
			}
		} else {
			if (BlockScript.destroyCounter == 20) {
				GameObject.Find("Text").transform.FindChild("GameClear Text").gameObject.SetActive (true);
				gameFlag = true;
				Debug.Log(gameFlag);
			}
			if (BottomScript.outCounter >= 1) {
				GameObject.Find("Text").transform.FindChild("GameOver Text").gameObject.SetActive (true);
				Destroy(GameObject.Find("Ball"));
				gameFlag = true;
				Debug.Log(gameFlag);
			}
		}
	}
}
