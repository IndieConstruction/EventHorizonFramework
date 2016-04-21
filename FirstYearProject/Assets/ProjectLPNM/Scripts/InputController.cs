using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class InputController : MonoBehaviour {
<<<<<<< HEAD

	// Use this for initialization
	void Start () {
	
	}
=======
		public float speed = 5;
		public string TagName = "Terrain";
		Transform t;
		//Vector3 startPosition;
		Transform target;
		
		void Start() {
			t = transform;
			target = transform;
		}
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
<<<<<<< HEAD
			if(Input.GetKeyUp(KeyCode.W)){

			}
			if(Input.GetKeyUp(KeyCode.A)){
			
			}
			if(Input.GetKeyUp(KeyCode.S)){
			
			}
			if(Input.GetKeyUp(KeyCode.D)){

			}
	}
=======
			if (Input.GetMouseButtonDown(0)) {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				
				if (Physics.Raycast(ray, out hit)) {
					if (hit.collider.gameObject.tag != TagName)
						return;

					target.position = hit.point;
					Debug.Log ("Sto Raycatando");

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
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
	}
}