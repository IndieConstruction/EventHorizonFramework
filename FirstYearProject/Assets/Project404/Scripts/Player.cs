using UnityEngine;
using System.Collections;

namespace EH.Project404{
public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
			Move ();
			DecreaseScale ();
	}

		//movimento della sfera
	void Move () {
			float speed = 5.0f;
			//float translationZ = Input.GetAxisRaw("Vertical") * speed;
			float translationX = Input.GetAxisRaw("Horizontal") * speed;
			//translationZ *= Time.deltaTime;
			translationX *= Time.deltaTime;
			
			transform.Translate(translationX, 0, 0);
			transform.Rotate (Vector3.right * Time.deltaTime * speed *10);
	
		}

		void OnTriggerEnter ( Collider other ) {
			Bonus b = other.gameObject.GetComponent<Bonus> ();
			if (b != null) {
				transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);

				Destroy(b.gameObject);
		}
		}
		void DecreaseScale () {
			if (Input.GetKeyDown(KeyCode.Space)) {
				transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
			}
		}
	}
}


