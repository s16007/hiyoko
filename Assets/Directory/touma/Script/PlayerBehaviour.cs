using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerBehaviour : MonoBehaviour {
	public Rigidbody2D rigidBody;
	public Collider2D hitCollider;
	public float jumpPower = 20.0f;
	public float jumpTime = 0.3f;

	[SerializeField]
	private int eggValue = 0;
	[SerializeField]
	private int chickenValue = 0;
	[SerializeField]
	private int riceValue = 0;

	public int EggValue{
		get{return eggValue;}
		set{eggValue = value;
			cook();
		}
	}

	public int ChickenValue{
		get{return chickenValue;}
		set{chickenValue = value;
			cook();
		}
	}

	public int RiceValue{
		get{return riceValue;}
		set{riceValue = value;
			cook();
		}
	}

	private bool isGrounded = false;
	public bool isDead = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(jump());
	}

	IEnumerator jump(){
		while(!isDead){
			//接地した状態でタップするとジャンプ
			if((Input.GetMouseButtonDown(0) || Input.touchCount > 0) && isGrounded){
				float time = 0.0f;
				while((Input.GetMouseButton(0) || Input.touchCount > 0) && time < jumpTime){
					rigidBody.velocity = new Vector2(0, jumpPower);
					time += Time.deltaTime;
					yield return null;
				}
			}

			yield return null;
		}
	}

	void cook(){
		if(eggValue > 0 && chickenValue > 0 && riceValue > 0){
			--eggValue;
			--chickenValue;
			--riceValue;

			openDistance(1.0f);
		}
	}

	void damage(){
		openDistance(-2.0f);
	}

	void openDistance(float length){
		//Debug.Log("Open Disntance");

		transform.DOMoveX(transform.position.x + length, 0.5f).SetEase(Ease.OutSine);

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

	void OnTriggerEnter2D(Collider2D other){

		if(other.tag == "TestItem"){
			Debug.Log("Get TestItem");
		}

		if(other.tag == "Obstacle"){
			Debug.Log("Hit Obstacle");
			damage();
		}

		if(other.tag == "Enemy"){
			Debug.Log("Dead");
			isDead = true;
			rigidBody.bodyType = RigidbodyType2D.Kinematic;
			hitCollider.enabled = false;
		}
	}

	/*
	// Update is called once per frame
	void Update () {
		
	}*/
}
