using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_fire : MonoBehaviour {

    public GameObject bulletP;
    public Transform position;

   // float vol = 1.5f;
   

    // Use this for initialization
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {

          
              Fire();
        }

    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletP,
            position.position,
            position.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 3.0f);
    }
}
