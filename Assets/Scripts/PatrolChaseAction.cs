using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AI/Actions/Chase")]
public class PatrolChaseAction : Action {
    public override void Act(StateController controller) {
        Chase(controller);
    }

    private void Chase(StateController controller) {
        controller.agent.destination = controller.target.position;
        controller.agent.Resume();
    }
}
