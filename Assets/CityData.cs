using UnityEngine;
using System.Collections;

public class CityData{

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

	public static CityData currentCityData = new CityData();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
