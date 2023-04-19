using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain : MonoBehaviour
{
    [SerializeField] private AIState _aiState; //현재 상태

    [SerializeField] private  Transform _targetTrm;
    [HideInInspector] public Rigidbody2D _rigid;

    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    public Transform TargetTrm => _targetTrm;

    public void SetDestination(Vector3 pos)
    {
        _rigid.velocity = pos * 2f; //5를 나중에 속도로 바꾸자
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
