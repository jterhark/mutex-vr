using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_enemies_soldiers : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("gun_bullet"))
        {
            Destroy(gameObject);
        }
    }

}
