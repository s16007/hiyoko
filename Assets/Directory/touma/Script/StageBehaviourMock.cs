using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBehaviourMock : MonoBehaviour {
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x -= speed * Time.deltaTime;
		transform.position = pos;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "DestroyStage"){
			Destroy(this.gameObject);
		}
	}
}
