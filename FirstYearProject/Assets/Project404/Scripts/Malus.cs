using UnityEngine;
using System.Collections;
namespace EH.Project404{
public class Malus : MonoBehaviour,IEffector,IMove   {

		public int MalusDimension;

		public void ApplyEffect(Player p ){
			Debug.Log("eseguo l'effetto del Malus");
			if (p.PlayerDimension >= MalusDimension) {
				Destroy (this.gameObject);
			}
			else if (p.PlayerDimension < MalusDimension) {

				Destroy (p.gameObject);
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