using UnityEngine;
using System.Collections;

namespace EH.Project404{
public class Player : MonoBehaviour {
		public int PlayerDimension;
		public bool isJumping = false;
		float speed = 450;
		Rigidbody rb;
		public int BonusCounter;
		public int BonusStadio1;
		public int BonusStadio2;
		public int BonusStadio3;
		public int BonusStadio4;
		public int BonusStadio5;
	// Use this for initialization
	void Start () {
			rb = gameObject.GetComponent<Rigidbody> ();
			PlayerDimension = 1;
			BonusCounter = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
			Move ();
<<<<<<< HEAD
			if (Input.GetKeyDown(KeyCode.Space)) {
				PlayerDimension --;
				Vector3 vector = new Vector3(0.1f, 0.1f, 0.1f);
			ModifyScale (vector);
			}
			if (isJumping == true) {
				Jump();
			}

=======
			DecreaseScale ();
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
	}

		//movimento della sfera
	void Move () {
<<<<<<< HEAD
			float speed = 4.0f;
=======
			float speed = 5.0f;
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
			//float translationZ = Input.GetAxisRaw("Vertical") * speed;
			float translationX = Input.GetAxisRaw("Horizontal") * speed;
			//translationZ *= Time.deltaTime;
			translationX *= Time.deltaTime;
			
			transform.Translate(translationX, 0, 0);
			transform.Rotate (Vector3.right * Time.deltaTime * speed *10);
	
		}

		void OnTriggerEnter ( Collider other ) {
<<<<<<< HEAD




		}

		void ModifyScale (Vector3 vector) {
			vector = new Vector3(0.1f, 0.1f, 0.1f);
			transform.localScale -= vector;

		}
		public void Jump () {
			rb.AddForce (Vector3.up * Time.deltaTime * speed);
=======
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
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
		}
	}
}


