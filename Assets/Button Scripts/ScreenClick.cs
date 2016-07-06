using UnityEngine;
using System.Collections;

public class ScreenClick : MonoBehaviour {

	public UnityEngine.UI.Text goldCount;
	public float gold=0;
	public float goldPerClick=1;
	public float goldPerSecond=0;
	public int sec;
	private float startTime;
	private float timeCount;


	void Start(){
		startTime = Time.time;
	}

	void Update (){
		timeCount = Time.time- startTime;
		sec = (int)(timeCount % 60f);
		if (sec >= 1) {
			gold += goldPerSecond;
			startTime = Time.time;
		}
		goldCount.text = "Gold: " + suffex (gold) + "\nGold/Sec: " + suffex (goldPerSecond);
	}
	public void Click (){
		gold += goldPerClick;
	}

	private string suffex(float largeN){
		string result = largeN.ToString ();
		if (largeN < 1000000000 && largeN >= 1000000) {
			result= (largeN / 1000000).ToString () + "Million";
		}
		if (largeN < 1000000000000 && largeN >= 1000000000){
			result = (largeN / 1000000000).ToString () + "Billion";
		}
		if (largeN < 1000000000000000 && largeN >= 1000000000000) {
			result = (largeN / 1000000000000).ToString () + "Trillion";
		}
		if (largeN < 1000000000000000000 && largeN >= 1000000000000000) {
			result = (largeN / 1000000000000000).ToString () + "Quadrillion";
		}
		if (largeN < 10000000000000000000 && largeN >= 1000000000000000000) {
			result = (largeN / 1000000000000000000).ToString () + "Quintillion";
		}
//		if (largeN < 1000000000000000000000 && largeN >= 1000000000000000000) {
//			result = (largeN / 1000000000000000000).ToString () + "Sextillion";
//		}
		//if (largeN < 1000000000000000000000 && largeN >= 1000000000000000000) {
		//	result = (largeN / 1000000000000000000).ToString () + "Septillion";
	//	}
		return result;
	}
}		