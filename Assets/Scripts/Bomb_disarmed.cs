using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_disarmed : MonoBehaviour {

    public static int score=0;
    public GameObject explosionParticlesPrefab;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if (explosionParticlesPrefab)
            {
                GameObject explosion = (GameObject)Instantiate(explosionParticlesPrefab, transform.position, explosionParticlesPrefab.transform.rotation);
                Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetimeMultiplier);
                score++;
            }

            // Debug.Log("Say");
            Destroy(gameObject);

        }
    }
}
