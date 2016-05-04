using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace EH.LPNM{
public class RoadManager : MonoBehaviour   {


		public GameController gc;
		/// <summary>
		/// Indica il numero di Road in scena
		/// </summary>
		//public int MaxRoadsInGame = 6;
		public GameObject [] RoadMesh;
		float RoadLenght = 10;
		public float speed =3;
		/// <summary>
		/// Lista di GameObject in scena.
		/// </summary>
		List <GameObject> Roads = new List<GameObject>();
		
		void Awake (){

		}
		
		void Start(){
			
		}
		
		void Update(){
			if(gc.GameTimer ==0 && gc.GameTimer <= 10){
				speed = 3;
			}
			if (gc.GameTimer >=10 && gc.GameTimer <= 15) {
				speed = 5;
			}
			if 
			(gc.GameTimer >= 25){
				speed = 10;
			}
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
		

		/// <summary>
		/// Calcolo il punto di riposizionamento della Road da riposizionare calcolandola così: posizione della road + (lunghezzaRoad * (lunghezza della lista delle roads -1)).
		/// </summary>
		/// <param name="objectToReposition">Object to reposition.</param>
		/// <param name="newPosition">New position.</param>
		public void Reposition(GameObject objectToReposition){
			int ListRoadsLenght = Roads.Count -1;
			Vector3 ActualRoadPosition = objectToReposition.transform.position;
			objectToReposition.transform.position =new Vector3 (ActualRoadPosition.x,ActualRoadPosition.y- (RoadLenght*2), ActualRoadPosition.z );
		}
		
//		public void OnTriggerEnter(Collider other){
//
//			Reposition (this.gameObject);
//		}
		
		
		
	}
}