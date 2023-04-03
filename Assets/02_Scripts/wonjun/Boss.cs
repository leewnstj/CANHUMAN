using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField]
    private float _bossHp = 500f;

    [SerializeField]
    private Transform _trm;
    public GameObject _handAttack;
    public float attackcool = 10f;

    private void Awake()
    {
        _trm = GetComponentInChildren<Transform>();
    }

    private void Start()
    {
        StartCoroutine(HandAttack());
    }

    IEnumerator HandAttack()
    {
        Instantiate(_handAttack, _trm.position, Quaternion.identity);
        yield return new WaitForSeconds(attackcool);
    }
}
