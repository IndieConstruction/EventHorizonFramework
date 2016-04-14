using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RoadManager : MonoBehaviour   {



	/// <summary>
	/// Indica il numero di Road in scena
	/// </summary>
	public int MaxRoadsInGame = 6;
	/// <summary>
	/// Lista gameobject totali.
	/// </summary>
	public List <GameObject> Prefabs = new List<GameObject>();

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

	public void RoadsCounter(){
		foreach (var GameObject in Roads) {
			MaxRoadsInGame ++;
		}
	}
}
