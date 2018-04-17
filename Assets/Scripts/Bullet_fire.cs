﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_fire : MonoBehaviour {


    public GameObject bullet;
    public Transform position;
    public float range;
    public Transform player;
    
    float start = 0.0f;
    float finish = 50.0f;
  //  public Transform bulletSpawn;
	// Use this for initialization
	void Start () {
        range = 30.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(player.position, transform.position) <= range)
        {
            if (start == 0.0)
            {
                var fire = (GameObject)Instantiate(bullet, position.position, position.rotation);

                fire.GetComponent<Rigidbody>().velocity = fire.transform.forward * 6;
                Destroy(fire, 5.0f);
                //Debug.Log("here");
                start++;
            }
            else if (start == finish)
            {
                start = 0.0f;
                //   Debug.Log("equal");
            }
            else
            {
                start++;
                // Debug.Log("sum");
            }
        }
      
	}

}