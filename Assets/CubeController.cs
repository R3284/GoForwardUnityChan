﻿using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start ()
	{
	}

	private void OnCollisionEnter2D (Collision2D collision)
	{
		
	
		if (collision.gameObject.tag == "CubePrefab") {
			//音を鳴らす
			GetComponent<AudioSource> ().Play ();
		}

		if (collision.gameObject.tag == "ground") {
			//音を鳴らす
			GetComponent<AudioSource> ().Play ();
		}
	}
	// Update is called once per frame
	void Update ()
	{
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);


		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
			
	
		}

	}
				
}
		