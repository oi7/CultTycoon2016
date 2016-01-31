using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

	public string sceneName;
	public void switchs()
	{
		SceneManager.LoadScene (sceneName);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
