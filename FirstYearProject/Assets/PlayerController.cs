using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float movementSpeed = 5f;
	public float fallOut = -2f;

	int count = 0;
	
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal * movementSpeed, 0.0f, moveVertical * movementSpeed);

		rb.AddForce (movement);
	}

	void Update (){
		if (transform.position.y <= fallOut){
			//transform.position = new Vector3 (0f, 0.5f, 0f);
			Application.LoadLevel(Application.loadedLevelName);
         }
}
	void OnTriggerEnter (Collider Other){
		if (Other.gameObject.tag == "Pickup"){
			Other.gameObject.SetActive (false);
			count = count + 1;
			Debug.Log (count);
        }
	}
}

