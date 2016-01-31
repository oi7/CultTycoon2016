using UnityEngine;
using System.Collections;

public class RallyButton : MonoBehaviour {

	public bool active = true;
	public int score = 0;
	public GameObject myObject;
	public RallyBehavior rallyBehavior;
	public AudioSource buttonClick;
	public AudioSource speechVoice;

	public void ClickHandler () {
		if (active) {
			buttonClick.Play();
			speechVoice.Play();
			active = false;
			rallyBehavior.AddPoints(score);
		}
	}

	public void Activate () {
		active = true;
		myObject.SetActive(true);
	}

	public void Deactivate () {
		active = false;
		myObject.SetActive(false);
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
}