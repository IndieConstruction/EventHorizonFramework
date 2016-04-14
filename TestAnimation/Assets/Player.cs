﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			animator.SetBool("IsWalking", true);
		}else{
			animator.SetBool("IsWalking", false);

		}
	
	}
}