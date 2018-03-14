using UnityEngine;
using NetworkMessages;



public class NetworkSync : MonoBehaviour {

    public PositionType Type = PositionType.None;
    public GameObject ClientObject = null;
    public float Interval = 1.0f;
    public float StartDelay = 0.1f;
    
    private Transform _t;
    private Client _client;
    
    
    public void Start() {
        _t = GetComponent<Transform>();
        _client = ClientObject.GetComponent<Client>();
        this.InvokeRepeating("Send", StartDelay, Interval);

    }

    private void Send() {
        _client.SendPosition(Type, _t.transform.position.x, _t.transform.position.y, _t.transform.position.z);
    }



}
