using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {
	enum statusPoint
	{	Perfect,
		Good,
		OutOfRange
		
	}
	//TODO: togliere switchcase con if/else.
	public object CollisionState;
	private object collisionState {
		get;
		set;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}




}
