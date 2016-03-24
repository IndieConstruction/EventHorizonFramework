using UnityEngine;
using System.Collections;

public class NPC : Agent  {

	public Player p;

	public enum NPCStates {
		Free,
		Imprisoned
	}

	void OnEnable(){
		GameController.OnGameStart += HandleOnGameStart;
	}
	void OnDisable () {
		GameController.OnGameStart -= HandleOnGameStart;
	}
	void HandleOnGameStart ()
	{
		transform.position = gc.NpcSpawnPoint.position ;
	}

	void Start () {
		CurrentNPCState = NPCStates.Imprisoned;
	}

	private NPCStates currentNPCState = NPCStates.Imprisoned; 
	public NPCStates CurrentNPCState {
		get{return currentNPCState;}
		set{
			if (currentNPCState != value){
				currentNPCState = value;

				OnChangeState();

			}
			currentNPCState = value;
		}
	}
	
	// Update is called once per frame
	void Update () {
		OnChangeState ();
	
	}

 	
	// se entra in collisione con il nemico scompare e rispawna in cella.
	void OnTriggerEnter (Collider other) {
	
	Player p = other.gameObject.GetComponent<Player> ();
	Enemy e = other.gameObject.GetComponent<Enemy>();
	if (e !=null && p== null) {
			this.transform.position = gc.NpcSpawnPoint.position ;

		}
		if(p != null && e == null){
			currentNPCState = NPCStates.Free;
		}
	}
	// segue un target che gli viene passato come parametro
	void FollowTarget (Transform target) {
		transform.LookAt (target.position);
		transform.Translate (Vector3.forward * MoveSpeed * Time.deltaTime);
	}



	void OnChangeState () {
		Transform target = p.GetComponent<Transform> ();
		switch (CurrentNPCState) {
		case NPCStates.Free:
			Debug.Log ("Sono libera");
			FollowTarget(target);

			break;

		case NPCStates.Imprisoned:
			

			break;


		}
	}
}
