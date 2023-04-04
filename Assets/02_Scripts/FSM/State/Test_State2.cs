using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_State2 : FSM_StateRoot
{

    //이건 나중에 바꿔
    [SerializeField] private bool intnetinetoiner;

    [SerializeField] private BossState bossState = BossState.Idle;

    public override void OnceExcute()
    {

        Debug.Log("FSM_State2.Once");

    }

    public override void UpdateExcute()
    {

        Debug.Log(2);

        if (intnetinetoiner) aI.ChangeState(bossState);

    }


}
