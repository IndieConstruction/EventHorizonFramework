using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public GameController gc;
	public NPC npc;
	public Player player;
	//setting dei liveli
	public int Level;
	public Transform NpcSpawnPoint ;
	public Transform [] EnemiesSpawnPoints;
	public Transform [] ItemsSpawnPoints;
	public Transform[] EnemyPatrolPoint;
	public GameObject NpcPrefab;
	public GameObject EnemyPrefab;
	public GameObject[] ItemsPrefab;
	public GameObject BossPrefab;
	public Transform BossSpawnPoint;
	public int EnemySpawnCounter; // contatore di nemici
	public int LimitSpawnEnemy; // limite per lo spawn dei nemici
	public int ItemSpawnCounter; // contatore per lo spawn degli Item
	public int LimitSpawnItem; // limite per lo spawn dei bonus
	// Use this for initialization
	void Awake(){
		//DontDestroyOnLoad(this);
		SetupScene();
		GameController.OnNextLevel += HandleOnNextLevel;
		//hm = FindObjectOfType<>;
	}

	void HandleOnNextLevel (){
		if(player.isOver == true && npc.CurrentNPCState == NPC.NPCStates.Free){
			Application.LoadLevel("Level Two");
	}
	}

	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		//if (hm != null) {
		HandleOnNextLevel ();
		//}
	}
	void SetupScene(){

		switch(Level){
		case 1 :
			gc.NpcSpawnPoint = NpcSpawnPoint;
			gc.NpcPrefab = NpcPrefab;
			break;
		case 2 :
			gc.BossPrefab = BossPrefab;
			gc.BossSpawnPoint = BossSpawnPoint;
			break;
		}
		// variabili utilizzabili in entrambi i livelli
		gc.EnemySpawnCounter = EnemySpawnCounter;
		gc.LimitSpawnEnemy = LimitSpawnEnemy;
		gc.ItemSpawnCounter = ItemSpawnCounter;
		gc.LimitSpawnItem = LimitSpawnItem;
		gc.EnemySpawnCounter = EnemySpawnCounter;
		gc.Level = Level;
		gc.ItemsSpawnPoints = ItemsSpawnPoints ;
		gc.ItemsPrefabs = ItemsPrefab;
		gc.EnemiesSpawnPoints = EnemiesSpawnPoints;
		gc.EnemyPrefab = EnemyPrefab;
		gc.EnemyPatrolPoint = EnemyPatrolPoint;
		}

}


