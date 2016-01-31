using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class City : MonoBehaviour {

	[Header("Data")]
	public string cityName;
	public string citySentence;

	[Header("Child Controls")]
	public Text txtName;
	public Text txtDescription;

	public void ShowPopUp()
	{
		txtName.text = cityName;
		txtDescription.text = citySentence;
		gameObject.SetActive (true);
//		Debug.Log ("hello");
	}

	string[] names = {
		"Bangor (Maine)",
		"Stowe (Vermont)",
		"Albany (NY)",
		"Scranton (PA)",
		"Cambridge (MA)",
		"Pawtucket (RI)",
		"Atlantic City (NJ)",
		"Washington DC",
		"Huntington (WV)",
		"Bowling Green (KY)",
		"Nashville (TN)",
		"Denver (CO)",
		"Tuscaloosa (AL)",
		"Key West (FL)",
		"Mobile (AL)",
		"TEXAS (TEXAS)",
		"Roswell (NM)",
		"Emerald City (KS)",
		"Helena (MT)",
		"Las Vegas (NV)",
		"Salt Lake City (UT)",
		"San Francisco (CA)",
		"Seattle (WA)"
	};

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
