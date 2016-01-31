using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerAssets {

	public int money;
	public int cult;
	public int item;

	public static PlayerAssets Instance = new PlayerAssets();

	public PlayerAssets(int mon, int cul, int ite)
	{
		money = mon;
		cult = cul;
		item = ite;
	}	

	public PlayerAssets()
	{
		money = 0;
		cult = 0;
		item = 0;
	}

		
	int Rally(int cul)
	{
		cult += cul;
		return cult;
	}

	int Purchase(int purchaseCost)
	{
		money -= purchaseCost;
		return money;

	}

	int Travel(int travelCost)
	{
		money -= travelCost;
		return money;
	}

	int Fundraise(int mon)
	{
		money += mon;
		return money;
	}
}
