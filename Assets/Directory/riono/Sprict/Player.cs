using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	// speedを制御する
	public float thrust = 10;

	Rigidbody2D rd;
	public string getItem;
	public bool wake;
	GameObject item;

	// デバッグ用移動
	void FixedUpdate() {

		rd = GetComponent<Rigidbody2D> ();

		if (Input.GetKey (KeyCode.RightArrow)) {
			rd.AddForce (transform.right * thrust);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			rd.AddForce (transform.right * (-thrust));
		}
	}

	// Itemをステージ上から削除
	void OnTriggerEnter2D(Collider2D col){
		getItem = col.gameObject.name;
		Destroy (col.gameObject);
		wake = true;

	}
}

