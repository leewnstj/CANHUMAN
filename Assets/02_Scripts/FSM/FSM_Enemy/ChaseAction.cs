using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ChaseAction : AIAction
{
    [SerializeField] AnimationHash _animHash;
    protected override void Awake()
    {
        base.Awake();
    }

    public override void TakeAction()
    {
        Debug.Log("CHASE");
        _brain.SetDestination(_brain.TargetTrm.position - transform.position);
        _animHash.WalkEnemyAnim(true);
    }
}
