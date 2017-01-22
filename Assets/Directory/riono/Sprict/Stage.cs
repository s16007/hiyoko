using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour {

	GameObject itemer;
	Player takeItem;

	// 食材の獲得数のテキスト
	public Text LabelGohan;
	public Text LabelNiku;
	public Text LabelTamago;

	// 食材の獲得数
	public int no1 = 0;
	public int no2 = 0;
	public int no3 = 0;

	// Use this for initialization
	void Start () { 
		// Playerクラスを利用可能にする
		itemer = GameObject.Find ("Player/hashiru");
		takeItem = itemer.GetComponent<Player> ();

		// 食材の獲得数を0にする
		LabelGohan.text = "×0";
		LabelNiku.text = "×0";
		LabelTamago.text ="×0";

	}

	void Update(){

		// Playerが食材を取得(Destroy)したら処理をする
		if (takeItem.wake) {
			ItemGet ();
			takeItem.wake = false;
		}
	}

	// 食材個数のUIの更新
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
