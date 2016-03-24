﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	//public static string GameName = "Libera Player";

	public int Level;

	#region Events declaration
	public delegate void GameEvent();

	public static event GameEvent OnGameWin;
	// evento che fa partire il gioco/livello
	public static event GameEvent OnGameStart;
	public static event GameEvent OnGameOver;
	public static event GameEvent OnNextLevel;

	#endregion

	public Transform NpcSpawnPoint;
	public GameObject NpcPrefab;
	public Transform BossSpawnPoint;
	public GameObject BossPrefab;
	public Player p ;

	public GameObject[] ItemsPrefabs;
	public Transform[] ItemsSpawnPoints; // array di spawnBonus
	public int ItemSpawnCounter; // contatore per lo spawn degli Item
	public int LimitSpawnItem; // limite per lo spawn dei bonus

	public GameObject EnemyPrefab;
	public Transform[] EnemiesSpawnPoints; // array di spawnPoints
	public Transform[] EnemyPatrolPoint; // array di punti che il nemico deve seguire mentre è in Patroling
	public int EnemySpawnCounter; // contatore di nemici
	public int LimitSpawnEnemy; // limite per lo spawn dei nemici

	public float Counter; // contatore generico
	public float CounterLimit; // limite per il contatore generico





	void Awake(){

		DontDestroyOnLoad(this.gameObject);
		EnemySpawnCounter = 0;
		ItemSpawnCounter = 0;
		if (OnGameStart!= null) {
		OnGameStart();
		}
	}

	void Start(){

	}
	
	// Update is called once per frame
	 void Update () {
		GenericCounter ();
		if (CanSpawnItem() == true) {
			Debug.Log ("Il bonus può spawnare") ;
			RandomSpawnItems();
		}
		if (CanSpawnEnemy () == true) {
			Debug.Log ("L'enemy può spawnare");
			RandomSpawnEnemy ();
		}
		OnPlayerDeath ();
	}
	void FixedUpdate(){

	}

	public void SpawnMe () {
		GameObject objectToSpawn = NpcPrefab;
		Vector3 spawnPosition = NpcSpawnPoint.position;
		Spawn (objectToSpawn, spawnPosition); 
	}

	//Spawn generale
	public void Spawn(GameObject objectToSpawn, Vector3 positionToSpawn){
		Instantiate (objectToSpawn, positionToSpawn, objectToSpawn.transform.rotation);

	}
	/// <summary>
	/// Spawn Random degli Items
	/// </summary>
	void RandomSpawnItems (){
		ItemSpawnCounter ++;
		// sceglie un indice a caso nell'array ItemsPrefabs
		int randomItem = Random.Range(0, ItemsPrefabs.Length);
		// assegna l'indice scelto al gameobject ItemToSpawn
		GameObject ItemToSpawn = ItemsPrefabs [randomItem];
		// sceglie un indice a caso nell'array di spawnPoint
		int randomIndex = Random.Range (0,ItemsSpawnPoints.Length -1);
		// assegna l'indice alla variabile spawnPosition
		Vector3 spawnPosition = ItemsSpawnPoints [randomIndex].position;
		// esegue lo spawn con i parametri ItemToSpawn e spawnPosition
		Spawn (ItemToSpawn,spawnPosition);
	}

	/// <summary>
	/// Spawn Random dei nemici
	/// </summary>
	void RandomSpawnEnemy (){
		EnemySpawnCounter ++;
		// sceglie l'oggetto da spawnare
		GameObject enemyToSpawn = EnemyPrefab;
		//sceglie un indice a caso nell'array di spawnPoint.
		int randomIndex = Random.Range (0,EnemiesSpawnPoints.Length -1);
		//assegna l'indice alla variabile spawnPosition
		Vector3 spawnPosition = EnemiesSpawnPoints [randomIndex].position;
		//esegue lo spawn con i parametri enemyToSpawn e spawnPosition
		Spawn (enemyToSpawn,spawnPosition);

	}


	void OnPlayerDeath(){
		if (p.CurrentPlayerState == Player.PlayerStates.Dead) {
			OnGameOver();
		}
	}

	public bool CanSpawnEnemy (){
		if (LimitSpawnEnemy >= EnemySpawnCounter) {
			return true;
		} else {
			return false;
		}
	} 

	public bool CanSpawnItem (){
		if (LimitSpawnItem >= ItemSpawnCounter) {
			return true;
		} else {
			return false;
		}
	} 
	
	void GenericCounter () {
		Counter = Counter + Time.deltaTime;
		if (Counter >= CounterLimit) {
		Counter = 0;
		}
	}
	public void LevelLoaded () {
				if (GameController.OnGameStart != null ) {
					GameController.OnGameStart();
				}
	}
	public void PlayerLevelCompleted () {
		Application.LoadLevel("Level Two");
	}
}


