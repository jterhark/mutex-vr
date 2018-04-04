using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Decisions/Look")]
public class PatrolLookDecision : Decision {
    public override bool Decide(StateController controller) {
        Console.WriteLine("IN LOOK DECISION");
        return Look(controller);
    }

    private bool Look(StateController controller) {
        RaycastHit hit;
        
        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * 15.0f, Color.green);
        
        if (Physics.SphereCast(controller.eyes.position, 2.0f, controller.eyes.forward, out hit, 15.0f) &&
            hit.collider.CompareTag("Player")) {
            controller.target = hit.transform;
            return true;
        }

        return false;
    }
}