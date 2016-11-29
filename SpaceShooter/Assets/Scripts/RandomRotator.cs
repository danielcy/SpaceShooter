﻿using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour 
{
	public float tumble;

	private Rigidbody rigidbody;

	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
	}

}
