using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
	public Rigidbody2D rigidBody;
	public float jumpPower = 1.0f;
	public float jumpTime = 0.5f;
	public bool isGrounded = false;
	public bool isDead = false;

	// Use this for initialization
	void Start () {

		StartCoroutine(jump());
	}

	IEnumerator jump(){
		while(true){
			if(Input.GetMouseButtonDown(0) && isGrounded){

				//Debug.Log("test");
				float time = 0.0f;
				while(Input.GetMouseButton(0) && time < jumpTime){
					rigidBody.velocity = new Vector2(0, jumpPower);
					time += Time.deltaTime;
					yield return null;
				}
				//rigidBody.velocity = Vector2.zero;
			}

			yield return null;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.collider.tag == "Ground"){
			Debug.Log("Grounded");
			isGrounded = true;
		}
		if(collision.collider.tag == "Enemy"){
			Debug.Log("Dead");
			isDead = true;
		}
	}

	void OnCollisionExit2D(Collision2D collision){
		if(collision.collider.tag == "Ground"){
			Debug.Log("Jump");
			isGrounded = false;
		}
	}

	/*
	// Update is called once per frame
	void Update () {
		
	}*/
}
