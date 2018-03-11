using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Networking : NetworkManager {
	public override void OnClientConnect(NetworkConnection conn){
		Debug.Log ("NEW CONNECTION!");
	}

}
