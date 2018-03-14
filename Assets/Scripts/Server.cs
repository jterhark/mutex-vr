using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Server : NetworkManager {

    //im using visual studio 2015 and I LOVE IT
	public class PositionMessageType{
		public static short Position = 1024;
	}

	public class PositionMessage : MessageBase{
		public float x;
		public float y;
		public float z;
	};


	public override void OnServerConnect (NetworkConnection conn)
	{
		base.OnServerConnect (conn);
		Debug.Log ("NEW CONNECTION");
	}

	public void SendPosition(float x, float y, float z){

		/*
		Debug.Log ("Connections: " + Network.connections.Length);

		if (Network.connections.Length < 1) {
			return;
		}
		*/

		var msg = new PositionMessage {
			x = x,
			y = y,
			z = z
		};

		NetworkServer.SendToAll (PositionMessageType.Position, msg);

		//this.client.Send (PositionMessageType.Position, msg);

		Debug.Log ("SENT");
	}
}
