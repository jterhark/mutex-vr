using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using NetworkMessages;

public class Server : NetworkManager {

    //im using visual studio 2015 and I LOVE IT


	public override void OnServerConnect (NetworkConnection conn)
	{
		base.OnServerConnect (conn);
		Debug.Log ("NEW CONNECTION");
	}

	public void SendPosition(PositionType posType, float x, float y, float z){

		/*
		Debug.Log ("Connections: " + Network.connections.Length);

		if (Network.connections.Length < 1) {
			return;
		}
		*/

		var msg = new PositionMessage {
			Type = posType,
			X = x,
			Y = y,
			Z = z
		};

		NetworkServer.SendToAll (MessageTypes.PositionUpdate, msg);

		//this.client.Send (PositionMessageType.Position, msg);

		Debug.Log ("SENT");
	}
}
