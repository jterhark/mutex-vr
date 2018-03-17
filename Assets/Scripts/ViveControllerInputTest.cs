using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ViveControllerInputTest : MonoBehaviour {


	private SteamVR_TrackedObject tracked;


	private SteamVR_Controller.Device Controller {
		get { return SteamVR_Controller.Input((int) tracked.index); }
	}

	private void Awake() {
		tracked = GetComponent<SteamVR_TrackedObject>();
	}

	// Update is called once per frame
	void Update () {
		// touchpad
		if (Controller.GetAxis() != Vector2.zero)
		{
			Debug.Log(gameObject.name + Controller.GetAxis());
		}

// trigger down
		if (Controller.GetHairTriggerDown())
		{
			Debug.Log(gameObject.name + " Trigger Press");
		}

// trigger up
		if (Controller.GetHairTriggerUp())
		{
			Debug.Log(gameObject.name + " Trigger Release");
		}

// grip down
		if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
		{
			Debug.Log(gameObject.name + " Grip Press");
		}

// grip up
		if (Controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
		{
			Debug.Log(gameObject.name + " Grip Release");
		}
	}
}
