using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class City : MonoBehaviour {

	[Header("Data displaying")]
	public string cityName;
	public string citySentence;

	[Header("Data not displaying")]
	public string cityRegion;
	public string citySuccess;
	public string rallyChoice1;
	public string rallyChoice2;
	public string rallyChoice3;
	public string rallyChoice4;
	public string rallyChoice5;
	public string rallyChoice6;
	public string rallyChoice7;
	public string rallyChoice8;

	[Header("Child Controls")]
	public Text txtName;
	public Text txtDescription;

	public void ShowPopUp()
	{
		txtName.text = cityName;
		txtDescription.text = citySentence;
		gameObject.SetActive (true);
	}

	public void Travel()
	{
		PlayerAssets.Instance.week++;
		Debug.Log (PlayerAssets.Instance.week);
	}

//	string[] names = {
//		"Bangor (Maine)",
//		"Stowe (Vermont)",
//		"Albany (NY)",
//		"Scranton (PA)",
//		"Cambridge (MA)",
//		"Pawtucket (RI)",
//		"Atlantic City (NJ)",
//		"Washington DC",
//		"Huntington (WV)",
//		"Bowling Green (KY)",
//		"Nashville (TN)",
//		"Denver (CO)",
//		"Tuscaloosa (AL)",
//		"Key West (FL)",
//		"Mobile (AL)",
//		"TEXAS (TEXAS)",
//		"Roswell (NM)",
//		"Emerald City (KS)",
//		"Helena (MT)",
//		"Las Vegas (NV)",
//		"Salt Lake City (UT)",
//		"San Francisco (CA)",
//		"Seattle (WA)"
//	};

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
