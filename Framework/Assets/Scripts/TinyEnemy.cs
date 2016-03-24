using UnityEngine;
using System.Collections;

public class TinyEnemy : Agent, IAttack, ISpawn {
	public Agent Target {
		get;
		set;
	}

	public float AttackValue {
		get;
		set;
	}
	/// <summary>
	/// Attacca con un danno specificato nel parametro.
	/// </summary>
	/// <param name="damage">Damage.</param>
	public void Attack (float damage, Agent target ){
		Debug.Log ("sto attaccando");
		target.DecreaseHealth(damage);
	}

	// spawna piccoli nemici
	public void SpawnMe() {

	}

	void Start () {
		// dà un valore all'attacco
		AttackValue = 2;
		//Target = FindObjectOfType<Player>();
		// attacca il Target
		Attack(AttackValue, Target);
	}
}
