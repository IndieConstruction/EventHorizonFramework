using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class Player : MonoBehaviour {

	public GameObject DistanceToObgject;
	// Use this for initialization
	void Start () {
			DistanveBeteenPlayerAndObstacle();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate(){

	
	}
	
	void DistanveBeteenPlayerAndObstacle() {
			//if (DistanceToObgject) {
				float distance = Vector3.Distance(this.transform.position, DistanceToObgject.transform.position);
				Debug.Log("distanza calcolcata: " + distance);
			//}
		}
	}
}
