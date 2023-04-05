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
            Debug.LogError("���� ����");
        }

        GetComponents<AIAction>(Actions); //�ڱ⿡ �پ��ִ� ��� �׼� ã�� �־���
    }

    public void UpdateState()
    {
        //���⼭ ���� �� ���¿��� ����� ������ �����ؾ� �Ѵ�.

        foreach (AIAction a in Actions)
        {
            a.TakeAction();
        }
        foreach (AITransition t in Transitions)
        {
            if (t.CheckTransition())
            {
                _brain.ChangeState(t.NextState);
                //���⼭ ������ȯ�� �ؾ��Ѵ�
                break;
            }
        }
    }
}
