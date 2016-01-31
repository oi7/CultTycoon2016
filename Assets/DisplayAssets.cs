using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayAssets : MonoBehaviour {

	public Text money;
	public Text cult;
	public Text item;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		money.text = "Money: " + PlayerAssets.Instance.money.ToString();
		cult.text = "Cult: " + PlayerAssets.Instance.cult.ToString();
		item.text = "Item: " + PlayerAssets.Instance.cult.ToString();
	}
}
