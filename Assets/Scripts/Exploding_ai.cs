using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploding_ai : MonoBehaviour {

    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    float MinDist = 0.5f;
    bool seto = true;
    public Animation test;
    public GameObject explosionParticlesPrefab;
    Trig set;

    void Start()
    {
        test = GetComponent<Animation>();
        test.AddClip(test.clip, "WalkForward", 0, 2);
        set = GameObject.Find("Explotion_Trigger_Room").GetComponent<Trig>();
    }

    void Update()
    {
        if (seto)
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

            }
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
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
