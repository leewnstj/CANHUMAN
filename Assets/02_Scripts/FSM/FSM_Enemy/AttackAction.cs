using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class AttackAction : AIAction
{
    [SerializeField] private AnimationHash _animationHash;
    protected override void Awake()
    {
        base.Awake();
    }
    public override void TakeAction()
    {
        _brain._rigid.velocity = Vector3.zero;
        _animationHash.AttackEnemyAnim(true);
    }
}
