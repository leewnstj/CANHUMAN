using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIState : MonoBehaviour
{
    public List<AITransition> Transitions = null;
    public List<AIAction> Actions = new List<AIAction>();


    protected AIBrain _brain;
    private void Awake()
    {
        _brain = transform.GetComponentInParent<AIBrain>();
        if (_brain == null)
        {
            Debug.LogError("뇌가 없다");
        }

        GetComponents<AIAction>(Actions); //자기에 붙어있는 모든 액션 찾아 넣어줌
    }

    public void UpdateState()
    {
        //여기서 원래 내 상태에서 해줘야 할일을 수행해야 한다.

        foreach (AIAction a in Actions)
        {
            a.TakeAction();
        }
        foreach (AITransition t in Transitions)
        {
            if (t.CheckTransition())
            {
                _brain.ChangeState(t.NextState);
                //여기서 상태전환을 해야한다
                break;
            }
        }
    }
}
