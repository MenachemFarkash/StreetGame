using UnityEngine;
using UnityEngine.AI;

public class WalkingEngine : MonoBehaviour {

    public NavMeshAgent agent;

    void Start() {

    }

    void Update() {

    }

    public void SetPlayerDestination(Vector3 targetPosition) {
        if (agent != null) {
            print("No Agent Attached");
            return;
        }
        agent.SetDestination(targetPosition);
    }
}
