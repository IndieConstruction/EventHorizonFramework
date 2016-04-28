using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class CollisionController : MonoBehaviour {
	
	public GameController gc;
	//public HudManager HD;
	int DistanceX = 1; 
	int DistanceY = 2; 
	
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
				Vote vote = calculate(distanceResult);
					Debug.Log("Lettera è = ed è a distanza di : "  + distanceResult + "Punteggio è : " + vote);
			}else {
					Vote vote = Vote.wrongletter;

				Debug.Log ("Lettera è sbagliata");
			}
			}
	}
		public enum Vote
		{Perfect,
			Good,
			poor,
			wrongletter,
			
		}


	Vote calculate (float distanceResult){

		if (distanceResult <= DistanceX) {
				Debug.LogFormat ("Perfect! {0} ", distanceResult); //format permette di mettere le graffe, e di riempirle con cio' che scrivo dopo
				gc.OnPointsToAdd(Vote.Perfect,distanceResult);
				return Vote.Perfect;
		}else if (distanceResult>DistanceX && distanceResult<DistanceY ) { 
				Debug.LogFormat ("Good! {0} ", distanceResult); 
				return Vote.Good;	
		}else{Debug.LogFormat ("Che schifo! {0}",distanceResult); 
				return Vote.poor;
			}
		}

	}
	}

