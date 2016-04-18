using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class InputController : MonoBehaviour {

	public float Speed = 1 ;
	public Vector3 PositionW;
	public Vector3 PositionA;
	public Vector3 PositionS;
	public Vector3 PositionD;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
			if(Input.GetKeyUp(KeyCode.W)){
				PositionW.x += Speed * Time.deltaTime;
				transform.position = PositionW;
			}
			if(Input.GetKeyUp(KeyCode.A)){
				PositionA.x += Speed * Time.deltaTime;
				transform.position = PositionA;
			}
			if(Input.GetKeyUp(KeyCode.S)){
				PositionS.x += Speed * Time.deltaTime;
				transform.position = PositionS;
			}
			if(Input.GetKeyUp(KeyCode.D)){
				PositionD.x += Speed * Time.deltaTime;
				transform.position = PositionD;
			}
	}
	}
}