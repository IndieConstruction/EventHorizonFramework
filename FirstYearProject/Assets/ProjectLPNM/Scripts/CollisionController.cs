using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class CollisionController : MonoBehaviour {
	
	
	int DistanceX = 9; //
	int DistanceY = 19; //
	
		void Start () {

		}
		
		// Update is called once per frame
		void Update () {
			
		}
		void FixedUpdate(){
			
			
		}

	void OnTriggerEnter(Collider other){
			///
			Player p = gameObject.GetComponent<Player>();
			Letter letter = other.gameObject.GetComponent<Letter>();
			//
			if (letter != null){
			if(p.Letter == letter.IDLetter){

				float distanceResult = Vector3.Distance(p.transform.position, letter.transform.position);
				int PointsToadd = calculate(distanceResult);
				Debug.Log("Lettera è = ed è a distanza di : "  + distanceResult + "Punteggio è : " + PointsToadd);
			}
			else {
				Debug.Log ("Inaspettato");
			}
			}
	}


	int calculate (float distanceResult){
			
		if (distanceResult <= DistanceX) {
				Debug.LogFormat ("Perfect! {0} ", distanceResult); //format permette di mettere le graffe, e di riempirle con cio' che scrivo dopo
				return 2;
		//punteggio,suono etc.
			
		}
			else if (distanceResult>DistanceX && distanceResult<DistanceY ) { 
				Debug.LogFormat ("Good! {0} ", distanceResult); 
				return 1;
			//punteggio,suono etc.
		}
			else {
				Debug.LogFormat ("Che schifo! {0}",distanceResult); 
				return 0;}
			//punteggio,suono etc.
		
		}

	}
}

