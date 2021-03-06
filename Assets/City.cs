﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class City : MonoBehaviour {

	[Header("Data displaying")]
	public string cityName;
	public string citySentence;

	[Header("Data not displaying")]
	public int cityRegion;
	public int cityCategory;
	public int citySuccess;
	public string rallyChoice1;
	public string rallyChoice2;
	public string rallyChoice3;
	public string rallyChoice4;
	public string rallyChoice5;
	public string rallyChoice6;
	public string rallyChoice7;
	public string rallyChoice8;
	public string rallySummary1;
	public string rallySummary2;
	public string rallySummary3;

	[Header("Child Controls")]
	public Text txtName;
	public Text txtDescription;
	public static int currentCityCategory = 0;

	public void ShowPopUp()
	{
		txtName.text = cityName;
		txtDescription.text = citySentence;
		gameObject.SetActive (true);
		currentCityCategory = cityCategory;

		CityData.currentCityData.rallyChoice1 = rallyChoice1;
		CityData.currentCityData.rallyChoice2 = rallyChoice2;
		CityData.currentCityData.rallyChoice3 = rallyChoice3;
		CityData.currentCityData.rallyChoice4 = rallyChoice4;
		CityData.currentCityData.rallyChoice5 = rallyChoice5;
		CityData.currentCityData.rallyChoice6 = rallyChoice6;
		CityData.currentCityData.rallyChoice7 = rallyChoice7;
		CityData.currentCityData.rallyChoice8 = rallyChoice8;

		CityData.currentCityData.rallySummary1 = rallySummary1;
		CityData.currentCityData.rallySummary2 = rallySummary2;
		CityData.currentCityData.rallySummary3 = rallySummary3;

		PlayerAssets.Instance.currCityName = cityName;
		PlayerAssets.Instance.currCityDescription = citySentence;

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
