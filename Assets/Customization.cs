using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using System.Collections.Generic;

public class Customization : MonoBehaviour {

	public string cultName;
	public string followerName;
	public string cultSlogan;

	public int inputRound = 0; // name, follower, slogan
	public Text promptText;
	public InputField inputField;

	public AudioSource dialogClick;
	public switchScene ss;

	// Save customizations to PlayerAssets
	void SaveCustomizations() {
		PlayerAssets.Instance.cultName = cultName;
		PlayerAssets.Instance.followerName = followerName;
		PlayerAssets.Instance.cultSlogan = cultSlogan;
	}

	// Use this for initialization
	void Start () {
		dialogClick.Play();
		EventSystem.current.SetSelectedGameObject(inputField.gameObject, null);
	}

	// Update is called once per frame
	void Update () {

		if(inputField.text != "" && Input.GetKey(KeyCode.Return)) {
			dialogClick.Play();
			inputField.ActivateInputField();
			inputField.Select();
			switch (inputRound) {
				case 0:
					cultName = inputField.text;
					inputField.text = "";
					promptText.text = "What are your followers called?";
					break;
				case 1:
					followerName = inputField.text;
					inputField.text = "";
					promptText.text = "What is your cult's slogan?";
					break;
				default:
					cultSlogan = inputField.text;
					inputField.text = "";
					SaveCustomizations();
					ss = new switchScene ("CultTycoon2016");
					ss.switchs();
					break;
			}
			inputRound += 1;
		}
	}
}