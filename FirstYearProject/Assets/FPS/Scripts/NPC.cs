using UnityEngine;
using System.Collections;
namespace EH.FPS {
public class NPC : Agent  {

	#region variabili per l'audio dell'NPC
	AudioSource audioSource;
	public Sounds DefaultSound;
	public AudioClip Free;
	public AudioClip Imprisoned;
	
	public enum Sounds{
		Free,
		Imprisoned,
	}
	#endregion 

	public Player p;

	public enum NPCStates {
		Free,
		Imprisoned
	}



	void Awake(){
		#region iscrizione degli npc agli eventi audio
		GameController.NpcImprisond+= HandleNpcImprisond;
		GameController.NpcFree += HandleNpcFree;
		#endregion
	}

	#region funzioni per l'audio
	public void PlaySound(Sounds _soundToPlay){
		switch (_soundToPlay) {
		case Sounds.Free:
			audioSource.clip = Free;
			break;
		case Sounds.Imprisoned:
			audioSource.clip = Imprisoned;
			break;
		}
	}
	void HandleNpcImprisond ()
	{
		PlaySound(Sounds.Free);
	}

	void HandleNpcFree ()
	{
		PlaySound(Sounds.Imprisoned);
	}
	#endregion
	void Start () {
		CurrentNPCState = NPCStates.Imprisoned;
		//PlaySound (DefaultSound); 
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
	
	//Player p = other.gameObject.GetComponent<Player> ();
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
}
