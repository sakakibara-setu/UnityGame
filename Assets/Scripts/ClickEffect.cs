using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour {

	[SerializeField]　ParticleSystem tapEffect;              // タップエフェクト
	[SerializeField]　Camera _camera;                        // カメラの座標

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			// マウスのワールド座標までパーティクルを移動し、パーティクルエフェクトを1つ生成する
			var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
			tapEffect.transform.position = pos;
			tapEffect.Emit(1);
		}
	}
}
