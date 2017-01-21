using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour {

	GameObject itemer;
	Player takeItem;

	public Text LabelGohan;
	public Text LabelNiku;
	public Text LabelTamago;

	int no1 = 0;
	int no2 = 0;
	int no3 = 0;

	// Use this for initialization
	void Start () { 

		itemer = GameObject.Find ("Player/hashiru");
		takeItem = itemer.GetComponent<Player> ();

		LabelGohan.text = "×0";
		LabelNiku.text = "×0";
		LabelTamago.text ="×0";

	}

	void Update(){

		if (takeItem.wake) {
			ItemGet ();
			takeItem.wake = false;
		}
	}

	void ItemGet(){
		string itemName = takeItem.getItem;
		if ( itemName == "gohan(Clone)") {
			no1 += 1;
			LabelGohan.text = "×" + no1;
		} else if (itemName == "niku(Clone)") {
			no2 += 1;
			LabelNiku.text = "×" + no2;
		} else if (itemName == "tamago(Clone)") {
			no3 += 1;
			LabelTamago.text = "×" + no3;
		}
	}
}
