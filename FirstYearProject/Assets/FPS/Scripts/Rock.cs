using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
	Player p;
	public GameController gc;
	public GameObject BackPack;

	void Start () {
		if (p == null) {
			p = FindObjectOfType<Player> ();
		}
		if (gc == null) {
			gc = FindObjectOfType<GameController> ();
		}
		BackPack = GameObject.Find("BackPack");
	}
	void OnTriggerEnter ( Collider other ) {
		Player p = other.gameObject.GetComponent<Player> ();
		if (p != null) {
			gc.RockAdded(this);
			AddInBackPack();
		}
	}
	void AddInBackPack() {
		transform.position = BackPack.transform.position;
		transform.parent = BackPack.transform;
	}
}
