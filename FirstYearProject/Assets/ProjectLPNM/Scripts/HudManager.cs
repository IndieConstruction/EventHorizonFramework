using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace EH.LPNM{
public class HudManager : MonoBehaviour {

	Text[] texts ;
	public Text Points;
	public Text Timer;
	public GameController gc;
	//public CollisionController cc;

	bool isEnable;
	void Awake(){
		
		texts = GetComponentsInChildren<Text> (); 
		Points = texts [0];
		Timer = texts [1];
		
	}
	void Update () {
		if (isEnable) {
			UpdateHud ();
		}
	}
	
	void UpdateHud (){
		//Points.text = "Points : " + cc. ;
		
		Timer.text = "Timer : " + gc.GameTimer;
	}
	
}
}
