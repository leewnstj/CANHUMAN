using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDecision : AIDecision
{
    public float Distance = 5f;

    public override bool MakeDecision()
    {
        return Vector2.Distance(_brain.TargetTrm.position, transform.position) < Distance;
        //�÷��̾��� �Ÿ��� ���� �Ÿ��� ���Ͻ����� ������ tru �ƴϸ� false 
    }
#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        if (UnityEditor.Selection.activeObject == gameObject)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, Distance);
            Gizmos.color = Color.white;
        }
    }
#endif
}
