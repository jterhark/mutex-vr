using UnityEngine;
using NetworkMessages;



public class NetworkSync : MonoBehaviour {

    public PositionType Type = PositionType.None;
    public GameObject ServerObject = null;
    public float Interval = 1.0f;
    public float StartDelay = 0.1f;
    
    private Transform _t;
    private Server _server;
    
    
    public void Start() {
        _t = GetComponent<Transform>();
        _server = ServerObject.GetComponent<Server>();
        this.InvokeRepeating("Send", StartDelay, Interval);

    }

    private void Send() {
        _server.SendPosition(Type, _t.transform.position.x, _t.transform.position.y, _t.transform.position.z);
    }



}
