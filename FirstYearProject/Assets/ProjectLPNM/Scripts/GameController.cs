using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class GameController : MonoBehaviour {
	
	public Player p; 
	public int Level ;
//	public GameObject[] ObstacleLettersPrefabs;
	public GameObject[] PlayerPrefabs;
	Vector3 posPlayer;
	public float GameTimer;
	public int scoreCounter;
	public int ScoreCounter {
			get{return scoreCounter;}
			set{scoreCounter = value;
				Hd.UpdateHud("Score :" +scoreCounter);
			}
		}
	public HudManager Hd;
	
	//public Transform[] LettersSpawnPoints;
	//public float CounterXObstacle;
	//float TimerXObstacle;
	// Use this for initialization
	void Start () {
	//	TimerXObstacle = 0;
		//p = GetComponent<Player>();
			GameTimer = 0;
	}	
	
	// Update is called once per frame
	void Update () {
			if(GameTimer <=60){
				GameTimer = GameTimer + Time.deltaTime;
			}
			else {
				Debug.Log("Tempo Scaduto");
				GameTimer = 0;
			}
//			if(TimerXObstacle >=CounterXObstacle){
//			RandomSpawnObstacle();
//			Debug.Log ("Sto Spawnando");
//		
//			TimerXObstacle = 0;
//			}
//			TimerXObstacle = TimerXObstacle +Time.deltaTime;
			if(p==null){
				p =FindObjectOfType<Player>();
			}

		}

	
	//Spawn generale
	public void Spawn(GameObject objectToSpawn, Vector3 positionToSpawn){
		Instantiate (objectToSpawn, positionToSpawn, objectToSpawn.transform.rotation);
			
	}
	/// <summary>
	/// Spawn Random degli Ostacoli
	/// </summary>
//	void RandomSpawnObstacle (){
//		// sceglie un indice a caso nell'array LettersPrefabs
//			int randomLetter = Random.Range(0, ObstacleLettersPrefabs.Length);
//		// assegna l'indice scelto al gameobject ItemToSpawn
//			GameObject LetterToSpawn = ObstacleLettersPrefabs [randomLetter];
//		// sceglie un indice a caso nell'array di spawnPoint
//		int randomIndex = Random.Range (0, LettersSpawnPoints.Length -1);
//		// assegna l'indice alla variabile spawnPosition
//		Vector3 spawnPosition = LettersSpawnPoints [randomIndex].transform.position;
//		// esegue lo spawn con i parametri ItemToSpawn e spawnPosition
//		Spawn (LetterToSpawn,spawnPosition);
//
//	}
	public void PlayerLevelCompleted () {
		Application.LoadLevel("Level Two");
	}
	


		 enum OnCollisionPoint
		{Perfect,
			Good,
			Ouch
		}
		/// <summary>
		/// Valuta il punteggio e lo assegna in base al voto
		/// </summary>
		public void OnPointsToAdd (CollisionController.Vote vote, float distancePoint){
	
			switch (vote) {
			case CollisionController.Vote.Perfect :
				scoreCounter = scoreCounter +2;
				break;
			case CollisionController.Vote.Good:
				scoreCounter = scoreCounter++;
				break;
			case CollisionController.Vote.poor:
				break;
			case CollisionController.Vote.wrongletter:
				scoreCounter = scoreCounter-1;
				break;
			default:
				break;
			}
			Hd.OnCollisionVote(vote.ToString(), "");
		}

	}
}

	
					
