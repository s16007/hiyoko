using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSetter: MonoBehaviour {

	public GameObject[] items;
	public GameObject itemHolder;

	GameObject ChoiceItem(){
		GameObject prefab;

		int index = Random.Range (0, items.Length);
		prefab = items [index];

		return prefab;
	}

	public void SetItem(){
		GameObject item =
			(GameObject)Instantiate (
				ChoiceItem (),
				new Vector2(transform.localPosition.x, transform.localPosition.y),
				Quaternion.identity
			);
				
		item.transform.parent = itemHolder.transform;
	}

	void Start(){
		SetItem ();
	}


}
