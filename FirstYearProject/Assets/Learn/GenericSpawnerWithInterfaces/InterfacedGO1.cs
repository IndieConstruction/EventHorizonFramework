using UnityEngine;
using System.Collections;
using System;

namespace EH.Learn.GenericSpawnerWithInterfaces {
    public class InterfacedGO1 : MonoBehaviour, IDoSomething {
        /// <summary>
        /// Implementazione interfaccia.
        /// </summary>
        public void DoSomething() {
            Debug.Log("InterfacedGO1");
        }
    }
}


