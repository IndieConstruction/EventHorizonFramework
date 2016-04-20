using UnityEngine;
using System.Collections;
using EH.FrameWork;
namespace EH.Project404{
public class Obstacle : MonoBehaviour, IItem {
	
		GameObject obstacle;
		public GameObject ItemGameObject {
			get{
				if (obstacle != null) {
					obstacle = this.gameObject;
				}
				return obstacle;
				}
			}
		/// <summary>
		/// Raises the trigger enter event.
		/// </summary>
		/// <param name="other">Other.</param>
		public void OnTriggerEnter ( Collider other){

		}
		void Start () {
		
		}
		void Move () {
			transform.Translate (Vector3.back * Time.deltaTime );
		}

		void Update () {
			Move ();
		}
}
}