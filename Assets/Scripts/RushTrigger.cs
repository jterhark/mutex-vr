using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RushTrigger : MonoBehaviour {

    public static int attackFlag;

    void Start()
    {

    }

    void OnCollisionEnter()
    {
        attackFlag = 1;
        Debug.Log("RushTrigger Triggered");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
