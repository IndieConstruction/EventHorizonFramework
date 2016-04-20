using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class InputController : MonoBehaviour {
		float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
			if(Input.GetMouseButtonDown(1)){
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit, 100)){ 
					Debug.Log ("Sto Raycastando");
					transform.Translate(Vector3.forward*speed*Time.deltaTime);
				}
			}
			Move ();
	}
		void Move () {
			float speed = 5.0f;
			float translationZ = Input.GetAxisRaw("Vertical") *speed;
			float translationX = Input.GetAxisRaw("Horizontal") * speed;
			translationZ *= Time.deltaTime;
			translationX *= Time.deltaTime;
			
			transform.Translate(translationX, 0, 0);
			transform.Translate(0, translationZ, 0);
			
		}
	}
}