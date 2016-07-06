using UnityEngine;
using System.Collections;

public class BuyUpgrade : MonoBehaviour {

	public BuyBuilding buildingToUpgrade;
	public ScreenClick sClick;
	public UnityEngine.UI.Text text;
	public float cost;
	public int count;
	public string upgradeName;

	// Use this for initialization
	void Start () {
		count = 0;
		text.text = upgradeName + " " + cost; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void upgrade (){
		if (cost <= sClick.gold) {
			sClick.gold -= cost;
			count++;
			cost +=(Mathf.Round(cost * 1.15f));
			float clickPower = buildingToUpgrade.clickPower;
			float totalPowerAdded = clickPower * buildingToUpgrade.count;
			float totalPowerUpgraded, powerToBeAdded;
			clickPower = (Mathf.Round(clickPower * 1.15f));
			totalPowerUpgraded = clickPower * buildingToUpgrade.count;
			buildingToUpgrade.clickPower = clickPower;
			powerToBeAdded = totalPowerUpgraded - totalPowerAdded;
			sClick.goldPerClick += powerToBeAdded;
			text.text = upgradeName + " " + cost; 
		}
	}
}
