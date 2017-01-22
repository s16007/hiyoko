using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class HiyokoBehaviour : MonoBehaviour {
	public PlayerBehaviour player;
	public string resultSceneName;

	public Vector2 gameoverPosition;
	public float slideSpeed = 2.0f;

	// Use this for initialization
	void Start () {
		GameObject playerObject = GameObject.FindWithTag("Player");
		player = playerObject.GetComponent<PlayerBehaviour>();

		StartCoroutine(gameover());
		
	}

	IEnumerator gameover(){
		transform.DOJump(transform.position, 1, 1, 1f).SetLoops(-1);
		while(!player.isDead){
			/*
			float initHeight = transform.position.y;
			transform.position =
				new Vector2(transform.position.x, Mathf.PingPong(Time.time, 0.5f) +5.5f);
				*/
			yield return null;
		}

		transform.DOMove(gameoverPosition, slideSpeed).SetEase(Ease.OutCubic);

		yield return new WaitForSeconds(slideSpeed+10);

		SceneManager.LoadScene(resultSceneName);
	}

	/*
	// Update is called once per frame
	void Update () {
		
	}*/
}
