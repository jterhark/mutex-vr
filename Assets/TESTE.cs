using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTE : MonoBehaviour {
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    float MinDist = 0.5f;
    public float range;
    public Transform player;

    Animator anim;
    // Use this for initialization
    void Start () {
        range = 20;
	}

    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if ((Vector3.Distance(player.position, transform.position) <= range))
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                anim.ResetTrigger("Stay");
                anim.SetTrigger("Run");
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

            }


        }
        else
        {
              anim.ResetTrigger("Run");
              anim.SetTrigger("Stay");
        }


    }
}
