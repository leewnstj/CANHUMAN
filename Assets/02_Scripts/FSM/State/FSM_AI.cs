using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FSM_AI : MonoBehaviour
{

    [SerializeField] private BossState currentState;

    private List<FSM_StateRoot> fsm_States = new List<FSM_StateRoot>();
    private List<FSM_StateRoot> currentActions = new List<FSM_StateRoot>();

    private void Awake()
    {

        fsm_States = GetComponentsInChildren<FSM_StateRoot>().ToList();

        //Linq 예제
        currentActions = fsm_States.Where(x => x.ExcuteState == currentState).ToList();

    }

    private void Start()
    {

        //이것도 Linq 예제
        currentActions.ForEach(x =>
        {

            x.OnceExcute();

        });

    }

    public void ChangeState(BossState state)
    {

        currentActions = fsm_States.FindAll(x => x.ExcuteState == state);

        foreach(var item in currentActions)
        {

            item.OnceExcute();

        }

    }

    private void Update()
    {
        
        foreach(var item in currentActions)
        { 
        
            item.UpdateExcute();

        }

    }

}
