using UnityEngine;
using System.Collections;
using EH.FrameWork;
namespace EH.FPS {
public interface IAttack{

	Agent Target {
		get;
		set;
	}

	 float AttackValue {
		get;
		set;
	}

	void Attack (float damage, Agent target);
}
}