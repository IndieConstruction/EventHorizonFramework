using UnityEngine;
using System.Collections;

public class Enemy : Agent {
	#region variabili per l'audio dell'enemy
	AudioSource audioSource;
	public Sounds DefaultSound;
	public AudioClip Attack;
	public AudioClip Dead;

	public enum Sounds{
		Attack,
		Dead,
	}
	#endregion 
	// Stati del nemico
	public enum AiState {
		Patroling,
		Attack,
		Dead
	}

	float patrolTimerCounter = 0; // contatore per cambio target player
	public float PatrolTimerLimit = 2.00f;
	public float PatrolTimerLimitMin = 2.00f;
	public float PatrolTimerLimitMax = 15.00f;
	Transform targetTransform;
	NavMeshAgent agent;
	// richiama il metodo che setta i comportamenti di ogni stato solo quando necessario
	private AiState currentAiState = AiState.Attack; 
	public AiState ECurrentAiState {
		get{return currentAiState;}
		set{
			if (currentAiState != value){
				currentAiState = value;
				OnChangeState();
			}
			currentAiState = value;
		}
	}
	void Awake () {
		#region iscrizione dell'enemy agli eventi audio
		GameController.EnemyAttacking += HandleEnemyAttacking;
		GameController.EnemyIsDead += HandleEnemyIsDead;
		#endregion
		//PlaySound (DefaultSound); 
	}

	#region funzioni per l'audio
	public void PlaySound(Sounds _soundToPlay){
		switch (_soundToPlay) {
		case Sounds.Attack:
			audioSource.clip = Attack;
			break;
		case Sounds.Dead:
			audioSource.clip = Dead;
			break;
		}
	}
	void HandleEnemyIsDead ()
	{
		PlaySound(Sounds.Dead);
	}

	void HandleEnemyAttacking ()
	{
		PlaySound(Sounds.Attack);
	}
	#endregion

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		gc = GameObject.FindObjectOfType<GameController>();
		ECurrentAiState = AiState.Patroling ;
		targetTransform = SelectRandomPatrolPointTarget();
	

	}
	void Update(){

	}
	void FixedUpdate(){
		updatePatrolCounterAndCheckLimit ();

		if(targetTransform != null){
		    MoveToTargetWithPathFinder();
//			DestroyEnemy ();
		}
		if (MoveSpeed <= 0) {
			DestroyEnemy();
		}
	}
	/// <summary>
	/// Updates the patrol counter and check limit.
	/// </summary>
	void updatePatrolCounterAndCheckLimit(){
		//Aggiorniamo il counter
		patrolTimerCounter = patrolTimerCounter + Time.deltaTime;
		//Confronto il contatore con il limit
		if (patrolTimerCounter >= PatrolTimerLimit) {
			// Seleziono un altro target in modo random
			if (currentAiState == AiState.Patroling) {
				targetTransform = SelectRandomPatrolPointTarget ();
				patrolTimerCounter = 0;
				PatrolTimerLimit = SetPatrolTimerLimit();
			} 

			}
		}


	/// <summary>
	/// Setta il patrol time.
	/// </summary>
	float SetPatrolTimerLimit(){
		float newPatrolTimerLimit = Random.Range(PatrolTimerLimitMin, PatrolTimerLimitMax);
		return newPatrolTimerLimit;
	}

	void OnTriggerStay(Collider other){
		Player p = other.gameObject.GetComponent<Player> ();
		NPC npc = other.gameObject.GetComponent<NPC> ();
		if (p!=null && npc!=null){
			ECurrentAiState = AiState.Attack;
		}
	}


	void OnTriggerExit (Collider other) {

		Player p = other.gameObject.GetComponent<Player> ();
		if (p != null ) {
			targetTransform = null;
			ECurrentAiState = AiState.Patroling;
		}
	}

	#region State Management
	// Setta i comportamenti in base allo stato del nemico
	public void OnChangeState (){
		
		switch (ECurrentAiState) {
			
		case AiState.Patroling:
			SelectTarget();
			break;
			
		case AiState.Attack:
			
			break;
			
		case AiState.Dead:
			DestroyEnemy ();
			break;
			
		}
	}
	#endregion

	#region State Patroling
	/// <summary>
	/// Selects the random target.
	/// </summary>
	/// <returns>The random target.</returns>
	public Transform SelectRandomPatrolPointTarget(){
		ECurrentAiState = AiState.Patroling ;
		int randomPoint = Random.Range (0, gc.EnemyPatrolPoint.Length -1);
		Transform selectedEnemyPatrol = gc.EnemyPatrolPoint [randomPoint];
		return selectedEnemyPatrol;
	}
		// si muove verso il target scelto
	void SelectTarget () {
		
		//if (patrolTimerCounter >= PatrolTimerLimit && currentAiState == AiState.Patroling) {// se il contatore è maggiore del tempo d'attesa, sceglie e segue il patrolPoint

			targetTransform = SelectRandomPatrolPointTarget ();
			patrolTimerCounter = 0; // azzera il contatore
			if (targetTransform != null) { // si muove solo se il target è diverso da null
				MoveToTargetWithPathFinder ();
			} else {
				targetTransform = SelectRandomPatrolPointTarget ();
				//SelectRandomTarget ();
				patrolTimerCounter = 0;
			}
		}
	/// <summary>
	/// Si muove verso il target utilizzando il path finder
	/// </summary>
	void MoveToTargetWithPathFinder (){
		agent.SetDestination(targetTransform.position);
	}
	#endregion
	

	public void DestroyEnemy (){
	
			Destroy (this.gameObject);
		
	}



}
