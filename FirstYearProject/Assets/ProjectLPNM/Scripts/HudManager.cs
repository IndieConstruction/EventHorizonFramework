using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace EH.LPNM{
public class HudManager : MonoBehaviour {

	
	public Text ScoreText;
	public Text BonusVoteText;
		public Text PointDistanceText;
	public GameController gc;
	//public int scoreCounter;
	public bool isEnable = false;

	void Start(){
			ScoreText.text ="Score : " + 0;
			//BonusEffects.text = "";	

	}
	void Awake(){
		

		
	}
	void Update () {
			if(gc.scoreCounter == 10)
				Debug.Log("YouWin");
		}
	
	public void UpdateHud (string textScore){
		ScoreText.text ="Score : " + gc.scoreCounter ;
	}
	
	public void OnCollisionVote(string BonusVote, string PointDistance){
		if(isEnable == true){
			BonusVoteText.text = " : " + BonusVote  ;
				PointDistanceText.text = " : " + PointDistance;
		}
	}

	}
}

