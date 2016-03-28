using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

	public GameController gc;
	public Transform backpack;

	void Start () {
		if (gc == null) {
			gc = FindObjectOfType<GameController> ();
		}
	}
	void OnTriggerEnter ( Collider other ) {
		Player p = other.gameObject.GetComponent<Player> ();
		if (p != null) {
			gc.RockAdded(this);
			AddInBackPack();
		}
	}
	void AddInBackPack() {
		transform.position = backpack.position;
		transform.parent = backpack.gameObject.transform;
	}
}
