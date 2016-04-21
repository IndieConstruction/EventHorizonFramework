using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class PercentageCalcolation : MonoBehaviour {

	int DistanceX = 9; //
	int DistanceY = 19; //
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.Space)){
			calculate();
		
		}
		 }
	
	void calculate (){
				
		int result = Random.Range (1, 101);
			if (result <= DistanceX) { 
			//punteggio,suono etc.
			Debug.LogFormat ("Perfect! {0} ", result); //format permette di mettere le graffe, e di riempirle con cio' che scrivo dopo
		}
		else if (result>DistanceX && result<DistanceY ) { 
			Debug.LogFormat ("Good! {0} ", result); 
				//punteggio,suono etc.
		}
		else if (result >= DistanceY) { 
			Debug.LogFormat ("Che schifo! {0}",result); 
				//punteggio,suono etc.
		}
}
}
}
//Con lo switch case posso selezionare un caso quando esce un determinato range