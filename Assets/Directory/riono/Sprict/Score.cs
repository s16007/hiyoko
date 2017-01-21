using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scorelabel;

	// 時間計測
	private int starttime;
	private int nowtime;
	private int duration;

	// スコア
	private int score;

	// Use this for initialization
	void Start () {
		// 開始時刻
		starttime = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
			DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

		
	}
	
	// Update is called once per frame
	void Update () {
		// 何秒経過したか
		nowtime = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
			DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

		duration = nowtime - starttime;
		score = CalScore ();

		scorelabel.text = "SCORE : " + score;
	}
		
	int CalScore(){
		// 1秒につき100点追加
		int time = (int)(duration / 1000);
		int cal = time * 100;

		return cal;
		}
}
