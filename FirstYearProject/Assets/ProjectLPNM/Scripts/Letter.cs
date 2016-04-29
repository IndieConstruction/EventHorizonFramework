using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class Letter : MonoBehaviour {

	public GameController gc;
	public string IDLetter ;
	public float speed ;
	// Use this for initialization
	void Start () {
			gc =FindObjectOfType<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
			if(gc.GameTimer ==0 && gc.GameTimer <= 10){
				speed = 3;
			}
			if (gc.GameTimer >=10 && gc.GameTimer <= 15) {
				speed = 5;
			}
			if 
				(gc.GameTimer >= 25){
				speed = 10;
			}
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
	
		void OnTriggerEnter(Collider other){
			this.gameObject.SetActive(false);
		}
}
}