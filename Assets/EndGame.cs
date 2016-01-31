using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	public void switchs()
	{
		if (PlayerAssets.Instance.week >= 10) {
			SceneManager.LoadScene ("EndGame");
		} else {
			SceneManager.LoadScene ("CultTycoon2016");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
