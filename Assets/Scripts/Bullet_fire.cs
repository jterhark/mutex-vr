using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_fire : MonoBehaviour {


    public GameObject bullet;
    public Transform position;
    
    float start = 0.0f;
    float finish = 120.0f;
  //  public Transform bulletSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (start==0.0)
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
