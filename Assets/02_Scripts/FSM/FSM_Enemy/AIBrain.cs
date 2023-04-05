using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain : MonoBehaviour
{
    [SerializeField] private AIState _aiState; //현재 상태

    [SerializeField] private  Transform _targetTrm;

    public Transform TargetTrm => _targetTrm;

    public void SetDestination(Vector3 pos)
    {
        transform.position += pos * 5 * Time.deltaTime;
    }

    public void ChangeState(AIState naxtState)
    {
        _aiState = naxtState;
    }

    private void Update()
    {
        _aiState?.UpdateState();
    }
}
