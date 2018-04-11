using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret_bomb : MonoBehaviour {
    public GameObject explosionParticlesPrefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("gun_bullet"))
        {

            if (explosionParticlesPrefab)
            {
                GameObject explosion = (GameObject)Instantiate(explosionParticlesPrefab, transform.position, explosionParticlesPrefab.transform.rotation);
                Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetimeMultiplier);
            }

            // Debug.Log("Say");
            Destroy(gameObject);

        }
    }
}
