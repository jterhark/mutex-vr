using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Client : NetworkManager {

	public class PositionMessageType{
		public static short Position = 1024;
	}

	public class PositionMessage : MessageBase{
		public float x;
		public float y;
		public float z;
	};


	public override void OnClientConnect(NetworkConnection conn){
		base.OnClientConnect (conn);
		this.client.RegisterHandler (PositionMessageType.Position, OnPositionUpdate);
		Debug.Log ("NEW CLIENT CONNECTION");
	}


	public void OnPositionUpdate(NetworkMessage msg){
		PositionMessage pos = msg.ReadMessage<PositionMessage>();
		Debug.Log (string.Format("x = {0} | y = {1} | z = {2}", pos.x, pos.y, pos.z));
	}
}
