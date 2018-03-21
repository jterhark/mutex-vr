using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour {


    [SerializeField]
    public Text KeyDisplay;

    Pick_up key;


    void Start()
    {
        key = GameObject.Find("key_gold").GetComponent<Pick_up>();
    }
    void Update()
    {
        
        KeyDisplay.text = "Keys "+key.i.ToString();

    }
}
