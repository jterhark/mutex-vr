using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RushAttack : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 20;
    int MinDist = 10;
    public static int trigger;

    void Start()
    {
        Debug.Log("Running Attack Script");

    }
    
    void OnCollisionEnter()
    {
        HealthSystem._curHealh -= 2;

    }

    void Update()
    {
        //if (trigger == 1)
        //{
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                }

            }
        //}
    }
}