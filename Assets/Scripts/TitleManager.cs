using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		GUIStyle style = new GUIStyle();
		// フォントサイズ設定
		style.fontSize = 32;
		// 中央揃え
		style.alignment = TextAnchor.MiddleCenter;

		// フォントの位置
		float w = 128; // 幅
		float h = 32; // 高さ
		float px = Screen.width / 2 - w / 2;
		float py = Screen.height / 2 - h / 2;

		// フォント描画
		Rect rect = new Rect(px, py, w, h);
		GUI.Label(rect, "CLICK GAME", style);

		// ボタンは少し下にずらす
		py += 60;
		if (GUI.Button(new Rect(px, py, w, h), "START"))
		{
			// メインゲーム開始
			Application.LoadLevel("Main");
		}
	}
}
