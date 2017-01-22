using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviourMock : MonoBehaviour {
	public SpriteRenderer spriteRenderer;
	public float speed = 0.1f;

	private float offset = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		offset += Mathf.Repeat(speed * Time.deltaTime, 1.0f);
		spriteRenderer.material.SetTextureOffset ("_MainTex", new Vector2 (offset, 0.0f));
	}
}
