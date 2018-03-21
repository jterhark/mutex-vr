using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    Pick_up key;


    void Start()
    {
        key = GameObject.Find("key_gold").GetComponent<Pick_up>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (key.i == 1)
        {
            Destroy(gameObject);
        }
    }
}
