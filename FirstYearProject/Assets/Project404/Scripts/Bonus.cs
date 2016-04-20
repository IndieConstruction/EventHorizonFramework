using UnityEngine;
using System.Collections;
using EH.FrameWork;
namespace EH.Project404{
public class Bonus : MonoBehaviour, IItem {
	
	// Use this for initialization
	void Start () {
		
			
			if (bonus == null) {
				bonus = this.gameObject.GetComponent<GameObject>();
			}
		}
	// Update is called once per frame
	void Update () {
			Move ();
	}
		GameObject bonus;
		public GameObject ItemGameObject {
			get{
				return bonus;
			}
		}

		public void OnTriggerEnter ( Collider other){

		}
		void Move () {
			transform.Translate (Vector3.back * Time.deltaTime );
		}
}
}