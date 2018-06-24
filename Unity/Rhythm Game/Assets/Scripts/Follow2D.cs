﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow2D : MonoBehaviour {
	[SerializeField] private Transform followed;
	
	void Update () {
		transform.position = new Vector3(followed.position.x, followed.position.y, transform.position.z);
	}
}
