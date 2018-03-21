using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig : MonoBehaviour {
   public bool set = false;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (set == false)
            {
                set = true;
            }
            else
            {
                set = false;
            }
            
          //  Debug.Log(set);
           // Destroy(gameObject);
        }
    }
}
