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

	int _curHealh = 100;
	int _maxHealth = 100;
	string _healthtext;

	void Start ()
	{	
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
			player.transform.position = respawnPoint.transform.position;
			_curHealh = 100;
		}

	scoreDisplay.text = _healthtext;
	}

}
