using UnityEngine;
using System.Collections;

public class showBuildings : MonoBehaviour {

	// Use this for initialization
	public Animator pannel;
	public Animator otherPannel1;
	public Animator otherPannel2;
	public Animator otherPannel3;
	public bool toggle;
	public ScreenClick sClick;


	void Start () {
		//pannel.SetActive (toggle);
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void toggleClick(){
		toggle = !pannel.GetBool ("isShown");
		if (toggle) {
			pannel.SetBool ("isShown", toggle);
			otherPannel1.SetBool ("isShown", !toggle);
			otherPannel2.SetBool ("isShown", !toggle);
			otherPannel3.SetBool ("isShown", !toggle);
		} else {
			pannel.SetBool ("isShown", toggle);
		}
	}
}