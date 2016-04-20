using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace EH.Learn.GenericSpawnerWithInterfaces {
    public class Spawner : MonoBehaviour {

        // Lista degli oggetti da spawnare
        public List<GameObject> GOs = new List<GameObject>();

        void Start() {
            foreach (var item in GOs) {
                GameObject g = Instantiate<GameObject>(item);
                g.GetComponent<IDoSomething>().DoSomething();
            }
        }
    }

    public interface IDoSomething {
        void DoSomething();
    }
}