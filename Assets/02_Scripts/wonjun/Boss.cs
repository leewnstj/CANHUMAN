using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField]
    private float _bossHp = 500f;
    [SerializeField]
    public GameObject a;

    [SerializeField]
    private string BossHand;
    [SerializeField]
    private Transform _trm;
    public GameObject _handAttack;
    public float attackcool = 10f;

    private void Awake()
    {
        _trm = GameObject.Find("RattackPos").transform;
    }

    private void Start()
    {
        StartCoroutine(HandAttack());
    }

    IEnumerator HandAttack()
    {
        while (true)
        {
            a = PoolList.instance.Pop(BossHand, _trm.position);
            yield return new WaitForSeconds(attackcool);
        }
        
    }

    
}
