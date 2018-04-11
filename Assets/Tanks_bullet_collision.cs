using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanks_bullet_collision : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("gun_bullet"))
        {

            Destroy(gameObject);
        }
    }

}
