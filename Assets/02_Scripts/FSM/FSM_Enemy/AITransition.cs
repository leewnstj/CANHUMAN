using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITransition : MonoBehaviour
{
    public List<AIDecision> Decisions;
    public AIState NextState;
    protected AIBrain _brain;

    private void Awake()
    {
        _brain = transform.GetComponentInParent<AIBrain>();
        if (_brain == null)
        {
            Debug.LogError("³ú°¡ ¾ø´Ù");
        }
    }

    public bool CheckTransition()
    {
        bool result = false;

        foreach (AIDecision d in Decisions)
        {
            result = d.MakeDecision();
            if (d.IsReverse)
                result = !result;

            if (result == false)
                break;
        }

        return result;
    }
}
