using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up : MonoBehaviour {
    public int i = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            i++;
            Destroy(gameObject);
        }
    }
}