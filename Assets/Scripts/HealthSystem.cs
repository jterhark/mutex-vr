using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class HealthSystem : MonoBehaviour {

	[SerializeField]
    public Text scoreDisplay;
	
	[SerializeField]
	public Transform player;
	
	[SerializeField]
	public Transform respawnPoint;

	public static int _curHealh = 112;
	int _maxHealth = 100;
	string _healthtext;
    Animator anim;
    void Start ()
	{	
	}
    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }
    void Update()
	{
		_healthtext = _curHealh.ToString() + " / " + _maxHealth.ToString();

		if (_curHealh < 0)
		{
			_curHealh = 0;
		}

		if (_curHealh > 100)
		{
			_curHealh = 100;
		}

		if (Input.GetKeyDown("e"))
		{
			_curHealh -= 10;
		}


		if (_curHealh == 0)
		{
            anim.SetTrigger("Gameover");


        }
        if (Input.GetKeyDown("p"))
        {
            player.transform.position = respawnPoint.transform.position;
            _curHealh = 100;
            anim.SetTrigger("Continue");
            anim.ResetTrigger("Gameover");
           
        }


        scoreDisplay.text = _healthtext;
	}
	
	void OnCollisionEnter(Collision col) { 
		if (col.gameObject.tag == "bullet"){ 
			_curHealh -= 20;
		} 
		
		if (col.gameObject.tag == "bullet_pre"){ 
			_curHealh -= 10;
		} 
	} 

}
