using UnityEngine;
using System.Collections;

public class PlayerAssets : MonoBehaviour {

	public int money;
	public int cult;
	public int item;

	public class Assets
	{

		public Assets(int mon, int cul, int ite)
		{
			money = mon;
			cult = cul;
			item = ite;
		}	

		public Assets()
		{
			money = 0;
			cult = 0;
			item = 0;
		}

	}
		
	int Rally(int mon, int cul)
	{
		money += mon;
		cult += cul;
	}

	int Purchase(int purchaseCost)
	{
		money -= purchaseCost;
		item += 1;
	}

	int Travel(int travelCost)
	{
		money -= travelCost;
	}

	int Fundraise(int mon)
	{
		money += mon;
	}

	// Use this for initialization
	void Awake () {
		
	}

	void Start () {
		Assets myAssets = new Assets();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
