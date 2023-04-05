using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIDecision : MonoBehaviour
{
    public bool IsReverse = false; 
    protected AIBrain _brain;

    protected virtual void Awake()
    {
        _brain = GetComponentInParent<AIBrain>();
    }
    public abstract bool MakeDecision();
}
