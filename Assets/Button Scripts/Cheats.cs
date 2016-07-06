using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {

	public ScreenClick sClick;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void moreGold(){
		sClick.gold += sClick.gold*100;
}
	public void moreGoldPerClick(){
		sClick.goldPerClick += sClick.goldPerClick * 100;
	}
}