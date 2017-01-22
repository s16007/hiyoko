using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviourMock : MonoBehaviour {
	public enum itemType{
		Egg = 0,
		Chicken,
		Rice
	}

	public itemType item = itemType.Egg;

	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		/*
		Vector3 pos = transform.position;
		pos.x -= speed * Time.deltaTime;
		transform.position = pos;
		*/
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			PlayerBehaviour player = other.gameObject.GetComponent<PlayerBehaviour>();

			switch(item){
			case itemType.Egg:
				++player.EggValue;
				Debug.Log("Get Egg");
				break;

			case itemType.Chicken:
				++player.ChickenValue;
				Debug.Log("Get Chicken");
				break;

			case itemType.Rice:
				++player.RiceValue;
				Debug.Log("Get Rice");
				break;
			default:
				break;

			}
			Destroy(this.gameObject);
		}
	}
}
