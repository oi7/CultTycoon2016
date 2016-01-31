using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayBackground : MonoBehaviour {

	public Image background;
	public Sprite[] backgrounds;

//	public Sprite background;

	// Use this for initialization
	void Start () {
		background.sprite = backgrounds [City.currentCityCategory];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
