﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class RallyBehavior : MonoBehaviour {

	public int rallySize; // 0: small, 1: medium, 2: large
	public int pointMin = 0;
	public int pointMax = 1;
	public int round = 0; // round # (0-5)
	public int score = 0; // 0-1: fail, 2-6: success, 7-8: crit

	public AudioSource bgMusic;

	public AudioSource crowdBoo;
	public AudioSource crowdNeutral;
	public AudioSource crowdCheer;

	public AudioSource goodReaction;
	public AudioSource badReaction;

	public AudioSource dialogClick;

	public AudioSource speechVoice1;
	public AudioSource speechVoice2;
	public AudioSource speechVoice3;
	public AudioSource speechVoice4;
	public AudioSource speechVoice5;

	public string failText = "Fail";
	public string successText = "Success";
	public string critText = "Critical";

	private List<string> rallyPrompts = new List<string> (new string[] {
		"Welcome " + PlayerAssets.Instance.followerName + ", my children!",
		"I know your spiritual happiness depends on...",
		"I have had a vision. The true way to salvation is...",
		"Join " + PlayerAssets.Instance.cultName + ", and together we will...",
		"Will you keep living in ignorance, or join my flock in...",
		PlayerAssets.Instance.cultSlogan + "!"
	});

	public List<RallyChoice> rallyChoices;
	public Text promptBox;
	public Text textBox;
	public Text textBox2;
	public int textSize;

	public RallyButton button;
	public RallyButton button2;

	// Assign points to rally choices, append to list
	void AssignChoices (string choiceA, string choiceB) {
		// random version – correct answer is arbitrarily decided
		/*
		if (Random.value < .5) {
			rallyChoices.Add (new RallyChoice (choiceA, pointMin));
			rallyChoices.Add (new RallyChoice (choiceB, pointMax));
		} else {
			rallyChoices.Add (new RallyChoice (choiceA, pointMax));
			rallyChoices.Add (new RallyChoice (choiceB, pointMin));
		}
		*/

		// "correct answer" version - choice A is always correct
		if (Random.value < .5) {
			rallyChoices.Add (new RallyChoice (choiceA, pointMax));
			rallyChoices.Add (new RallyChoice (choiceB, pointMin));
		} else {
			rallyChoices.Add (new RallyChoice (choiceB, pointMin));
			rallyChoices.Add (new RallyChoice (choiceA, pointMax));
		}
	}

	// Add points based on button press, state transition
	public void AddPoints (int points) {
		Debug.Log("round: " + round);
		StartCoroutine(PlayReaction(points));
		score += points;
		Debug.Log("points: " + points);
		Debug.Log("score: " + score);
		round += 1;

		if (button.active)
			button.Deactivate();
		else
			button2.Deactivate();

		StartCoroutine(UpdateLabels());
	}

	// Play reaction sounds
	IEnumerator PlayReaction(int points) {
		yield return new WaitForSeconds (2);
		if (points == 0)
			badReaction.Play ();
		else
			goodReaction.Play ();
	}

	// Update labels after each round
	IEnumerator UpdateLabels() {
		yield return new WaitForSeconds(4);

		button.Deactivate();
		button2.Deactivate();

		dialogClick.Play();
		switch (round) {
			case 2:
				speechVoice3.Play();
				break;
			case 3:
				speechVoice4.Play();
				break;
			case 4:
				speechVoice5.Play();
				break;
			default:
				speechVoice1.Play();
				break;
		}
		promptBox.text = rallyPrompts[round];

		if (round < 5) {
			textBox.text = rallyChoices [2 * (round - 1)].text;
			textBox2.text = rallyChoices [2 * (round - 1) + 1].text;

			button.score = rallyChoices [2 * (round - 1)].score;
			button2.score = rallyChoices [2 * (round - 1) + 1].score;

			button.Activate();
			button2.Activate();
		} else {
			Debug.Log("score: " + score);
			yield return new WaitForSeconds (1);
			bgMusic.Stop();
			if (score < 2) {
				crowdBoo.Play ();
				promptBox.text = failText;
			} else if (score > 6) {
				crowdCheer.Play ();
				promptBox.text = critText;
			} else {
				// crowdNeutral.Play();
				crowdCheer.Play ();
				promptBox.text = successText;
			}
			yield return new WaitForSeconds(5);
				if (PlayerAssets.Instance.week >= 10) {
					SceneManager.LoadScene ("EndGame");
				} else {
					SceneManager.LoadScene ("CultTycoon2016");
				}
		}
	}

	// Use this for initialization
	void Start () {
		if (rallySize > 0)
			pointMax = 2;
		if (rallySize == 2)
			pointMin = 1;

		rallyChoices = new List<RallyChoice>();

		// TODO: get choices from CityInfo
		AssignChoices("making America great again.", "comfortable flannel shirts.");
		AssignChoices("to rename Maine to Canada 2.", "BUY MORE FLANNEL!");
		AssignChoices("drink the sweet nectar of America.", "do so much winning!");
		AssignChoices("spreading the gospel of patchworked button shirts?", "praying to the based god?");

		promptBox = GetComponentsInChildren<Text>()[0];
		textBox = GetComponentsInChildren<Text>()[1];
		textBox2 = GetComponentsInChildren<Text>()[2];

		button = GetComponentsInChildren<RallyButton>()[0];
		button2 = GetComponentsInChildren<RallyButton>()[1];

		button.Deactivate();
		button2.Deactivate();

		dialogClick.Play();
		speechVoice1.Play();
		promptBox.text = rallyPrompts[0];

		StartCoroutine(AdvancePrompt());
	}

	// Advance prompt after round 0
	IEnumerator AdvancePrompt() {
		yield return new WaitForSeconds(4);

		dialogClick.Play();
		speechVoice2.Play();
		promptBox.text = rallyPrompts[1];

		textBox.text = rallyChoices[0].text;
		textBox2.text = rallyChoices[1].text;

		button.score = rallyChoices[0].score;
		button2.score = rallyChoices[1].score;

		button.Activate();
		button2.Activate();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
