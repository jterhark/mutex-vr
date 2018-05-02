using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using NetworkMessages;


public class Client : NetworkManager {
    


//    public override void OnClientConnect(NetworkConnection conn) {
//        base.OnClientConnect(conn);
//        this.client.RegisterHandler(MessageTypes.PositionUpdate, OnPositionUpdate);
//        Debug.Log("NEW CLIENT CONNECTION");
//    }
//
//
//    private static void OnPositionUpdate(NetworkMessage msg) {
//        var pos = msg.ReadMessage<PositionMessage>();
//        Debug.Log(string.Format("type = {0} | x = {1} | y = {2} | z = {3}", pos.Type, pos.X, pos.Y, pos.Z));
//        
//    }

    public void SendPosition(PositionType posType, float x, float y, float z, float rotX, float rotY, float rotZ) {

        if (this.client == null)
            return;
        
        var msg = new PositionMessage {
            Type =  posType,
            X = x,
            Y = y,
            Z = z,
            RotX = rotX,
            RotY = rotY,
            RotZ = rotZ
        };
        
        //Debug.Log("SENDING");

        if(this.client!=null && this.client.isConnected)
            this.client.Send(MessageTypes.PositionUpdate, msg);
    }
}