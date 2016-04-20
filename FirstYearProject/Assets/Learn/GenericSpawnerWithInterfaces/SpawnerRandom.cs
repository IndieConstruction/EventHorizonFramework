using UnityEngine;
using System.Collections.Generic;

namespace EH.Learn.GenericSpawnerWithInterfaces {

    public class SpawnerRandom : MonoBehaviour {

        List<GameObject> GOTemplates = new List<GameObject>();

        // Use this for initialization
        void Start() {
            int counter = 0;
            do {
                counter++;
                GameObject goForTemplate = Resources.Load<GameObject>("Pref" + counter);
                if (!goForTemplate)
                    break;
                if (goForTemplate.GetComponent<IDoSomething>() != null) {
                    GOTemplates.Add(goForTemplate);
                } else
                    Debug.Log("Trovato oggetto che non implementa l'interfaccia!! " + goForTemplate.name);
            } while (counter < 100);
        }

        void SpawnRandom() {
            GameObject go = Instantiate<GameObject>(GOTemplates[Random.Range(0, GOTemplates.Count)]);
            go.GetComponent<IDoSomething>();
        }

        // Update is called once per frame
        void Update() {
            if (Input.GetKeyUp(KeyCode.S))
                SpawnRandom();
        }
    }
}
