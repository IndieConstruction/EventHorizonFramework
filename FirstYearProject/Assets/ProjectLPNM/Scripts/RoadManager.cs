using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace EH.LPNM{
public class RoadManager : MonoBehaviour   {



<<<<<<< HEAD
	/// <summary>
	/// Indica il numero di Road in scena
	/// </summary>
	public int MaxRoadsInGame = 6;
	/// <summary>
	/// Lista gameobject totali random da prendere dalla lista delle texture.
	/// </summary>
	public List <GameObject> RoadsPrefabs = new List<GameObject>();

	float RoadLenght = 10;
	/// <summary>
	/// Lista di GameObject in scena.
	/// </summary>
	List <GameObject> Roads = new List<GameObject>();

	void Awake (){

	}

	void Start(){

	}

	void update(){

	}

	void fixedUpdate(){

	}

	
	/// <summary>
	/// Calcolo il punto di riposizionamento della Road da riposizionare calcolandola così: posizione della road + (lunghezzaRoad * (lunghezza della lista delle roads -1)).
	/// </summary>
	/// <param name="objectToReposition">Object to reposition.</param>
	/// <param name="newPosition">New position.</param>
	public void Reposition(GameObject objectToReposition, Vector3 newPosition){
		int ListRoadsLenght = Roads.Count -1;
		Vector3 ActualRoadPosition = objectToReposition.transform.position;
		objectToReposition.transform.position =new Vector3 (ActualRoadPosition.x,ActualRoadPosition.y,ActualRoadPosition.z + (RoadLenght*ListRoadsLenght));
	}
	/// <summary>
	/// Cicla la liste delle Road e le aggiunge al contatore
	/// </summary>
	/// <param name="roadsToAdd">Roads to add.</param>
	public void RoadsCounter(GameObject roadsToAdd){
		foreach (var item in Roads) {
			Debug.Log("Sto ciclando e aggiungo cose");
			Roads.Add (roadsToAdd);
		}

	}
	/// <summary>
	/// Cicla la lista delle RoadTexture e le aggiunge al contatore
	/// </summary>
	/// <param name="roadsPrefabToAd">Roads prefab to ad.</param>
	public void RandomSpawnRoadTexture(GameObject roadsPrefabToAdd){
		for (int i = 0; i < RoadsPrefabs.Count; i++) {
			RoadsPrefabs.Add (roadsPrefabToAdd);
		}
	}
	
}
=======
		/// <summary>
		/// Indica il numero di Road in scena
		/// </summary>
		public int MaxRoadsInGame = 6;
		public GameObject [] RoadMesh;
		float RoadLenght = 25;
		/// <summary>
		/// Lista di GameObject in scena.
		/// </summary>
		List <GameObject> Roads = new List<GameObject>();
		
		void Awake (){
			
		}
		
		void Start(){
			
		}
		
		void Update(){
			float speed =15;
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
		
		
		
		/// <summary>
		/// Calcolo il punto di riposizionamento della Road da riposizionare calcolandola così: posizione della road + (lunghezzaRoad * (lunghezza della lista delle roads -1)).
		/// </summary>
		/// <param name="objectToReposition">Object to reposition.</param>
		/// <param name="newPosition">New position.</param>
		public void Reposition(GameObject objectToReposition){
			//int ListRoadsLenght = Roads.Count -1;
			Vector3 ActualRoadPosition = objectToReposition.transform.position;
			objectToReposition.transform.position =new Vector3 (ActualRoadPosition.x,ActualRoadPosition.y,ActualRoadPosition.z + (RoadLenght*2	));
		}
		
		public void OnTriggerEnter(Collider other){
			Reposition (this.gameObject);
		}
		
		
		
	}
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
}