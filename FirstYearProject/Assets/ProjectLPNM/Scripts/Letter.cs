using UnityEngine;
using System.Collections;
namespace EH.LPNM{
public class Letter : MonoBehaviour {

	public string IDLetter ;
	public float speed ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			transform.Translate (Vector3.back * Time.deltaTime * speed);
	}
}
}