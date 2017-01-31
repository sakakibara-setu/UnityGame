using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour {
	float width;
	float height;

	public static int Count = 0;

	// Use this for initialization
	void Start () {
		Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D> ();
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();

		width = renderer.bounds.size.x / 2;
		height = renderer.bounds.size.y / 2;

		float direction = Random.Range(0, 359); // ランダムな方向を設定
		float speed = 2; // 速度

		Vector2 v; // 一時的な速度変数
		v.x = Mathf.Cos (Mathf.Deg2Rad * direction) * speed;
		v.y = Mathf.Sin (Mathf.Deg2Rad * direction) * speed;
		rigidbody.velocity = v;

		Count++;
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D> ();

		// カメラの左下座標を取得
		Vector2 min = Camera.main.ViewportToWorldPoint (Vector2.zero);
		// カメラの右上座標を取得する
		Vector2 max = Camera.main.ViewportToWorldPoint (Vector2.one);

		min.x += width;
		min.y += height;
		max.x -= width;
		max.y -= height;

		Vector2 v = rigidbody.velocity; // 一時的な速度変数

		if (transform.position.x < min.x || max.x < transform.position.x)
		{
			// 画面外に出たので、X移動量を反転する
			v.x *= -1;
			rigidbody.velocity = v;

			// 画面内に移動する
			Vector2 pos = transform.position;
			// 画面内に収まるように制限をかける.
			pos.x = Mathf.Clamp (pos.x, min.x, max.x);
			pos.y = Mathf.Clamp (pos.y, min.y, max.y);

			// プレイヤーの座標を反映.
			transform.position = pos;
		}
		if (transform.position.y < min.y || max.y < transform.position.y)
		{
			// 画面外に出たので、Y移動量を反転する
			v.y *= -1;
			rigidbody.velocity = v;
			// 画面内に移動する
			Vector2 pos = transform.position;
			// 画面内に収まるように制限をかける.
			pos.x = Mathf.Clamp (pos.x, min.x, max.x);
			pos.y = Mathf.Clamp (pos.y, min.y, max.y);

			// プレイヤーの座標を反映.
			transform.position = pos;
		}
	}

	public void OnMouseDown()
	{
		Count--;

		// パーティクルを生成
		for (int i = 0; i < 32; i++)
		{
			Particle.Add(transform.position.x, transform.position.y);
		}

		Destroy (gameObject);
	}
}
