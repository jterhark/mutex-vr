using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using NetworkMessages;

public class Server : NetworkManager {
    //im using visual studio 2015 and I LOVE IT

    public GameObject PlayerLocationIcon;
    public float ScalingFactor = 100.0f;
    public Transform Map;
    public Material PlayerIconMaterial;
    public Material EnemyIconMaterial;
    public Material BombIconMaterial;
    public Material DefaultMaterial;


    public override void OnServerConnect(NetworkConnection conn) {
        base.OnServerConnect(conn);
        Debug.Log("NEW SERVER CONNECTION");
        NetworkServer.RegisterHandler(MessageTypes.PositionUpdate, OnPositionUpdate);
    }

    private void OnPositionUpdate(NetworkMessage msg) {
        var pos = msg.ReadMessage<PositionMessage>();
        Debug.Log(string.Format("type = {0} | x = {1} | y = {2} | z = {3}", pos.Type, pos.X, pos.Y, pos.Z));

        var obj = Instantiate(PlayerLocationIcon) as GameObject;
        obj.transform.parent = Map;
        obj.transform.localPosition = new Vector3(
            (pos.X),
            (pos.Y),
            (pos.Z)
        );
        obj.transform.rotation = new Quaternion(0, 0, 0, 0);

        Renderer renderer = obj.GetComponent<Renderer>();
        
        switch (pos.Type) {
            case PositionType.Soldier:
                renderer.material = PlayerIconMaterial;
                break;
            case PositionType.Enemy:
                renderer.material = EnemyIconMaterial;
                break;
            case PositionType.Bomb:
                renderer.material = BombIconMaterial;
                break;
            case PositionType.None:
            default:
                renderer.material = DefaultMaterial;
                break;
        }

        //obj.transform.rotation = Map.rotation;
        Object.Destroy(obj, 1.0f);
    }

//	public void SendPosition(PositionType posType, float x, float y, float z){
//
//		/*
//		Debug.Log ("Connections: " + Network.connections.Length);
//
//		if (Network.connections.Length < 1) {
//			return;
//		}
//		*/
//
//		var msg = new PositionMessage {
//			Type = posType,
//			X = x,
//			Y = y,
//			Z = z
//		};
//
//		NetworkServer.SendToAll (MessageTypes.PositionUpdate, msg);
//
//		//this.client.Send (PositionMessageType.Position, msg);
//
//		Debug.Log ("SENT");
//	}
}