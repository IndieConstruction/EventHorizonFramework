using UnityEngine;
using System.Collections;
using System;

public class InterfacedGO2 : MonoBehaviour, IDoSomething {
    /// <summary>
    /// Implementazione interfaccia.
    /// </summary>
    public void DoSomething() {
        Debug.Log("InterfacedGO2");
    }
}


