using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_general : MonoBehaviour {

    float speed = 2.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
    }
}
