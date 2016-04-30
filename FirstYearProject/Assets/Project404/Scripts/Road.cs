using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace EH.Project404{
	public class Road : MonoBehaviour, IMove  {
		public float speed;

		
		void Update(){
			Movement ();
		}

		public void Movement () {
			 speed =15;
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
	

	}
}
