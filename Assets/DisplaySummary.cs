using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplaySummary : MonoBehaviour {

	public Text title;
	public Text summary;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerAssets.Instance.follower <= 5000) {
			title.text = "Crazy Person";
			summary.text = "Just because you are yelling on the street in a bathrobe doesn’t mean you can call yourself a leader. Get a real job.";
		} else if (PlayerAssets.Instance.follower <= 10000) {
			title.text = "Senior Guru";
			summary.text = "Your good word has national reach. You even have a 501(c3) and cloaks!";
		} else if (PlayerAssets.Instance.follower <= 15000) {
			title.text = "Grand Master";
			summary.text = "You created a spiritual revolution, and aTV show! You’re like Oprah, but for cults.";
		} else {
			title.text = "Supreme Leader";
			summary.text = "Your influence has reached beyond the physical world. Matthew mcconaughey high fives you in space.";
		}
	}
}
