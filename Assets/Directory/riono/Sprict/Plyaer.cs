using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyaer : MonoBehaviour {
		// speedを制御する
	public float thrust = 10;

	Rigidbody2D rd;
	Collider cd;
	GameObject item;

	Item itemCo = new Item ();
//	GameObject item;



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
		Destroy (col.gameObject);

	}
}

