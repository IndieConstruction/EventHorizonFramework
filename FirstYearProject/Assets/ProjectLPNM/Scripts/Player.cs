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
<<<<<<< HEAD
	void FixedUpdate(){

	
	}
	
	void DistanveBeteenPlayerAndObstacle() {
			//if (DistanceToObgject) {
				float distance = Vector3.Distance(this.transform.position, DistanceToObgject.transform.position);
				Debug.Log("distanza calcolcata: " + distance);
			//}
		}
	}
=======
>>>>>>> 58208bcc4271446c657d22ee7fa7ca587100b38b
}
}