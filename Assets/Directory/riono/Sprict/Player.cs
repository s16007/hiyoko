using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	// speedを制御する
	public float Gravity = 9.8f;
	public float gravityScale = 1.0f;

	public Rigidbody2D rd;
	public string getItem;
	public bool wake;
	GameObject item;

	void Start(){
		rd = GetComponent<Rigidbody2D> ();
	}

	// デバッグ用移動
	void Update() {

		Vector2 vector = new Vector2 ();

		if (Application.isEditor) {
			vector.x = Input.GetAxis ("Horizontal");
			// vector.y = Input.GetAxis ("Vertical");

			rd.AddForce (vector);
		} 
	}
		

	// Itemをステージ上から削除
	void OnTriggerEnter2D(Collider2D col){
		getItem = col.gameObject.name;
		Destroy (col.gameObject);
		wake = true;

	}
}

