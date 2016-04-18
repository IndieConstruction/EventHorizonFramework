using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace EH.LPNM{
public class RoadManager : MonoBehaviour   {



	/// <summary>
	/// Indica il numero di Road in scena
	/// </summary>
	public int MaxRoadsInGame = 6;
	/// <summary>
	/// Lista gameobject totali random da prendere dalla lista delle mesh.
	/// </summary>
	
	 
	public GameObject[] RoadsMesh ;

	float RoadLenght = 50;
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
			Roads.Remove (this.gameObject);
	}

	public void OnTriggerEnter(Collider other){
		Reposition (this.gameObject);
		RandomRoads ();
	}

	/// <summary>
	/// Sceglie un indice a caso nell'array RoadMesh
	/// </summary>
	void RandomRoads (){

		// sceglie un indice a caso nell'array RoadMesh
		int randomMesh = Random.Range (0, RoadsMesh.Length -1);
		// assegna l'indice scelto al gameobject ChosenRoad
		GameObject ChosenRoad = RoadsMesh [randomMesh];
		Roads.Add (ChosenRoad);

	}

}
}