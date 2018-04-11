using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class StartServer : MonoBehaviour {
    // Use this for initialization
    void Start() {
        var server = gameObject.GetComponent<Server>();
        if (server == null) {
            Debug.Log("SERVER IS NULL!");
        }
        else {
            server.StartServer();
        }

        
        
        Debug.Log("Started...");

    }
}