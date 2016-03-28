using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour , IAttack {

	private Agent target;
	public Agent Target {
		get{return target;}
		set { 

		}
	}
	private float attackValue = 2f;
	public float AttackValue {
		get {return attackValue;}
		set{

		}
	}

	public GameController gc;
	/// <summary>
	/// Speed of movement
	/// </summary>

	public string Name = "NoName";
	public float MoveSpeed;
	public float Health;
	public int Level = 1;

/// <summary>
/// La salute massima è moltiplicata per il livello 
/// </summary>
	private float maxHealth =10;
	public float MaxHealth{
		get {
			return maxHealth;
		}
		set {
			maxHealth = maxHealth*Level;
			maxHealth = value;

		}
	}

	void Awake () {
		if (gc == null) {
			gc = FindObjectOfType<GameController>();
		}
	}

	// Use this for initialization
	void Start () {
		#region event : Tiny element script tolto perchè inutlizzato.
		// dà un valore all'attacco
		//AttackValue = 2;
		//Target = FindObjectOfType<Player>();
		// attacca il Target
		//Attack(AttackValue, Target);
		#endregion event end
	}
	
	// Update is called once per frame
	 void Update () {
	 
	}

	/// <summary>
	/// Aggiorna il valore della speed attuale (moveSpeed) sommando il valore del parametro di entrate
	/// </summary>
	/// <param name="peedToAddOrRemove">Valore da aggiungere (se è negativo si sottrae).</param>

	public void UpdateSpeed (float SpeedToAddOrRemove) {
		MoveSpeed = MoveSpeed + SpeedToAddOrRemove;
		// per non fare andare la velocità in negativo 
		if (MoveSpeed<=0) { 
			MoveSpeed = 0;
		}
	}
	/// <summary>
	/// Attacks me.
	/// </summary>
	/// <param name="damage">Damage ( che è uguale all'attacco dell'Agent )</param>
	public void DecreaseHealth (float damage) {

		Health = Health - damage;
		if (Health <= 0){
			OnDeath();
		}

	}


	// fai qualcosa quando muori
	protected virtual void OnDeath () {

	}

	/// <summary>
	/// Attacca con un danno specificato nel parametro.
	/// </summary>
	/// <param name="damage">Damage.</param>
	public void Attack (float damage, Agent target ){
		Debug.Log ("sto attaccando");
		target.DecreaseHealth(damage);
	}
	}

	

