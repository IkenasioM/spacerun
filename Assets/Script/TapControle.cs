﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControle : MonoBehaviour {
	Animator animator;

	void Start()
	{
		animator = GetComponent<Animator> ();
	}

	void Update()
	{
		animator.SetBool ("Middle to left", true);
	}
}
