using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {
    public State current;
    public bool active;
    public Transform eyes;
    public Transform[] patrolPoints;
    public State remainState;
    
    [HideInInspector] public Transform target;
    [HideInInspector] public int nextPatrolPoint;
    [HideInInspector] public NavMeshAgent agent;

    private void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update() {
        if (!active)
            return;
        current.UpdateState(this);
    }

    void OnDrawGizmos() {
        if (current != null && eyes != null) {
            Gizmos.color = current.GizmoColor;
            Gizmos.DrawWireSphere(eyes.position, 2.0f);
        }
    }

    public void TranstionToState(State state) {
        if (state != remainState)
            current = state;
    }
}