using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSM_StateRoot : MonoBehaviour
{

    [SerializeField] protected BossState excuteState;

    protected FSM_AI aI;

    protected virtual void Awake()
    {

        aI = FindObjectOfType<FSM_AI>();

    }

    public BossState ExcuteState => excuteState;

    public abstract void OnceExcute();
    public abstract void UpdateExcute();

}
