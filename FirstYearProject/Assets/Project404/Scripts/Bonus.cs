using UnityEngine;
using System.Collections;
using EH.FrameWork;
namespace EH.Project404{
<<<<<<< HEAD
public class Bonus : MonoBehaviour, IItem, IEffector,IMove {
		 
=======
public class Bonus : MonoBehaviour, IItem {
	
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
	// Use this for initialization
	void Start () {
		
			
			if (bonus == null) {
				bonus = this.gameObject.GetComponent<GameObject>();
			}
		}
<<<<<<< HEAD

=======
	// Update is called once per frame
	void Update () {
			Move ();
	}
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
		GameObject bonus;
		public GameObject ItemGameObject {
			get{
				return bonus;
			}
		}

		public void OnTriggerEnter ( Collider other){

		}
<<<<<<< HEAD
	
		public void ApplyEffect(Player p ){


			p.BonusCounter++;
			Destroy (this.gameObject);

			if (p.BonusCounter <= p.BonusStadio1) {

				return;
			}
			if (p.BonusCounter > p.BonusStadio1 && p.BonusCounter <=p.BonusStadio2) {

				p.transform.localScale += new Vector3 (0.3f, 0.3f, 0.3f);
				p.PlayerDimension ++;
			}
			if (p.BonusCounter >p.BonusStadio2 && p.BonusCounter <=p.BonusStadio3) {

				p.transform.localScale += new Vector3 (0.3f, 0.3f, 0.3f);
				p.PlayerDimension ++;
			}
			if (p.BonusCounter >p.BonusStadio3 && p.BonusCounter <=p.BonusStadio4) {
				
				p.transform.localScale += new Vector3 (0.3f, 0.3f, 0.3f);
				p.PlayerDimension ++;
			}
			if (p.BonusCounter >p.BonusStadio4 && p.BonusCounter <=p.BonusStadio5) {
				
				p.transform.localScale += new Vector3 (0.3f, 0.3f, 0.3f);
				p.PlayerDimension ++;
			}
			}
		void Update(){
			Movement ();
		}
		
		public void Movement () {
			float speed =15;
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
		}


}
=======
		void Move () {
			transform.Translate (Vector3.back * Time.deltaTime );
		}
}
}
>>>>>>> 226fc758a27a012b0a83b8541f2e635b5b07e092
