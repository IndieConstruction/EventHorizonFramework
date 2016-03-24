using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudManager : MonoBehaviour {

	Text[] texts ;
	public Text Health;
	public Text NpcToFree;
	public Text Exp;
	// Use this for initialization
	public GameController gc;
	public NPC npc;
	public Player p;

	void Awake(){
		DontDestroyOnLoad(this);
		texts = GetComponentsInChildren<Text>(); 
		Health = texts [1];
		NpcToFree = texts [2];
		Exp = texts [3];
		GameController.OnGameOver += HandleOnGameOver;
		GameController.OnGameStart += HandleOnStart;
		GameController.OnGameWin += HandleOnGameWin;
		GameController.OnNextLevel += HandleOnNextLevel;
	}



	void Update () {
		UpdateHud ();
	}

	void HandleOnStart ()
	{
		gameObject.GetComponentInChildren<Text>().text = "Level" + gc.Level;
		gameObject.GetComponentInChildren<Text> ().enabled = true; 
	}
	void HandleOnGameOver ()
	{
		gameObject.GetComponentInChildren<Text>().text = "GameOver";
		gameObject.GetComponentInChildren<Text> ().enabled = true;
	}

	void HandleOnGameWin ()
	{
		gameObject.GetComponentInChildren<Text>().text = "YouWin";
		gameObject.GetComponentInChildren<Text> ().enabled = true;
	}

	void HandleOnNextLevel ()
	{
		gameObject.GetComponentInChildren<Text>().text = "New Level ";
		gameObject.GetComponentInChildren<Text> ().enabled = true;
	}
	void UpdateHud (){
		Health.text = "Health : " + p.Health ;
		NpcToFree.text = "Npc In Spawn : " + npc.name ;
		Exp.text = "Experience : " + p.exp;
	}
	void OnDisable() {
		GameController.OnGameOver -= HandleOnGameOver;
		GameController.OnGameStart -= HandleOnStart;
		GameController.OnGameWin -= HandleOnGameWin;
		GameController.OnNextLevel -= HandleOnNextLevel;
	}
}
