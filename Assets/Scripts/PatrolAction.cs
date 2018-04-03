using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/Actions/Patrol")]
public class PatrolAction : Action {
    public override void Act(StateController controller) {
        Patrol(controller);
        Console.Write("Acting");
    }

    private void Patrol(StateController controller) {
        controller.agent.destination = controller.patrolPoints[controller.nextPatrolPoint].position;
        controller.agent.Resume();

        if (controller.agent.remainingDistance <= controller.agent.stoppingDistance &&
            !controller.agent.pathPending) {
            controller.nextPatrolPoint = (controller.nextPatrolPoint + 1) % controller.patrolPoints.Length;
        }
    }
}