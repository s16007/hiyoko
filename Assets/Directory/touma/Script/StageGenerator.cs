using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour {
	public Vector2 generatePosition;

	public List<GameObject> stageList;

	/*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Stage"){
			Instantiate(
				stageList[Random.Range(0, stageList.Count)],
				generatePosition,
				Quaternion.identity
			);
		}
	}
}
