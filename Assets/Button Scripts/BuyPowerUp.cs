using UnityEngine;
using System.Collections;

public class BuyPowerUp : MonoBehaviour {

	public ScreenClick sClick;
	public int count;
	public float cost;
	public UnityEngine.UI.Text text;
	public string powerUpName;

	// Use this for initialization
	void Start () {
		text.text = powerUpName + " " + cost; 
	}
	
	// Update is called once per frame
	void Update () {
		sClick.goldPerSecond = (Mathf.Round (sClick.goldPerClick * (count / 10f)));
	}

	public void buyPowerUp(){
		if (cost <= sClick.gold) {
			sClick.gold -= cost;
			count++;
			cost += (Mathf.Round (cost * 1.15f));
			text.text = powerUpName + " " + cost; 
		}
	}
}
