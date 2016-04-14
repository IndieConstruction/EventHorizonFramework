using UnityEngine;
using System.Collections;
namespace EH.FPS {
public class TargetTest : MonoBehaviour {
	public Rock rock;
	public Rock rcok1;
	// Use this for initialization
	void Start () {
		rock.UseItem(this.transform.position);
		rcok1.UseItem(this.transform.position + Vector3.one );	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
}
