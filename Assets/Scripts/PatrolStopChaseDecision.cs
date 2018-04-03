using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AI/Decisions/StopChase")]
public class PatrolStopChaseDecision : Decision {

	private float slack;
	
	public override bool Decide(StateController controller) {

		RaycastHit hit;
		
		Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * 30.0f, Color.red);
		
		if (Physics.SphereCast(controller.eyes.position, 2.0f, controller.eyes.forward, out hit, 30.0f) &&
		    hit.collider.CompareTag("Player")) {
			slack = Time.time;
			return false;
		}

		if(Time.time - slack > 1.0f)
			return true;

		return false;
	}
}
