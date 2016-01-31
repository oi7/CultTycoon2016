using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerAssets : MonoBehaviour {

	public int money;
	public int follower;
	public int week;

	public static PlayerAssets Instance = new PlayerAssets();

	public PlayerAssets(int mon, int fol, int wee)
	{
		money = mon;
		follower = fol;
		week = wee;
	}	

	public PlayerAssets()
	{
		money = 0;
		follower = 0;
		week = 0;
	}

		
	void Rally(int increasedFollower, int rallyCost)
	{
		follower += increasedFollower;
		money -= rallyCost;
	}

	void Purchase(int purchaseCost)
	{
		money -= purchaseCost;

	}

	void Travel(int travelCost)
	{
		money -= travelCost;
	}

	void Fundraise(int increasedMoney)
	{
		money += increasedMoney;
	}
}
