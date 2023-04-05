using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDecision : AIDecision
{
    public float Distance = 5f;

    public override bool MakeDecision()
    {
        return Vector2.Distance(_brain.TargetTrm.position, transform.position) < Distance;
        //플레이어의 거리와 나의 거리가 디스턴스보다 작으면 tru 아니면 false 
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
