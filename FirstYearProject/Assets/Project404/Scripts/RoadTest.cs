using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace EH.Project404{
	public class RoadTest : MonoBehaviour, IMove  {
		public float speed;
		Vector3 currentPosition;
		Vector3 nextPosition;
		public NodeManager nm;
		void Start () {
			currentPosition = nm.GetFirstNode().transform.position;
		}
		void Update(){
			Movement ();
		}
		
		public void Movement () {

			//transform.Translate (-(currentPosition/Vector3.Distance(currentPosition, transform.position)) * Time.deltaTime* speed );

			transform.Translate(-currentPosition * Time.deltaTime * 0.1f);
			if ( transform.position.z <= -currentPosition.z && transform.position.y <= transform.position.y) {
				Debug.Log("Sono arrivato");
			nextPosition = nm.GetNextNode(currentPosition).transform.position;
			currentPosition = nextPosition;

			}
		}
		
	}
}