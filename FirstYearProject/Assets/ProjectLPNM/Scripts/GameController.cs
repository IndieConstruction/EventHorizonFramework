using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class GameController : MonoBehaviour {
	
	public Player p; 
	public int Level ;
	public GameObject[] ObstacleLettersPrefabs;
	public GameObject[] PlayerPrefabs;
	Vector3 posPlayer;
	public float GameTimer;
	private int Points;
	
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
			ChangeShape ();
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
	


		/// <summary>
		/// Cambia la forma del player
		/// </summary>
		void ChangeShape(){
			//Salva la posizione del player.

			//Vector3 posPlayer= p.gameObject.transform.position;
			if (Input.GetKeyUp (KeyCode.A)) {
			Vector3 posPlayer= p.gameObject.transform.position;
				//ciclo la lunghezza dell'array
				for (int i = 0; i < PlayerPrefabs.Length; i++) { 
					//restituisco il risulato come un gameobject
					GameObject PrefabShape = PlayerPrefabs [i].gameObject;
					Player RightPlayer = PrefabShape.GetComponent<Player> ();
					if (RightPlayer.Letter == "A") {
						//p.gameObject.SetActive(false);
						Destroy (p.gameObject);

						Spawn (RightPlayer.gameObject, posPlayer);
						Debug.Log ("A");
					
					}

						
				}
			}
			if (Input.GetKeyUp (KeyCode.M)) {
				//salvo la posizione del player
				Vector3 posPlayer = p.gameObject.transform.position;
				//ciclo la lunghezza dell'array
				for (int i = 0; i < PlayerPrefabs.Length; i++) { 
					//restituisco il risulato come un gameobject
					GameObject PrefabShape = PlayerPrefabs [i].gameObject;
					Player RightPlayer = PrefabShape.GetComponent<Player> ();
					if (RightPlayer.Letter == "M"){
						//p.gameObject.SetActive(false);
						Destroy (p.gameObject);
						Spawn(RightPlayer.gameObject, posPlayer);
						Debug.Log ("M");
						}
				}
			}
		}
		void Multiplier(){}
	}
}

	
					
