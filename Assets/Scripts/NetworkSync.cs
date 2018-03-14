using UnityEngine;
using NetworkMessages;



public class NetworkSync : MonoBehaviour {

    public PositionType Type = PositionType.None;
    public GameObject ServerObject = null;
    
    private Transform _t;
    private Server _server;
    
    
    public void Start() {
        _t = GetComponent<Transform>();
        _server = ServerObject.GetComponent<Server>();
        this.InvokeRepeating("Send", 0.1f, 1.0f);

    }

    private void Send() {
        _server.SendPosition(Type, _t.transform.position.x, _t.transform.position.y, _t.transform.position.z);
    }



}
