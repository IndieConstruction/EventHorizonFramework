using UnityEngine;
using System.Collections;
using EH.FrameWork;
namespace EH.Project404{
public class Obstacle : MonoBehaviour, IItem {

		GameObject obstacle;
		public GameObject ItemGameObject {
			get{
				return obstacle;
				}
			set{
				obstacle = this.gameObject;
				}
			}
		/// <summary>
		/// Raises the trigger enter event.
		/// </summary>
		/// <param name="other">Other.</param>
		public void OnTriggerEnter ( Collider other){

		}
}
}