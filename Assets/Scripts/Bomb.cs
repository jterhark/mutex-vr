using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public Material[] material;
    Renderer rend;
    public static int score;


    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnCollisionEnter()
    {
        if (rend.sharedMaterial != material[1])
        {
            score += 1;
        }

        rend.sharedMaterial = material[1];
    }

    // Update is called once per frame
    void Update () {
		
	}
}
