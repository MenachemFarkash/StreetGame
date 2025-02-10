using UnityEngine;
using UnityEngine.AI;

public class WalkingEngine : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform startLocation;
    public Transform endLocation;



    void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            SetPlayerDestination(endLocation.position);
        }
    }

    public void SetPlayerDestination(Vector3 targetPosition) {
        if (agent == null) {
            print("No Agent Attached");
            return;
        }
        agent.SetDestination(targetPosition);
    }
}
