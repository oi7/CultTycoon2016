using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayFollower : MonoBehaviour {

	public Text followerNumber;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		followerNumber.text = PlayerAssets.Instance.follower.ToString();
	}
}
