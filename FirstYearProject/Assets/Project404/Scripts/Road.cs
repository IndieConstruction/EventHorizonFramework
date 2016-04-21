using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace EH.Project404{
<<<<<<< HEAD
	public class Road : MonoBehaviour, IMove  {
=======
	public class Road : MonoBehaviour   {
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
		
		
		
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
		
<<<<<<< HEAD

		
		void Update(){
			Movement ();
		}

		public void Movement () {
			float speed =15;
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
=======
		void Awake (){
			
		}
		
		void Start(){
			
		}
		
		void Update(){
			float speed =15;
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}

		
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
		
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
<<<<<<< HEAD
			//Reposition (this.gameObject);
=======
			Reposition (this.gameObject);
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
		}



	}
<<<<<<< HEAD
}
=======
}
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
