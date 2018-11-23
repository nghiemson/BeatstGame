﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAnimation : MonoBehaviour {
	public Animator _anim;
	private Animator _swordAnimation;
	// Use this for initialization
	void Start () {
		_anim = GetComponentInChildren<Animator>();
		_swordAnimation = transform.GetChild(1).GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void Move (float move) {
		_anim.SetFloat("Move", Mathf.Abs(move));
	}
	public void Jump(bool jumping)
	{
		_anim.SetBool("Jumping", jumping);

	}
	public void Attack()
	{
		_anim.SetTrigger("Attack");
		_swordAnimation.SetTrigger("SwordAnimation");
	}
   
}
