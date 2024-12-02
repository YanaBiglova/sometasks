using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour {


	private Transform _playerTransform;

	void Start () {

		_playerTransform = GameObject.FindWithTag("Player").transform;

	}
	

	void Update () {


		float distance = Vector3.Distance(transform.position, _playerTransform.position);

		if (distance < 2.8f)
        {
			Destroy(gameObject);
			FindObjectOfType<coinCounter>().Number += 1;
        }
	}
}

