using UnityEngine;
using System.Collections;
namespace EH.FPS {
public class Rock : MonoBehaviour, ICollectableItem ,IThrowable{
	Player p;
	Vector3 hitPoint;


	void Start () {
		if (p == null) {
			p = FindObjectOfType<Player> ();
		}
	}
	void OnTriggerEnter ( Collider other ) {
		Inventory inventory;
		Player p = other.gameObject.GetComponent<Player> ();
		if (p != null) {
			inventory = p.GetInventory();
			if(inventory != null){
				inventory.AddItem(this);
				}
		}
	}
		

	public void UseItem(){

	}
	public void UseItem(Vector3 TargetPosition){
		this.transform.position = TargetPosition ;
		transform.parent = null;
	}
}
}