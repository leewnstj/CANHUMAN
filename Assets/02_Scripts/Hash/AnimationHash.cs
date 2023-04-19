using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHash : MonoBehaviour
{

    private readonly int EnemyIdleHash = Animator.StringToHash("EnemyIdle");
    private readonly int EnemyWalkHash = Animator.StringToHash("EnemyWalk");
    private readonly int EnemyAttackHash = Animator.StringToHash("EnemyAttack");

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void AttackEnemyAnim(bool value)
    {
        animator.SetBool(EnemyAttackHash, value);
    }

    public void WalkEnemyAnim(bool value)
    {
        animator.SetBool(EnemyWalkHash, value);
    }

    public void IdleEnemyAnim(bool value)
    {
        animator.SetBool(EnemyIdleHash, value);
    }
}
