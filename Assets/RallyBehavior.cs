using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RallyBehavior : MonoBehaviour {

	public int rallySize; // 0: small, 1: medium, 2: large
	public int pointMin = 0;
	public int pointMax = 1;
	public int round = 0; // round # (0-2)

	public List<RallyChoice> rallyChoices;
	public Text textBox;
	public Text textBox2;

	// Assign points to rally choices, append to list
	void AssignChoices (string choiceA, string choiceB) {
		if (Random.value < .5) {
			rallyChoices.Add (new RallyChoice (choiceA, pointMin));
			rallyChoices.Add (new RallyChoice (choiceB, pointMax));
		} else {
			rallyChoices.Add (new RallyChoice (choiceA, pointMax));
			rallyChoices.Add (new RallyChoice (choiceB, pointMin));
		}
	}

	// Use this for initialization
	void Start () {
		if (rallySize > 0)
			pointMax = 2;
		if (rallySize == 2)
			pointMin = 1;

		rallyChoices = new List<RallyChoice>();

		// TODO: access CityInfo
		AssignChoices("Ransack the homes of the elderly.", "Pray to the Fly God.");
		AssignChoices("My loyal followers.", "My foolish minions.");
		AssignChoices("Believe in the cause.", "Do my bidding.");

		textBox = GetComponentsInChildren<Text>()[0];
		textBox2 = GetComponentsInChildren<Text>()[1];

		textBox.text = rallyChoices[0].text;
		textBox2.text = rallyChoices[1].text;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
