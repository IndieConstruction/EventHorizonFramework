using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class GameController : MonoBehaviour {

	public GameObject[] Letters;
	public float TimerXObstacle;
	// Use this for initialization
	void Start () {
		TimerXObstacle = 0;
	}
	
	// Update is called once per frame
	void Update () {
			if(TimerXObstacle >=5){
			RandomSpawnObstacle();
			Debug.Log ("Sto Spawnando");
			TimerXObstacle = 0;
			}
			TimerXObstacle = TimerXObstacle +Time.deltaTime;
		}

	
		//Spawn generale
		public void Spawn(GameObject objectToSpawn, Vector3 positionToSpawn){
			Instantiate (objectToSpawn, positionToSpawn, objectToSpawn.transform.rotation);
			
		}
		/// <summary>
		/// Spawn Random degli Ostacoli
		/// </summary>
		void RandomSpawnObstacle (){
			// sceglie un indice a caso nell'array ItemsPrefabs
			int randomItem = Random.Range(0, Letters.Length);
			// assegna l'indice scelto al gameobject ItemToSpawn
			GameObject ItemToSpawn = Letters [randomItem];
			// sceglie un indice a caso nell'array di spawnPoint
			int randomIndex = Random.Range (0,Letters.Length -1);
			// assegna l'indice alla variabile spawnPosition
			Vector3 spawnPosition = Letters [randomIndex].transform.position;
			// esegue lo spawn con i parametri ItemToSpawn e spawnPosition
			Spawn (ItemToSpawn,spawnPosition);

		}
}
}