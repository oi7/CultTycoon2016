using UnityEngine;
using System.Collections;

public class ActivateObject : MonoBehaviour {

	public GameObject myObject;
	public void activate()
	{
		myObject.SetActive(true);
	}
	public void deactivate()
	{
		myObject.SetActive(false);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
