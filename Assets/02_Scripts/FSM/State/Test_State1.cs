using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_State1 : FSM_StateRoot
{

    [SerializeField] private bool intnetinetoiner;
    [SerializeField] private BossState bossState = BossState.Attack;

    public override void OnceExcute()
    {

        Debug.Log("FSM_State 1.Once");

    }

    public override void UpdateExcute()
    {

        Debug.Log(1);

        if (intnetinetoiner) aI.ChangeState(bossState);

    }

}
