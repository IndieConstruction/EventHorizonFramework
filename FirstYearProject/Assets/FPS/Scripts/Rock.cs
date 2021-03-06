﻿using UnityEngine;
using System.Collections;
using EH.FrameWork;
namespace EH.FPS {
public class Rock : MonoBehaviour, ICollectableItem ,IThrowable{
	BasePlayer p;
	Vector3 rockTarget;
	float movespeed = 2f;

	void Start () {
		if (p == null) {
			p = FindObjectOfType<BasePlayer> ();
		}
	}
	void OnTriggerEnter ( Collider other ) {
		Inventory inventory;
		BasePlayer p = other.gameObject.GetComponent<BasePlayer> ();
		if (p != null) {
			inventory = p.GetInventory();
			if(inventory != null){
				inventory.AddItem(this);
				}
		}
	}

	void FixedUpdate(){
		if(rockTarget !=Vector3.zero && rockTarget != transform.position){
			MoveToTarget(rockTarget);
		} else {
			rockTarget = Vector3.zero;//per rendere un vettore null.
		}
	}	

	public void UseItem(){

	}
	public void UseItem(Vector3 TargetPosition){

		rockTarget = TargetPosition;
		//this.transform.position = TargetPosition ;
		this.transform.SetParent(null) ;
	}

	/// <summary>
	/// Muove l'oggetto verso l'obiettivo per il tempo trascorso.
	/// </summary>
	/// <param name="targetTransfom">Target transfom.</param>
	public void MoveToTarget(Vector3 TargetPosition){
		
		transform.LookAt(TargetPosition);
		transform.Translate(Vector3.forward*movespeed*Time.deltaTime);

	}
}
}