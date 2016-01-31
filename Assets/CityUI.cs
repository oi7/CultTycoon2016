using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CityUI : MonoBehaviour {
	public Text txtName;
	public Text txtDescription;
	public Button fundButton;
	public Text orLabel;
	public Button rallyButton;

	// Advance prompt after description
	IEnumerator AdvancePrompt() {
		yield return new WaitForSeconds(4);

		txtDescription.gameObject.SetActive (false);
		fundButton.gameObject.SetActive (true);
		orLabel.gameObject.SetActive (true);
		rallyButton.gameObject.SetActive (true);
	}

	// Use this for initialization
	void Start () {
		txtName.text = PlayerAssets.Instance.currCityName;
		txtDescription.text = PlayerAssets.Instance.currCityDescription;
		StartCoroutine(AdvancePrompt());
	}

	// Update is called once per frame
	void Update () {

	}
}