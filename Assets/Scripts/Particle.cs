using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {
	// Use this for initialization
	IEnumerator Start () {
		Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D> ();

		float direction = Random.Range(0, 359); // ランダムな方向を設定
		float speed = Random.Range(10.0f, 20.0f); // 速度

		Vector2 v; // 一時的な速度変数
		v.x = Mathf.Cos (Mathf.Deg2Rad * direction) * speed;
		v.y = Mathf.Sin (Mathf.Deg2Rad * direction) * speed;
		rigidbody.velocity = v;

		// 見えなくなるまで小さくする
		while (transform.localScale.x > 0.01f)
		{
			// 0.01秒ゲームループに制御を返す
			yield return new WaitForSeconds(0.01f);
			// だんだん小さくする
			transform.localScale *= 0.9f;
			// だんだん減速する
			rigidbody.velocity *= 0.9f;
		}

		// 消滅
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// プレハブ
	static GameObject _prefab = null;

	/// パーティクルの生成
	public static Particle Add(float x, float y)
	{
		// プレハブを取得
		_prefab = Resources.Load ("Prefabs/" + "Particle") as GameObject;
		// プレハブからインスタンスを生成
		Vector3 pos = new Vector3 (x, y, 0);
		GameObject g = Instantiate (_prefab, pos, Quaternion.identity) as GameObject;
		Particle obj = g.GetComponent<Particle> ();
		float direction = 0.0f;
		float speed = 0.0f;

		Rigidbody2D rigidbody = obj.gameObject.GetComponent<Rigidbody2D> ();
		Vector2 v; // 一時的な速度変数
		v.x = Mathf.Cos (Mathf.Deg2Rad * direction) * speed;
		v.y = Mathf.Sin (Mathf.Deg2Rad * direction) * speed;
		rigidbody.velocity = v;

		return obj;
	}
}
