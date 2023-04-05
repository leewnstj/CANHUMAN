using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class AttackAction : AIAction
{
    protected override void Awake()
    {
        base.Awake();
    }
    public override void TakeAction()
    {
        Debug.Log("Action");
    }
}
