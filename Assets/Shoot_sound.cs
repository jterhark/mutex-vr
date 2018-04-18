using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_sound : MonoBehaviour {
     public AudioClip shootSound;
     public AudioSource source;
    // Use this for initialization
    void Start () {
        source.clip = shootSound;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {

             source.Play();
            
        }
    }
}
