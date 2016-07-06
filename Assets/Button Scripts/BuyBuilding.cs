using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyBuilding : MonoBehaviour {

	public ScreenClick sClick;
	public UnityEngine.UI.Text text;
	public float cost;
	public int count=0;
	public float clickPower;
	public string buildingName;
	public GameObject otherT;
	// Use this for initialization
	void Start () {
		text.text = buildingName + " " + cost;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void buy(){
		if(cost<=sClick.gold){
			sClick.gold -= cost;
			count++;
			sClick.goldPerClick += clickPower;
			cost +=(Mathf.Round(cost * 1.15f));
	//		cost+=1;
			text.text = buildingName + " " + cost; 
		}
	}
	public void buyT1(){
		buy();
	}

	public void buyT2(){
		if (cost <= sClick.gold) {
			otherT.GetComponent<Button> ().interactable = false;
			buy ();
		}
	}
}
