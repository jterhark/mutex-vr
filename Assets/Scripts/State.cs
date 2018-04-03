using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/state")]
public class State : ScriptableObject {
    public Action[] actions;
    public Transition[] Transitions;
    public Color GizmoColor = Color.gray;

    public void UpdateState(StateController controller) {
        DoActions(controller);
        CheckTranstions(controller);
    }

    private void DoActions(StateController controller) {
        foreach (var action in actions) {
            action.Act(controller);
        }
    }

    private void CheckTranstions(StateController controller) {
        foreach (var transition in Transitions) {
            controller.TranstionToState(
                transition.decision.Decide(controller) ? transition.trueState : transition.falseState
            );
        }
    }
}