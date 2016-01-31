using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayAssets : MonoBehaviour {

	public Text money;
	public Text follower;
	public Text week;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		money.text = "Money: " + PlayerAssets.Instance.money.ToString();
		follower.text = "Follower: " + PlayerAssets.Instance.follower.ToString();
		week.text = "Week: " + PlayerAssets.Instance.week.ToString();
	}
}
