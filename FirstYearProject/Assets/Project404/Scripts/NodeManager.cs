using UnityEngine;
using System.Collections;
namespace EH.Project404{
public class NodeManager : MonoBehaviour {
	public RoadNode[] roadNodes;
	// Use this for initialization
	void Start () {

		roadNodes = GetComponentsInChildren<RoadNode>();

	}
	public RoadNode GetFirstNode () {
		return roadNodes[0];
	}
	public RoadNode GetNextNode (Vector3 oldNode ) {
		for (int i = 0; i <roadNodes.Length ; i++) {
			if (oldNode == roadNodes[i].transform.position) { 
				if(i+1 < roadNodes.Length){
					return roadNodes[i+1];
				}
			}
		}
		return null;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
}