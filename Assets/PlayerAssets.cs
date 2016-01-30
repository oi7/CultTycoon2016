using UnityEngine;
using System.Collections;

public class PlayerAssets : MonoBehaviour {

	public class Assets
	{
		public int money;
		public int cult;
		public int item;

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

	Assets myAssets = new Assets();

		
	int Rally(int cul)
	{
		myAssets.cult += cul;
		return myAssets.cult;
	}

	int Purchase(int purchaseCost)
	{
		myAssets.money -= purchaseCost;
		return myAssets.money;

	}

	int Travel(int travelCost)
	{
		myAssets.money -= travelCost;
		return myAssets.money;
	}

	int Fundraise(int mon)
	{
		myAssets.money += mon;
		return myAssets.money;
	}

	// Use this for initialization
	void Awake () {
		
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
