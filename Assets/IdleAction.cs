using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAction : AIAction
{
    protected override void Awake()
    {
        base.Awake();
    }
    public override void TakeAction()
    {
        Debug.Log("IDLE");
    }
}
