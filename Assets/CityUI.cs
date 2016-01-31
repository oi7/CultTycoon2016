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

	public AudioSource musicRural;
	public AudioSource musicSuburban;
	public AudioSource musicUrban;

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
		if (City.currentCityCategory == 0)
			musicRural.Play ();
		else if (City.currentCityCategory == 1)
			musicSuburban.Play ();
		else
			musicUrban.Play ();
			
		txtName.text = PlayerAssets.Instance.currCityName;
		txtDescription.text = PlayerAssets.Instance.currCityDescription;
		StartCoroutine(AdvancePrompt());
	}

	// Update is called once per frame
	void Update () {

	}
}